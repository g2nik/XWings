
namespace HyperSpaceSystem
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lsb_routes = new System.Windows.Forms.ListBox();
            this.lbl_filiation = new System.Windows.Forms.Label();
            this.lbl_filitationText = new System.Windows.Forms.Label();
            this.lbl_longText = new System.Windows.Forms.Label();
            this.lbl_long = new System.Windows.Forms.Label();
            this.lbl_routesText = new System.Windows.Forms.Label();
            this.lbl_nativesText = new System.Windows.Forms.Label();
            this.lbl_sector = new System.Windows.Forms.Label();
            this.lbl_sectorText = new System.Windows.Forms.Label();
            this.lbl_latText = new System.Windows.Forms.Label();
            this.lbl_lat = new System.Windows.Forms.Label();
            this.lbl_natives = new System.Windows.Forms.Label();
            this.lbl_planet = new System.Windows.Forms.Label();
            this.lbl_planetText = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_planet = new System.Windows.Forms.ComboBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Map_text = new System.Windows.Forms.Label();
            this.lbl_SelectedRoute_text = new System.Windows.Forms.Label();
            this.lbl_Order_Text = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Route = new System.Windows.Forms.Label();
            this.lbl_orDes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Pict_planetRoute = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_planetRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1057, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lsb_routes
            // 
            this.lsb_routes.FormattingEnabled = true;
            this.lsb_routes.Location = new System.Drawing.Point(843, 301);
            this.lsb_routes.Name = "lsb_routes";
            this.lsb_routes.Size = new System.Drawing.Size(180, 82);
            this.lsb_routes.TabIndex = 34;
            this.lsb_routes.SelectedIndexChanged += new System.EventHandler(this.lsb_routes_SelectedIndexChanged);
            // 
            // lbl_filiation
            // 
            this.lbl_filiation.AutoSize = true;
            this.lbl_filiation.Location = new System.Drawing.Point(982, 120);
            this.lbl_filiation.Name = "lbl_filiation";
            this.lbl_filiation.Size = new System.Drawing.Size(55, 13);
            this.lbl_filiation.TabIndex = 33;
            this.lbl_filiation.Text = "lbl_filiation";
            // 
            // lbl_filitationText
            // 
            this.lbl_filitationText.AutoSize = true;
            this.lbl_filitationText.Location = new System.Drawing.Point(982, 100);
            this.lbl_filitationText.Name = "lbl_filitationText";
            this.lbl_filitationText.Size = new System.Drawing.Size(42, 13);
            this.lbl_filitationText.TabIndex = 32;
            this.lbl_filitationText.Text = "filitation";
            // 
            // lbl_longText
            // 
            this.lbl_longText.AutoSize = true;
            this.lbl_longText.Location = new System.Drawing.Point(982, 150);
            this.lbl_longText.Name = "lbl_longText";
            this.lbl_longText.Size = new System.Drawing.Size(50, 13);
            this.lbl_longText.TabIndex = 31;
            this.lbl_longText.Text = "longitude";
            // 
            // lbl_long
            // 
            this.lbl_long.AutoSize = true;
            this.lbl_long.Location = new System.Drawing.Point(982, 170);
            this.lbl_long.Name = "lbl_long";
            this.lbl_long.Size = new System.Drawing.Size(66, 13);
            this.lbl_long.TabIndex = 30;
            this.lbl_long.Text = "lbl_longitude";
            // 
            // lbl_routesText
            // 
            this.lbl_routesText.AutoSize = true;
            this.lbl_routesText.Location = new System.Drawing.Point(840, 275);
            this.lbl_routesText.Name = "lbl_routesText";
            this.lbl_routesText.Size = new System.Drawing.Size(41, 13);
            this.lbl_routesText.TabIndex = 29;
            this.lbl_routesText.Text = "Routes";
            // 
            // lbl_nativesText
            // 
            this.lbl_nativesText.AutoSize = true;
            this.lbl_nativesText.Location = new System.Drawing.Point(840, 200);
            this.lbl_nativesText.Name = "lbl_nativesText";
            this.lbl_nativesText.Size = new System.Drawing.Size(41, 13);
            this.lbl_nativesText.TabIndex = 28;
            this.lbl_nativesText.Text = "natives";
            // 
            // lbl_sector
            // 
            this.lbl_sector.AutoSize = true;
            this.lbl_sector.Location = new System.Drawing.Point(840, 170);
            this.lbl_sector.Name = "lbl_sector";
            this.lbl_sector.Size = new System.Drawing.Size(52, 13);
            this.lbl_sector.TabIndex = 27;
            this.lbl_sector.Text = "lbl_sector";
            // 
            // lbl_sectorText
            // 
            this.lbl_sectorText.AutoSize = true;
            this.lbl_sectorText.Location = new System.Drawing.Point(840, 150);
            this.lbl_sectorText.Name = "lbl_sectorText";
            this.lbl_sectorText.Size = new System.Drawing.Size(36, 13);
            this.lbl_sectorText.TabIndex = 26;
            this.lbl_sectorText.Text = "sector";
            // 
            // lbl_latText
            // 
            this.lbl_latText.AutoSize = true;
            this.lbl_latText.Location = new System.Drawing.Point(982, 200);
            this.lbl_latText.Name = "lbl_latText";
            this.lbl_latText.Size = new System.Drawing.Size(41, 13);
            this.lbl_latText.TabIndex = 25;
            this.lbl_latText.Text = "latitude";
            // 
            // lbl_lat
            // 
            this.lbl_lat.AutoSize = true;
            this.lbl_lat.Location = new System.Drawing.Point(982, 220);
            this.lbl_lat.Name = "lbl_lat";
            this.lbl_lat.Size = new System.Drawing.Size(57, 13);
            this.lbl_lat.TabIndex = 24;
            this.lbl_lat.Text = "lbl_latitude";
            // 
            // lbl_natives
            // 
            this.lbl_natives.AutoSize = true;
            this.lbl_natives.Location = new System.Drawing.Point(840, 220);
            this.lbl_natives.Name = "lbl_natives";
            this.lbl_natives.Size = new System.Drawing.Size(57, 13);
            this.lbl_natives.TabIndex = 23;
            this.lbl_natives.Text = "lbl_natives";
            // 
            // lbl_planet
            // 
            this.lbl_planet.AutoSize = true;
            this.lbl_planet.Location = new System.Drawing.Point(840, 120);
            this.lbl_planet.Name = "lbl_planet";
            this.lbl_planet.Size = new System.Drawing.Size(52, 13);
            this.lbl_planet.TabIndex = 22;
            this.lbl_planet.Text = "lbl_planet";
            // 
            // lbl_planetText
            // 
            this.lbl_planetText.AutoSize = true;
            this.lbl_planetText.Location = new System.Drawing.Point(840, 100);
            this.lbl_planetText.Name = "lbl_planetText";
            this.lbl_planetText.Size = new System.Drawing.Size(36, 13);
            this.lbl_planetText.TabIndex = 21;
            this.lbl_planetText.Text = "planet";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(1162, 43);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_planet
            // 
            this.cmb_planet.FormattingEnabled = true;
            this.cmb_planet.Location = new System.Drawing.Point(1002, 45);
            this.cmb_planet.Name = "cmb_planet";
            this.cmb_planet.Size = new System.Drawing.Size(121, 21);
            this.cmb_planet.TabIndex = 19;
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(843, 45);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(121, 21);
            this.cmb_category.TabIndex = 18;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // cmb_position
            // 
            this.cmb_position.FormattingEnabled = true;
            this.cmb_position.Location = new System.Drawing.Point(514, 53);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(121, 21);
            this.cmb_position.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(19, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 428);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.Pict_planetRoute);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lbl_orDes);
            this.panel2.Controls.Add(this.lbl_Route);
            this.panel2.Controls.Add(this.lbl_Image);
            this.panel2.Controls.Add(this.lbl_Map_text);
            this.panel2.Controls.Add(this.lbl_SelectedRoute_text);
            this.panel2.Controls.Add(this.lbl_Order_Text);
            this.panel2.Location = new System.Drawing.Point(843, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 301);
            this.panel2.TabIndex = 39;
            // 
            // lbl_Map_text
            // 
            this.lbl_Map_text.AutoSize = true;
            this.lbl_Map_text.Location = new System.Drawing.Point(21, 184);
            this.lbl_Map_text.Name = "lbl_Map_text";
            this.lbl_Map_text.Size = new System.Drawing.Size(28, 13);
            this.lbl_Map_text.TabIndex = 2;
            this.lbl_Map_text.Text = "Map";
            // 
            // lbl_SelectedRoute_text
            // 
            this.lbl_SelectedRoute_text.AutoSize = true;
            this.lbl_SelectedRoute_text.Location = new System.Drawing.Point(21, 156);
            this.lbl_SelectedRoute_text.Name = "lbl_SelectedRoute_text";
            this.lbl_SelectedRoute_text.Size = new System.Drawing.Size(81, 13);
            this.lbl_SelectedRoute_text.TabIndex = 1;
            this.lbl_SelectedRoute_text.Text = "Selected Route";
            // 
            // lbl_Order_Text
            // 
            this.lbl_Order_Text.AutoSize = true;
            this.lbl_Order_Text.Location = new System.Drawing.Point(21, 129);
            this.lbl_Order_Text.Name = "lbl_Order_Text";
            this.lbl_Order_Text.Size = new System.Drawing.Size(33, 13);
            this.lbl_Order_Text.TabIndex = 0;
            this.lbl_Order_Text.Text = "Order";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Location = new System.Drawing.Point(141, 184);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(69, 13);
            this.lbl_Image.TabIndex = 3;
            this.lbl_Image.Text = "Select Image";
            // 
            // lbl_Route
            // 
            this.lbl_Route.AutoSize = true;
            this.lbl_Route.Location = new System.Drawing.Point(141, 156);
            this.lbl_Route.Name = "lbl_Route";
            this.lbl_Route.Size = new System.Drawing.Size(36, 13);
            this.lbl_Route.TabIndex = 4;
            this.lbl_Route.Text = "Route";
            // 
            // lbl_orDes
            // 
            this.lbl_orDes.AutoSize = true;
            this.lbl_orDes.Location = new System.Drawing.Point(141, 129);
            this.lbl_orDes.Name = "lbl_orDes";
            this.lbl_orDes.Size = new System.Drawing.Size(35, 13);
            this.lbl_orDes.TabIndex = 5;
            this.lbl_orDes.Text = "Ordes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pict_planetRoute
            // 
            this.Pict_planetRoute.Location = new System.Drawing.Point(229, 17);
            this.Pict_planetRoute.Name = "Pict_planetRoute";
            this.Pict_planetRoute.Size = new System.Drawing.Size(162, 113);
            this.Pict_planetRoute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pict_planetRoute.TabIndex = 40;
            this.Pict_planetRoute.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(106, 238);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(165, 23);
            this.btn_save.TabIndex = 41;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1686, 821);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmb_position);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lsb_routes);
            this.Controls.Add(this.lbl_filiation);
            this.Controls.Add(this.lbl_filitationText);
            this.Controls.Add(this.lbl_longText);
            this.Controls.Add(this.lbl_long);
            this.Controls.Add(this.lbl_routesText);
            this.Controls.Add(this.lbl_nativesText);
            this.Controls.Add(this.lbl_sector);
            this.Controls.Add(this.lbl_sectorText);
            this.Controls.Add(this.lbl_latText);
            this.Controls.Add(this.lbl_lat);
            this.Controls.Add(this.lbl_natives);
            this.Controls.Add(this.lbl_planet);
            this.Controls.Add(this.lbl_planetText);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cmb_planet);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_planetRoute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lsb_routes;
        private System.Windows.Forms.Label lbl_filiation;
        private System.Windows.Forms.Label lbl_filitationText;
        private System.Windows.Forms.Label lbl_longText;
        private System.Windows.Forms.Label lbl_long;
        private System.Windows.Forms.Label lbl_routesText;
        private System.Windows.Forms.Label lbl_nativesText;
        private System.Windows.Forms.Label lbl_sector;
        private System.Windows.Forms.Label lbl_sectorText;
        private System.Windows.Forms.Label lbl_latText;
        private System.Windows.Forms.Label lbl_lat;
        private System.Windows.Forms.Label lbl_natives;
        private System.Windows.Forms.Label lbl_planet;
        private System.Windows.Forms.Label lbl_planetText;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_planet;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.ComboBox cmb_position;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Map_text;
        private System.Windows.Forms.Label lbl_SelectedRoute_text;
        private System.Windows.Forms.Label lbl_Order_Text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_orDes;
        private System.Windows.Forms.Label lbl_Route;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.PictureBox Pict_planetRoute;
        private System.Windows.Forms.Button btn_save;
    }
}

