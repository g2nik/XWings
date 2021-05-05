﻿using Graella;
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

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cleanTextbox();
            getNodes();
            getplanets();
        }
       
        #region Buttons
        private void btn_Search_Click(object sender, EventArgs e)
        {
            XmlNodeList planetList = xDoc.GetElementsByTagName("planet");
            getLongLatOrigenPlanet();
            showDataPlanetSelectedDest();
            getTableRoute();
            clearForm1();
        }

        private void clearForm1()
        {
            lbl_Route.Text = "";
            lbl_planet.Text = "";
            lbl_orDes.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(ruta);

            XmlNode nodeList = doc.SelectSingleNode("/hyperSpacedata/hyperspaceRoutes/definedRoutes");
            XmlElement route = doc.CreateElement("defineRoutes"); ;
            XmlElement ordes = doc.CreateElement("OrDes");
            XmlElement selectedRoute = doc.CreateElement("selectedRoute");
            XmlElement map = doc.CreateElement("map");

            ordes.InnerText = lbl_orDes.Text;
            selectedRoute.InnerText = lsb_routes.SelectedItem.ToString();
            map.InnerText = lbl_Image.Text;

            route.AppendChild(ordes);
            route.AppendChild(selectedRoute);
            route.AppendChild(map);
            nodeList.AppendChild(route);

            doc.Save(ruta);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opflg = new OpenFileDialog())
            {
                opflg.InitialDirectory = Application.StartupPath + "\\Recursos\\planetes";

                if (opflg.ShowDialog() == DialogResult.OK)
                {
                    string ruta = opflg.FileName;
                    lbl_Image.Text = opflg.FileName.Substring(opflg.FileName.LastIndexOf('\\') + 1);
                    Pict_planetRoute.Image = Image.FromFile(ruta);
                }
            }
        }
        #endregion

        #region Index Changed

        private void lsb_routes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_orDes.Text = cmb_position.SelectedItem + "-" + cmb_planet.SelectedItem;
            string ruta = lsb_routes.SelectedItem.ToString();
            XmlNodeList selectedPlanetChilds = xDoc.SelectNodes("/hyperSpacedata/hyperspaceRoutes/definedRoutes/defineRoute[selectedRoute=\""+ruta+"\"]/*");
            List<string> selectedPlanetData = new List<string>();
            foreach (XmlNode node in selectedPlanetChilds)
            {
                selectedPlanetData.Add(node.InnerText);
            }
            try
            {
                lbl_Image.Text = selectedPlanetData[2];
                Pict_planetRoute.Image = Image.FromFile(Application.StartupPath + "\\Recursos\\planetes\\" + lbl_Image.Text);
            }
            catch (Exception)
            {
                lbl_Image.Text = "No image Selected";
                Pict_planetRoute.Image = null;
            }

            if (lsb_routes.SelectedItem.ToString() != "" && lsb_routes.SelectedItem.ToString() != "Minor hyperspace route" && lsb_routes.SelectedItem.ToString() != "Major hyperspace route")
            {
                lbl_Route.Text = lsb_routes.SelectedItem.ToString();
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
        #endregion

        #region Get Values
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

        private void getplanets()
        {
            XmlNodeList planetsList = xDoc.GetElementsByTagName("name");
            foreach (XmlNode planet in planetsList)
            {
                cmb_planet.Items.Add(planet.InnerText);
                cmb_position.Items.Add(planet.InnerText);
            }
        }

        private void getTableRoute()
        {
            pstOrigen = fcn.getRoute(latORI, longORI);
            pstDestination = fcn.getRoute(int.Parse(lbl_lat.Text), int.Parse(lbl_long.Text));
            PlanetTable pt = new PlanetTable();
            pt.Lat = pstOrigen.LAT;
            pt.Lat = pstOrigen.LONG;
            panel1.Controls.Add(pt);
        }

        private void getLongLatOrigenPlanet()
        {
            string selectedPlanet = cmb_position.SelectedItem.ToString(); ;
            XmlNodeList selectedPlanetChilds = xDoc.SelectNodes("/hyperSpacedata/planets/planet[name=\"" + selectedPlanet + "\"]/*");
            List<string> selectedPlanetData = new List<string>();

            foreach (XmlNode node in selectedPlanetChilds)
            {
                selectedPlanetData.Add(node.InnerText);
            }
            latORI = Int32.Parse(selectedPlanetChilds[3].SelectSingleNode("lat").InnerText);
            longORI = Int32.Parse(selectedPlanetChilds[3].SelectSingleNode("long").InnerText);
        }

        private void getMayorMinor(string ruta, int NumRutes)
        {
            string selectedPlanet = ruta;
            XmlNodeList selectedPlanetChilds = xDoc.SelectNodes("/hyperSpacedata/hyperspaceRoutes/Route[nameRoute=\"" + selectedPlanet + "\"]/*");
            List<string> selectedPlanetData = new List<string>();

            foreach (XmlNode node in selectedPlanetChilds)
            {
                selectedPlanetData.Add(node.InnerText);
            }

            lsb_routes.Items.Add(selectedPlanetData[0]);
            lsb_routes.Items.Add(selectedPlanetData[1]);
            lsb_routes.Items.Add("");
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

        private void getPlanets()
        {
            XmlNodeList planetsList = xDoc.GetElementsByTagName("name");
            foreach (XmlNode planet in planetsList)
            {
                cmb_planet.Items.Add(planet.InnerText);
            }
        }
        #endregion

        #region Show Data
        private void showDataPlanetSelectedDest()
        {
            string selectedPlanet = cmb_planet.SelectedItem.ToString() ;
            lsb_routes.Visible = true;
            lsb_routes.Items.Clear();

            XmlNodeList selectedPlanetChilds = xDoc.SelectNodes("/hyperSpacedata/planets/planet[name=\"" + selectedPlanet + "\"]/*");
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

            writeLbl(selectedPlanetChilds, selectedPlanetData);

             XmlNodeList routes = selectedPlanetChilds[4].ChildNodes;
            foreach (XmlNode item in routes)
            {
                getMayorMinor(item.InnerText, routes.Count);
            }
        }
        private void writeLbl(XmlNodeList selectedPlanetChilds, List<string> selectedPlanetData)
        {
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
            lbl_planet.Text = cmb_planet.SelectedItem.ToString();
        }

        #endregion
    }
}
