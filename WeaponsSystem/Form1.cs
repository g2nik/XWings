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

        int beforeVideoCount = 0;
        int afterVideoCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            lblPlanos.Visible = false;
            videoDestruccion.Visible = false;
            videoModelo.Visible = false;
            videoModelo.settings.setMode("loop", true);
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
                beforeVideoTimer.Enabled = true;
                fixedTarget = true;
                paintColor = Color.Red;
                imagenNave.Image = Image.FromFile("naves/xwing-enemy.png");
                Invalidate();
                Update();
                Refresh();
            }
        }

        private async void detectar()
        {
            if (detectarNave())
            {
                string texto = File.Exists("targets.txt") ? File.ReadAllText("targets.txt") : "";
                string[] lineas = texto.Split('\n');

                Random r = new Random();
                int aleatorio = r.Next(lineas.Length);
                string nombreNave = lineas[aleatorio].Substring(0, lineas[aleatorio].IndexOf('|'));
                bool aliado = lineas[aleatorio].Substring(lineas[aleatorio].Length - 2, 1) == "A";

                lblPlanos.Visible = true;
                lblPlanos.Text = aliado ? $"Planos de {nombreNave} aliado" : $"Planos de {nombreNave} enemigo";

                videoModelo.Visible = true;
                videoModelo.URL = $"videos/{nombreNave}.mp4";
                videoModelo.Ctlcontrols.play();
                imagenPlanos.Visible = true;
                imagenPlanos.Image = Image.FromFile($"planos/{nombreNave}.jpg");

                lblPlanos.ForeColor = aliado ? Color.PaleGreen : Color.Red;
                btnAtacar.Visible = !aliado;
                paintColor = aliado ? Color.PaleGreen : Color.Red;
                imagenNave.Image = aliado ? Image.FromFile("naves/xwing-ally.png") : Image.FromFile("naves/xwing-enemy.png");
                Invalidate();
                Update();
                Refresh();
            }
            tDetectar.Abort();
        }

        private bool detectarNave(bool refresh = true)
        {
            bool result = false;

            if (imagenNave.Location.X >= 230 && imagenNave.Location.X <= 260
                && imagenNave.Location.Y >= 180 && imagenNave.Location.Y <= 210)
            {
                result = true;
                paintColor = Color.Yellow;
                imagenNave.Image = Image.FromFile("naves/xwing-detected.png");
            }
            else
            {
                paintColor = Color.Cyan;
                imagenNave.Image = Image.FromFile("naves/xwing.png");
            }

            if (refresh)
            {
                Invalidate();
                Update();
                Refresh();
            }
            
            return result;
        }

        private void dibujarNave()
        {
            Random r = new Random();
            int x = r.Next(50, 450);
            int y = r.Next(50, 350);
            imagenNave.Location = new Point(x, y);
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            imagenNave.Location = new Point(imagenNave.Location.X, imagenNave.Location.Y - movementY);
            detectarNave();
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            imagenNave.Location = new Point(imagenNave.Location.X, imagenNave.Location.Y + movementY);
            detectarNave();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            imagenNave.Location = new Point(imagenNave.Location.X + movementX, imagenNave.Location.Y);
            detectarNave();
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            imagenNave.Location = new Point(imagenNave.Location.X - movementX, imagenNave.Location.Y);
            detectarNave();
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
                int initialY1 = 5;

                int initialX2 = 605;
                int initialY2 = 505;

                if (beforeVideoCount == 0)
                {
                    e.Graphics.DrawLine(pen, initialX1, initialY1, 55, 55);
                    e.Graphics.DrawLine(pen, initialX2, initialY1, 555, 55);
                    e.Graphics.DrawLine(pen, initialX1, initialY2, 55, 455);
                    e.Graphics.DrawLine(pen, initialX2, initialY2, 555, 455);
                }
                else if (beforeVideoCount == 1)
                {
                    e.Graphics.DrawLine(pen, initialX1, initialY1, 105, 105);
                    e.Graphics.DrawLine(pen, initialX2, initialY1, 505, 105);
                    e.Graphics.DrawLine(pen, initialX1, initialY2, 105, 405);
                    e.Graphics.DrawLine(pen, initialX2, initialY2, 505, 405);
                }
                else if(beforeVideoCount == 2)
                {
                    e.Graphics.DrawLine(pen, initialX1, initialY1, 155, 155);
                    e.Graphics.DrawLine(pen, initialX2, initialY1, 455, 155);
                    e.Graphics.DrawLine(pen, initialX1, initialY2, 155, 355);
                    e.Graphics.DrawLine(pen, initialX2, initialY2, 455, 355);
                }
                else //(beforeVideoCount == 3)
                {
                    e.Graphics.DrawLine(pen, initialX1, initialY1, 205, 205);
                    e.Graphics.DrawLine(pen, initialX2, initialY1, 405, 205);
                    e.Graphics.DrawLine(pen, initialX1, initialY2, 205, 305);
                    e.Graphics.DrawLine(pen, initialX2, initialY2, 405, 305);
                }
            }
            pen.Dispose();
        }

        private void beforeVideo_Tick(object sender, EventArgs e)
        {
            if (beforeVideoCount == 4)
            {
                beforeVideoTimer.Enabled = false;
                beforeVideoCount = 0;
                afterVideoTimer.Enabled = true;
            } else {
                beforeVideoCount++;
                Invalidate();
                Update();
                Refresh();
            }
        }

        private void afterVideo_Tick(object sender, EventArgs e)
        {
            if (afterVideoCount == 0)
            {
                videoDestruccion.Visible = true;
                videoDestruccion.Ctlcontrols.play();
                afterVideoCount++;
            }
            else if (afterVideoCount == 2)
            {
                videoDestruccion.Ctlcontrols.stop();
                afterVideoTimer.Enabled = false;
                afterVideoCount = 0;

                fixedTarget = false;
                videoDestruccion.Visible = false;
                videoModelo.Visible = false;
                imagenPlanos.Visible = false;
                lblPlanos.Visible = false;
                btnAtacar.Visible = false;
                
                paintColor = Color.Cyan;
                imagenNave.Image = Image.FromFile("naves/xwing.png");
                dibujarNave();
                Invalidate();
                Update();
                Refresh();
            }
            else afterVideoCount++;
        }
    }
}
