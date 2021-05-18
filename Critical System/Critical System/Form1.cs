using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaXWigns;

namespace Critical_System
{
    public partial class Form1 : Form
    {
        string[] llibres = new string[5] { "http://www.gutenberg.org/files/120/120-0.txt", "http://www.gutenberg.org/cache/epub/57303/pg57303.txt", "http://www.gutenberg.org/cache/epub/1228/pg1228.txt", "http://www.gutenberg.org/cache/epub/2000/pg2000.txt", "http://www.gutenberg.org/files/1524/1524-0.txt" };
        ProgressBar[] progressBars;
        List<string> libros = new List<string>();
        BibliotecaXWigns.HelperMethods hlp = new BibliotecaXWigns.HelperMethods();
        Thread downloadBooks,hilo1;
        Thread[] hilos ;

        public Form1()
        {
            InitializeComponent();
            progressBars = new ProgressBar[5] { pgb_armament, pgb_motor, pgb_generador, pgb_refector, pgb_sensor };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hilos = new Thread[] { downloadBooks,hilo1};
            downloadBooks = new Thread(getBooks);
            downloadBooks.Start();
        }

        private void getBooks()
        {
            bool network;
            changeDownloadingBooklbl("Downloading Books");
            resetProgressBar();

            try
            {
                network = networkConnection();
                if (network)
                {
                    Parallel.For(0, llibres.Length, (i, state) =>
                    {
                        string text = "";
                        WebRequest request = WebRequest.Create(llibres[i]);
                        using (WebResponse response = request.GetResponse())
                        {
                            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                            {
                                text = stream.ReadToEnd();
                                libros.Add(text);
                            }
                        }
                    });
                    changeDownloadingBooklbl("Downloaded books");
                    enableButton();
                }
                else
                {
                    changeDownloadingBooklbl("Please check that you have a good connection to the network");
                }
            }
            catch (Exception o)
            {
                MessageBox.Show(o.Message, "Internal Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (downloadBooks.IsAlive)
            {
                downloadBooks.Abort();
            }

            for (int i = 0; i < progressBars.Length; i++)
            {
                progressBars[i].Value = 0;
            }
            resetProgressBar();
            hilo1 = new Thread(new ThreadStart(startProcess));
            hilo1.Start();
        }

        private void startProcess()
        {
            int contador = 0;
            foreach (string item in libros)
            {
                dotChecks(item, progressBars[contador]);
                contador++;
            }
        }
        private void dotChecks(string llibre, ProgressBar pgb)
        {
            string[] words = llibre.Split(' ');
            processBook(words, pgb);
        }

        private void processBook(string[] words, ProgressBar pgb)
        {
            string[] Searchwords = { "white", "time", "that", "the", "empty", "door", "table" };
            string[] SearchLetter = { "A", "C", "W", "Z", "L", "S", "E" };

            Random rnd = new Random();

            Parallel.Invoke(() =>
            {
                Console.WriteLine(hlp.GetMostCommonWords(words, rnd.Next(4, 10), rnd.Next(5, 10)));
                updateProgressbar(pgb);
            },
            () =>
            {
                Console.WriteLine(hlp.GetMostCommonWordsByLength(words, rnd.Next(4, 10), rnd.Next(5, 10)));
                updateProgressbar(pgb);
            },
            () =>
            {
                for (int o = 0; o < Searchwords.Length; o++)
                {
                    Console.WriteLine(hlp.GetCountForWord(words, Searchwords[o]));
                    Console.WriteLine(hlp.GetCountForLetter(words, Searchwords[o]));
                }
                updateProgressbar(pgb);
                updateProgressbar(pgb);
            },
            () =>
            {
                Console.WriteLine(hlp.GetLessCommonWords(words, rnd.Next(4, 10), rnd.Next(5, 10)));
                updateProgressbar(pgb);
            },
            () =>
            {
                Console.WriteLine(hlp.GetLongestWord(words));
                updateProgressbar(pgb);
            }
            );
            enableButton();
        }

        private bool networkConnection()
        {
            System.Uri Url = new System.Uri("https://www.google.com/");
            System.Net.WebRequest WebRequest;
            System.Net.WebResponse objetoResp;
            bool network = false;
            WebRequest = System.Net.WebRequest.Create(Url);
            
            try
            {
                objetoResp = WebRequest.GetResponse();
                network = true;
                objetoResp.Close();
            }
            catch (Exception)
            {
                network = false;
            }
            return network;
        }

        #region Invoke
        private void resetProgressBar()
        {
            for (int i = 0; i < progressBars.Length; i++)
            {
                if (InvokeRequired)
                {
                    progressBars[i].Invoke(new MethodInvoker(delegate ()
                    {
                        progressBars[i].Value = 0;
                    }));
                }
            }
            blocButton();
        }

        private void updateProgressbar(ProgressBar pgb)
        {
            if (InvokeRequired)
            {
                pgb.Invoke(new MethodInvoker(delegate ()
                {
                    pgb.Value += 10;
                }));
            }
        }

        private void enableButton()
        {
            if (InvokeRequired)
            {
                button1.Invoke(new MethodInvoker(delegate ()
                {
                    button1.Enabled = true;
                }));
            }
        }

        private void blocButton()
        {
            if (InvokeRequired)
            {
                button1.Invoke(new MethodInvoker(delegate ()
                {
                    button1.Enabled = false;
                }));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void changeDownloadingBooklbl(string state)
        {
            if (InvokeRequired)
            {
                lbl_download.Invoke(new MethodInvoker(delegate ()
                {
                    lbl_download.Text = state;
                }));
            }
        }
        #endregion
    }
}
