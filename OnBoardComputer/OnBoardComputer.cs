using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public OnBoardComputer()
        {
            InitializeComponent();
        }

        private void OnBoardComputer_Load(object sender, EventArgs e)
        {
            info = XDocument.Load(@"DataBank.xml");

            cmbCategoria.Items.Add("");
            cmbCategoria.Items.Add("Planetas");
            cmbCategoria.Items.Add("Rutas");
            cmbCategoria.Items.Add("Regiones");
            cmbCategoria.Items.Add("Mapas");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            if (cmbCategoria.SelectedItem != null)
            {
                arbol.Nodes.Clear();
                TreeNode raiz = new TreeNode();
                raiz.Text = cmbCategoria.SelectedItem.ToString();
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
                else if (index == 3 || index == 4)
                {
                    nombreCampo = "nameRegion";
                }

                raiz = agregarNodosARaiz(raiz, nombreCampo);
                arbol.Nodes.Add(raiz);
            }
        }

        TreeNode agregarNodosARaiz(TreeNode raiz, string nombre)
        {
            var conjunto = info.Descendants(nombre);
            foreach (XElement elemento in conjunto)
            {
                if (!raiz.Nodes.ContainsKey(elemento.Value))
                {
                    raiz.Nodes.Add(elementoANodo(elemento));
                }
            }
            return raiz;
        }

        TreeNode elementoANodo(XElement elemento)
        {
            TreeNode nodo = new TreeNode();
            nodo.Text = elemento.Value.Replace("-", " ");
            nodo.Name = elemento.Value.Replace("-", " ");
            return nodo;
        }

        private void arbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (arbol.SelectedNode.Text != null)
            {
                MessageBox.Show(arbol.SelectedNode.Text);
                //XElement selectedSpaceship = info.Descendants("InfoDetail")
                //.Where(x => x.Element("idInfoDetail").Value == tree.SelectedNode.Tag.ToString())
                //.SingleOrDefault();

                //panel.BackColor = Color.FromArgb(255, 50, 60, 70);

                //lblManufacturerTitle.Text = "Manufacturer";
                //lblLengthTitle.Text = "Length";
                //lblHyperDriveTitle.Text = "HyperDrive";
                //lblArmamentTitle.Text = "Armament";
                //lblSpeedTitle.Text = "Speed";
                //lblShieldTitle.Text = "Shielding";

                //lblTitle.Text = selectedSpaceship.Element("title").Value;
                //lblTextInfoDetail.Text = selectedSpaceship.Element("textInfoDetail").Value;
                //lblManufacturer.Text = selectedSpaceship.Element("Data").Element("Manufacturer").Value;
                //lblLength.Text = selectedSpaceship.Element("Data").Element("Length").Value;
                //lblHyperDrive.Text = selectedSpaceship.Element("Data").Element("Hyperdrive").Value;
                //lblArmament.Text = selectedSpaceship.Element("Data").Element("Armament").Value;
                //lblSpeed.Text = selectedSpaceship.Element("Data").Element("Speed").Value;
                //lblShield.Text = selectedSpaceship.Element("Data").Element("Shielding").Value;

                //string imagePath = selectedSpaceship.Element("Blueprint").Value;
                //pictureBox.Image = Image.FromFile(@"Ships/" + imagePath);
            }
        }
    }
}
