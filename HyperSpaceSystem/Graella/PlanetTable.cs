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

        #region propfulls 

        private string lat, lng, lat1, lng1, planeta;
        public string Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public string Lng
        {
            get { return lng; }
            set { lng = value; }
        }

        public string Lat1
        {
            get { return lat1; }
            set { lat1 = value; }
        }
        public string Lng1
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

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
