using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HyperSpaceSystem
{
    public partial class Form1 : Form
    {
        Fucions fcn = new Fucions();
        Fucions.PositionTable pstOrigen = new Fucions.PositionTable();
        Fucions.PositionTable pstDestination = new Fucions.PositionTable();
        XmlDocument xDoc = new XmlDocument();
        string ruta = Application.StartupPath + "\\Recursos\\DataBank.xml";
        int latORI = 0, longORI = 0;

        private void getTableRoute()
        {
            pstOrigen =  fcn.getRoute(latORI,longORI);
            pstDestination =fcn.getRoute( int.Parse(lbl_lat.Text),int.Parse( lbl_long.Text));
            if (pstOrigen.major300 ||pstDestination.major300)
            {
                MessageBox.Show("No hay ruta segura");
            }
            else
            {
                MessageBox.Show(pstOrigen.LAT + " " + pstOrigen.LONG, " " + pstOrigen.codiRoute);
                MessageBox.Show(pstDestination.LAT + " " + pstDestination.LONG + " ", pstDestination.codiRoute);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getNodes();
            getplanets();
            cleanTextbox();
        }

        #region planetes

        private void getplanets()
        {
            XmlNodeList planetsList = xDoc.GetElementsByTagName("name");
            foreach (XmlNode planet in planetsList)
            {
                cmb_planet.Items.Add(planet.InnerText);
                cmb_position.Items.Add(planet.InnerText);
            }
        }
        private void cleanTextbox()
        {
            lbl_filitationText.Text = "";
            lbl_latText.Text = "";
            lbl_longText.Text = "";
            lbl_nativesText.Text = "";
            lbl_planetText.Text = "";
            lbl_sectorText.Text = "";
            lbl_routesText.Text = "";

            lsb_routes.Visible = false;

            lbl_filiation.Text = "";
            lbl_lat.Text = "";
            lbl_long.Text = "";
            lbl_natives.Text = "";
            lbl_planet.Text = "";
            lbl_sector.Text = "";
        }

        private void getNodes()
        {
            xDoc.Load(ruta);
            XmlNode root = xDoc.DocumentElement;
            cmb_category.Items.Add(" ");
            cmb_category.SelectedItem = " ";
            foreach (XmlNode item in root)
            {
                cmb_category.Items.Add(item.Name);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            XmlNodeList planetList = xDoc.GetElementsByTagName("planet");
            getLongLatOrigenPlanet();
            showDataPlanetSelectedDest();
            getTableRoute();
        }

        private void getLongLatOrigenPlanet()
        {
            string selectedPlanet = cmb_position.SelectedItem.ToString(); ;

            XmlNodeList selectedPlanetChilds = xDoc.SelectNodes("/SpaceData/planets/planet[name=\"" + selectedPlanet + "\"]/*");
            List<string> selectedPlanetData = new List<string>();
            foreach (XmlNode node in selectedPlanetChilds)
            {
                selectedPlanetData.Add(node.InnerText);
            }

            latORI = Int32.Parse(selectedPlanetChilds[3].SelectSingleNode("lat").InnerText);
            longORI= Int32.Parse(selectedPlanetChilds[3].SelectSingleNode("long").InnerText);
        }

        private void showDataPlanetSelectedDest()
        {
            string selectedPlanet = cmb_planet.SelectedItem.ToString(); ;
            lsb_routes.Visible = true;
            lsb_routes.Items.Clear();

            XmlNodeList selectedPlanetChilds = xDoc.SelectNodes("/SpaceData/planets/planet[name=\"" + selectedPlanet + "\"]/*");
            List<string> selectedPlanetData = new List<string>();
            foreach (XmlNode node in selectedPlanetChilds)
            {
                selectedPlanetData.Add(node.InnerText);
            }

            string imagePath = Application.StartupPath + "\\Recursos\\planetes\\" + selectedPlanet + ".png";
            if (!File.Exists(@imagePath))
            {
                imagePath = imagePath.Replace(".png", ".jpg");
            }

            pictureBox1.Image = Image.FromFile(@imagePath);

            lbl_filitationText.Text = "Filiation";
            lbl_latText.Text = "Latitude";
            lbl_longText.Text = "Longitude";
            lbl_nativesText.Text = "Natives";
            lbl_planetText.Text = "Planet";
            lbl_sectorText.Text = "Sector";

            lbl_sector.Text = selectedPlanetData[1];
            lbl_filiation.Text = selectedPlanetData[2]; ;
            lbl_lat.Text = selectedPlanetChilds[3].SelectSingleNode("lat").InnerText;
            lbl_long.Text = selectedPlanetChilds[3].SelectSingleNode("long").InnerText;
            lbl_natives.Text = selectedPlanetData[5];
            lbl_planet.Text = selectedPlanet;

            XmlNodeList routes = selectedPlanetChilds[4].ChildNodes;

            string minorRoute = "MINOR";

            if (routes.Count > 1)
            {
                lsb_routes.Items.Add("MAJOR");
            }
            else
            {
                minorRoute = "";
            }

            foreach (XmlNode route in routes)
            {
                lsb_routes.Items.Add(route.InnerText);
                lsb_routes.Items.Add(" ");
                lsb_routes.Items.Add(minorRoute);
                minorRoute = " ";
            }
        }
        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categorySelected = cmb_category.SelectedItem.ToString();
            cmb_planet.Items.Clear();
            cmb_planet.Items.Add(" ");
            cmb_planet.SelectedItem = " ";
            getValues(categorySelected);
        }

        private void getValues(string category)
        {
            if (category == "filiations")
            {
                getFiliation();
            }
            else if (category == "regions")
            {
                getRegions();
            }
            else if (category == "planets")
            {
                getPlanets();
            }
        }

        private void getFiliation()
        {
            XmlNodeList filiationsList = xDoc.GetElementsByTagName("description");
            foreach (XmlNode filiation in filiationsList)
            {
                cmb_planet.Items.Add(filiation.InnerText);
            }
        }

        private void getRegions()
        {
            XmlNodeList regionsList = xDoc.GetElementsByTagName("nameRegion");
            foreach (XmlNode region in regionsList)
            {
                cmb_planet.Items.Add(region.InnerText.Replace("-", ""));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void getPlanets()
        {
            XmlNodeList planetsList = xDoc.GetElementsByTagName("name");
            foreach (XmlNode planet in planetsList)
            {
                cmb_planet.Items.Add(planet.InnerText);
            }
        }
        #endregion
    }
}
