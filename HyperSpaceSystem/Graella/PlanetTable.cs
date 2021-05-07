using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graella
{
    public partial class PlanetTable : UserControl
    {
        #region propfulls 
        Panel p1 = new Panel();
        Panel p2 = new Panel();
        Label l1 = new Label();
        private int num1, let1;
        string planeta;
        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public int Let1
        {
            get { return let1; }
            set { let1 = value; PaintChart(num1, let1, Color.BlueViolet); }
        }
        public string Planeta
        {
            get { return planeta; }
            set { planeta = value; l1.Text ="    "+value; }
        }

        #endregion
        
        public PlanetTable()
        {
            InitializeComponent();
            p1.Width = 10;
            p1.Tag = "P";
            p1.Height = 10;
            p2.Width = 10;
            p1.Tag = "P";
            p2.Height = 10;
            p2.BackColor = Color.Red;
            p1.BackColor = Color.Red;
        }

        private void PaintChart(int let, int num, Color c)
        {
            foreach (Control ct in panel18.Controls)
            {
                if (ct.Tag != null && ct.Tag.ToString() == "P")
                {
                    panel18.Controls.Remove(ct);
                }
            }
            Random rnd = new Random();
            l1.ForeColor = Color.White;
            l1.BackColor = Color.Black;
            Point destPoint = new Point((int)(Math.Round((rnd.Next(1, 7) + 1) * 67.3) * 0.734) + (rnd.Next(1, 7) * 68), (int)Math.Round((rnd.Next(1, 6) * 37.5 * 0.63) + ((rnd.Next(1, 6) - 1) * 50)));
            p2.Location = destPoint;
            l1.Location = destPoint;
            p1.Location = new Point((int)Math.Round(((let + 1) * 67.3) * 0.734) + (let * 68), (int)Math.Round((num * 37.5 * 0.63) + ((num - 1) * 50)));
            panel18.Controls.Add(p1);
            panel18.Controls.Add(p2);
            panel18.Controls.Add(l1);

        }
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}