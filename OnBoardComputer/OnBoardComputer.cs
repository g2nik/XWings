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
using System.Xml.Linq;

namespace OnBoardComputer
{
    public partial class OnBoardComputer : Form
    {
        XDocument info;
        List<string> categorias = new List<string>();
        String nombreElemento;
        public OnBoardComputer()
        {
            InitializeComponent();
        }

        private void OnBoardComputer_Load(object sender, EventArgs e)
        {
            info = XDocument.Load(@"DataBank.xml");
            mostrarEtiquetas(false, 1, 5);
            pnlSlider.Visible = false;
            categorias.Add("");
            categorias.Add("Planetas");
            categorias.Add("Rutas");
            categorias.Add("Regiones");
            categorias.Add("Mapas");
            foreach (string categoria in categorias) cmbCategoria.Items.Add(categoria);
        }

        TreeNode elementoANodo(XElement elemento)
        {
            TreeNode nodo = new TreeNode();
            nodo.Text = elemento.Value.Replace("-", " ");
            nodo.Name = elemento.Value.Replace("-", " ");
            return nodo;
        }

        void mostrarEtiquetas(bool mostrar, int inicio, int fin)
        {
            for (int i = inicio; i <= fin; i++)
            {
                Control[] controlesTitulo = this.Controls.Find($"lblTitle{i}", true);
                if (controlesTitulo.Length > 0)
                {
                    Label titulo = controlesTitulo[0] as Label;
                    if (titulo != null) titulo.Visible = mostrar;
                }

                Control[] controlesValor = this.Controls.Find($"lblValue{i}", true);
                if (controlesValor.Length > 0)
                {
                    Label valor = controlesValor[0] as Label;
                    if (valor != null) valor.Visible = mostrar;
                }
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem != null)
            {
                if (cmbCategoria.SelectedItem.ToString() != "")
                {
                    arbol.Nodes.Clear();
                    //TreeNode raiz = new TreeNode();
                    //raiz.Text = cmbCategoria.SelectedItem.ToString();
                    int index = cmbCategoria.SelectedIndex;
                    string nombreCampo = "";

                    if (index == 1)
                    {
                        nombreCampo = "name";
                    }
                    else if (index == 2)
                    {
                        nombreCampo = "route";
                    }
                    else if (index == 3)
                    {
                        nombreCampo = "nameRegion";
                    }
                    else if (index == 4)
                    {
                        pnlSlider.Visible = true;
                        pnlSlider.BringToFront();
                        return;
                    }

                    var conjunto = info.Descendants(nombreCampo);
                    foreach (XElement elemento in conjunto)
                    {
                        if (!arbol.Nodes.ContainsKey(elemento.Value))
                        {
                            arbol.Nodes.Add(elementoANodo(elemento));
                        }
                    }
                }
            }
        }
        private void arbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (arbol.SelectedNode.Text != null)
            {
                if (!categorias.Contains(arbol.SelectedNode.Text))
                {
                    nombreElemento = arbol.SelectedNode.Text;
                    int index = cmbCategoria.SelectedIndex;
                    getdata(index);
                }
            }
        }

        private void getdata(int index)
        {
            if (index ==1 )
            {
                getPlanets();
            }
            else if(index ==2 )
            {
                getRoutes();
            }
            else if (index == 3)
            {
                getRegions();
            }
        }
        void getPlanets()
        {
            pictureBox.Visible = true;
            pnlSlider.Visible = false;
            mostrarEtiquetas(true, 1, 5);
            var datosPlaneta = info.Descendants("planet")
                .Where(c => c.Descendants("name")
                .SingleOrDefault().Value == nombreElemento)
                .Descendants();

            lblTitle1.Text = "Nombre";
            lblValue1.Text = datosPlaneta.ElementAt(0).Value;

            lblTitle2.Text = "Sector";
            lblValue2.Text = datosPlaneta.ElementAt(1).Value;

            lblTitle3.Text = "Afiliacion";
            lblValue3.Text = datosPlaneta.ElementAt(2).Value;

            lblTitle3.Text = "Latitud / longitud / parsecs";
            string lat = datosPlaneta.ElementAt(3).Element("lat").Value;
            string lng = datosPlaneta.ElementAt(3).Element("long").Value;
            string parsecs = lng = datosPlaneta.ElementAt(3).Element("parsecs").Value;
            lblValue3.Text = lat + " / " + lng + " / " + parsecs;

            lblTitle4.Text = "Rutas";
            lblValue4.Text = "";
            var rutas = datosPlaneta.Descendants("route");

            foreach (XElement ruta in rutas) lblValue4.Text += ruta.Value + "\n";

            lblTitle5.Text = "Nativos";
            lblValue5.Text = datosPlaneta.ElementAt(datosPlaneta.Count() - 2).Value;

            string formatoImagen =
            File.Exists(@"planets/" + nombreElemento + ".png") ? ".png" : ".jpg";
            pictureBox.Image = Image.FromFile(@"planets/" + nombreElemento + formatoImagen);
        }
        
        void getRoutes()
        {
            pictureBox.Visible = true;
            pnlSlider.Visible = false;
            mostrarEtiquetas(false, 1, 5);
            mostrarEtiquetas(true, 1, 3);
            var datosRuta = info.Descendants("Route")
                .Where(c => c.Descendants("nameRoute")
                .SingleOrDefault().Value == nombreElemento)
                .Descendants();

            lblTitle1.Text = "Nombre";
            lblValue1.Text = datosRuta.ElementAt(1).Value;

            lblTitle2.Text = "Tipo";
            lblValue2.Text = datosRuta.ElementAt(0).Value;

            lblTitle3.Text = "Inicio";
            lblValue3.Text = datosRuta.ElementAt(2).Value;

            lblTitle4.Text = "Fin";
            lblValue4.Text = datosRuta.ElementAt(3).Value;

            string[] palabrasElemento = nombreElemento.Split(' ');
            bool imagenExiste = Directory.EnumerateFiles(@"planets/").Any(f => f.IndexOf(palabrasElemento[0], StringComparison.OrdinalIgnoreCase) > 0);

            if (imagenExiste)
            {
                string[] files = Directory.GetFiles(@"planets/", $"{palabrasElemento[0]}*.*");
                pictureBox.Image = Image.FromFile(files[0]);
            }
            else
            {
                pictureBox.Image = Image.FromFile("planets/na.jpg");
            }
        }

        void getRegions()
        {
            pictureBox.Visible = true;
            pnlSlider.Visible = false;
            mostrarEtiquetas(false, 1, 5);
            mostrarEtiquetas(true, 1, 2);
            var datosRegion = info.Descendants("Region")
                .Where(c => c.Descendants("nameRegion")
                .SingleOrDefault().Value.Replace("-", " ") == nombreElemento)
                .Descendants();

            lblTitle1.Text = "Nombre";
            lblValue1.Text = datosRegion.ElementAt(0).Value;
            lblTitle2.Text = "Descripcion";
            lblValue2.Text = datosRegion.ElementAt(1).Value;

            pictureBox.Image = Image.FromFile(@"planets/" + datosRegion.ElementAt(2).Value);
        }

      

        private void map1_Click(object sender, EventArgs e) => mapBig.Image = map1.Image;

        private void map2_Click(object sender, EventArgs e) => mapBig.Image = map2.Image;

        private void map3_Click_1(object sender, EventArgs e) => mapBig.Image = map3.Image;

        private void map4_Click_1(object sender, EventArgs e) => mapBig.Image = map4.Image;
    }
}
