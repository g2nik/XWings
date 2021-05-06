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
    public partial class PlanetTable: UserControl
    {
        Panel p1, p2;
        #region propfulls 

        private int lat, lng, lat1, lng1;
        string planeta;
        public int Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public int Lng
        {
            get { return lng; }
            set { lng = value; PaintChart(lat, Lng); }
        }

        public int Lat1
        {
            get { return lat1; }
            set { lat1 = value; }
        }
        public int Lng1
        {
            get { return lng1; }
            set { lng1 = value; }
        }
        public string Planeta
        {
            get { return planeta; }
            set { planeta = value; }
        }

        #endregion
        public PlanetTable()
        {
            InitializeComponent();
        }
        private void PaintChart(int lat, int lng)
        {
            Panel p1 = new Panel();
            Panel p2 = new Panel();
            p1.Width = 100;
            p1.Height = 100;
            p2.Width = 10;
            p2.Height = 10;
            p1.BackColor = Color.Red;
            p1.Location = new Point(100, 10);
            p1.BringToFront();
            this.Controls.Add(p1);
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
