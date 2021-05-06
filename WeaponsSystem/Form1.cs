using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeaponsSystem
{
    public partial class Form1 : Form
    {
        Thread tDetectar;
        Color paintColor = Color.Cyan;
        const int movementX = 20;
        const int movementY = 15;
        bool fixedTarget = false;

        bool firstLine = false;
        bool secondLine = false;
        bool thirdLine = false;
        bool fourthLine = false;

        int beforeVideoCount = 0;
        int afterVideoCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            lblTipo.Visible = false;
            video.Visible = false;
            btnAtacar.Visible = false;
            dibujarNave();
            tDetectar = new Thread(detectar);
        }

        private void btnDetectar_Click(object sender, EventArgs e)
        {
            if (tDetectar != null)
            {
                if (tDetectar.IsAlive) tDetectar.Abort();
                tDetectar = new Thread(detectar);
                tDetectar.Start();
            }
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            if (detectarNave(false))
            {
                beforeVideo.Enabled = true;
                fixedTarget = true;
                paintColor = Color.Red;
                image.Image = Image.FromFile("xwing-enemy.png");
                Invalidate();
                Update();
                Refresh();
            }
        }

        private async void detectar()
        {
            string texto = await fileToString("targets.txt");
            string[] lineas = texto.Split('\n');
            Random r = new Random();
            int aleatorio = r.Next(lineas.Length);
            bool aliado = lineas[aleatorio].Substring(lineas[aleatorio].Length - 2, 1) == "A";
            lblTipo.Visible = true;
            lblTipo.Text = aliado ? "Aliado" : "Enemigo";
            lblTipo.ForeColor = aliado ? Color.PaleGreen : Color.Red;
            btnAtacar.Visible = !aliado;
            paintColor = aliado ? Color.PaleGreen : Color.Red;
            image.Image = aliado ? Image.FromFile("xwing-ally.png") : Image.FromFile("xwing-enemy.png");
            Invalidate();
            Update();
            Refresh();
            tDetectar.Abort();
        }

        private bool detectarNave(bool refresh = true)
        {
            bool result = false;

            if (image.Location.X >= 230 && image.Location.X <= 260
                && image.Location.Y >= 180 && image.Location.Y <= 210)
            {
                result = true;
                paintColor = Color.Yellow;
                image.Image = Image.FromFile("xwing-detected.png");
            }
            else
            {
                paintColor = Color.Cyan;
                image.Image = Image.FromFile("xwing.png");
            }

            if (refresh)
            {
                Invalidate();
                Update();
                Refresh();
            }
            
            return result;
        }

        private async Task<string> fileToString(string path)
        {
            return File.Exists(path) ? File.ReadAllText(path) : "";
        }

        private void dibujarNave()
        {
            Random r = new Random();
            int x = r.Next(50, 450);
            int y = r.Next(50, 350);
            image.Location = new Point(x, y);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(paintColor, 2);
            RectangleF[] rectArray =
            {
                new Rectangle(5, 5, 600, 500),
                new Rectangle(55, 55, 500, 400),
                new Rectangle(105, 105, 400, 300),
                new Rectangle(155, 155, 300, 200),
                new Rectangle(205, 205, 200, 100),
            };
            
            e.Graphics.DrawRectangles(pen, rectArray);

            if (fixedTarget)
            {
                int initialX1 = 5;
                int initialX2 = 605;
                int initialY1 = 5;
                int initialY2 = 505;

                if (firstLine)
                {
                    e.Graphics.DrawLine(pen, initialX1, initialY1, 55, 55);
                    e.Graphics.DrawLine(pen, initialX2, initialY1, 555, 55);
                    e.Graphics.DrawLine(pen, initialX1, initialY2, 55, 455);
                    e.Graphics.DrawLine(pen, initialX2, initialY2, 555, 455);
                }
                if (secondLine)
                {
                    e.Graphics.DrawLine(pen, initialX1, initialY1, 105, 105);
                    e.Graphics.DrawLine(pen, initialX2, initialY1, 505, 105);
                    e.Graphics.DrawLine(pen, initialX1, initialY2, 105, 405);
                    e.Graphics.DrawLine(pen, initialX2, initialY2, 505, 405);
                }
                if (thirdLine)
                {
                    e.Graphics.DrawLine(pen, initialX1, initialY1, 155, 155);
                    e.Graphics.DrawLine(pen, initialX2, initialY1, 455, 155);
                    e.Graphics.DrawLine(pen, initialX1, initialY2, 155, 355);
                    e.Graphics.DrawLine(pen, initialX2, initialY2, 455, 355);
                }
                if (fourthLine)
                {
                    e.Graphics.DrawLine(pen, initialX1, initialY1, 205, 205);
                    e.Graphics.DrawLine(pen, initialX2, initialY1, 405, 205);
                    e.Graphics.DrawLine(pen, initialX1, initialY2, 205, 305);
                    e.Graphics.DrawLine(pen, initialX2, initialY2, 405, 305);
                }

                //if (firstLine) e.Graphics.DrawLine(pen, 5, 5, 205, 205);
                //if (secondLine)  e.Graphics.DrawLine(pen, 605, 5, 405, 205);
                //if (thirdLine) e.Graphics.DrawLine(pen, 5, 505, 205, 305);
                //if (fourthLine) e.Graphics.DrawLine(pen, 605, 505, 405, 305);
            }
            pen.Dispose();
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            image.Location = new Point(image.Location.X, image.Location.Y - movementY);
            detectarNave();
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            image.Location = new Point(image.Location.X, image.Location.Y + movementY);
            detectarNave();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            image.Location = new Point(image.Location.X + movementX, image.Location.Y);
            detectarNave();
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            image.Location = new Point(image.Location.X - movementX, image.Location.Y);
            detectarNave();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                image.Location = new Point(image.Location.X, image.Location.Y - movementY);
                detectarNave();
            }
        }

        private void beforeVideo_Tick(object sender, EventArgs e)
        {
            if (beforeVideoCount == 1)
            {
                firstLine = true;
            }
            else if (beforeVideoCount == 2)
            {
                secondLine = true;
            }
            else if (beforeVideoCount == 3)
            {
                thirdLine = true;
            }
            else if (beforeVideoCount == 4)
            {
                fourthLine = true;
            }
            else if (beforeVideoCount == 5)
            {
                beforeVideo.Enabled = false;
                afterVideo.Enabled = true;

            }
            beforeVideoCount++;
            Invalidate();
            Update();
            Refresh();
        }

        private void afterVideo_Tick(object sender, EventArgs e)
        {
            if (afterVideoCount == 1)
            {
                video.Visible = true;
                video.Ctlcontrols.play();
            }
            else if (afterVideoCount == 3)
            {
                afterVideo.Enabled = false;
                video.Visible = false;
                fixedTarget = false;
                lblTipo.Visible = false;
                btnAtacar.Visible = false;
                beforeVideoCount = 0;
                afterVideoCount = 0;
                firstLine = false;
                secondLine = false;
                thirdLine = false;
                fourthLine = false;
                Invalidate();
            }
            
            afterVideoCount++;
        }
    }
}
