
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.Pict_planetRoute = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_orDes = new System.Windows.Forms.Label();
            this.lbl_Route = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Map_text = new System.Windows.Forms.Label();
            this.lbl_SelectedRoute_text = new System.Windows.Forms.Label();
            this.lbl_Order_Text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_planetRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1182, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lsb_routes
            // 
            this.lsb_routes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lsb_routes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsb_routes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lsb_routes.ForeColor = System.Drawing.Color.PaleGreen;
            this.lsb_routes.FormattingEnabled = true;
            this.lsb_routes.ItemHeight = 22;
            this.lsb_routes.Location = new System.Drawing.Point(3, 3);
            this.lsb_routes.Name = "lsb_routes";
            this.lsb_routes.Size = new System.Drawing.Size(277, 90);
            this.lsb_routes.TabIndex = 34;
            this.lsb_routes.SelectedIndexChanged += new System.EventHandler(this.lsb_routes_SelectedIndexChanged);
            // 
            // lbl_filiation
            // 
            this.lbl_filiation.AutoSize = true;
            this.lbl_filiation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbl_filiation.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_filiation.Location = new System.Drawing.Point(1042, 124);
            this.lbl_filiation.Name = "lbl_filiation";
            this.lbl_filiation.Size = new System.Drawing.Size(94, 22);
            this.lbl_filiation.TabIndex = 33;
            this.lbl_filiation.Text = "lbl_filiation";
            // 
            // lbl_filitationText
            // 
            this.lbl_filitationText.AutoSize = true;
            this.lbl_filitationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_filitationText.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_filitationText.Location = new System.Drawing.Point(1042, 101);
            this.lbl_filitationText.Name = "lbl_filitationText";
            this.lbl_filitationText.Size = new System.Drawing.Size(86, 26);
            this.lbl_filitationText.TabIndex = 32;
            this.lbl_filitationText.Text = "filitation";
            // 
            // lbl_longText
            // 
            this.lbl_longText.AutoSize = true;
            this.lbl_longText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_longText.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_longText.Location = new System.Drawing.Point(1042, 161);
            this.lbl_longText.Name = "lbl_longText";
            this.lbl_longText.Size = new System.Drawing.Size(100, 26);
            this.lbl_longText.TabIndex = 31;
            this.lbl_longText.Text = "longitude";
            // 
            // lbl_long
            // 
            this.lbl_long.AutoSize = true;
            this.lbl_long.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbl_long.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_long.Location = new System.Drawing.Point(1042, 183);
            this.lbl_long.Name = "lbl_long";
            this.lbl_long.Size = new System.Drawing.Size(111, 22);
            this.lbl_long.TabIndex = 30;
            this.lbl_long.Text = "lbl_longitude";
            // 
            // lbl_routesText
            // 
            this.lbl_routesText.AutoSize = true;
            this.lbl_routesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_routesText.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_routesText.Location = new System.Drawing.Point(838, 297);
            this.lbl_routesText.Name = "lbl_routesText";
            this.lbl_routesText.Size = new System.Drawing.Size(81, 26);
            this.lbl_routesText.TabIndex = 29;
            this.lbl_routesText.Text = "Routes";
            // 
            // lbl_nativesText
            // 
            this.lbl_nativesText.AutoSize = true;
            this.lbl_nativesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_nativesText.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_nativesText.Location = new System.Drawing.Point(840, 225);
            this.lbl_nativesText.Name = "lbl_nativesText";
            this.lbl_nativesText.Size = new System.Drawing.Size(81, 26);
            this.lbl_nativesText.TabIndex = 28;
            this.lbl_nativesText.Text = "natives";
            // 
            // lbl_sector
            // 
            this.lbl_sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbl_sector.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_sector.Location = new System.Drawing.Point(840, 185);
            this.lbl_sector.Name = "lbl_sector";
            this.lbl_sector.Size = new System.Drawing.Size(180, 40);
            this.lbl_sector.TabIndex = 27;
            this.lbl_sector.Text = "lbl_sector";
            // 
            // lbl_sectorText
            // 
            this.lbl_sectorText.AutoSize = true;
            this.lbl_sectorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_sectorText.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_sectorText.Location = new System.Drawing.Point(840, 162);
            this.lbl_sectorText.Name = "lbl_sectorText";
            this.lbl_sectorText.Size = new System.Drawing.Size(71, 26);
            this.lbl_sectorText.TabIndex = 26;
            this.lbl_sectorText.Text = "sector";
            // 
            // lbl_latText
            // 
            this.lbl_latText.AutoSize = true;
            this.lbl_latText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_latText.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_latText.Location = new System.Drawing.Point(1042, 232);
            this.lbl_latText.Name = "lbl_latText";
            this.lbl_latText.Size = new System.Drawing.Size(82, 26);
            this.lbl_latText.TabIndex = 25;
            this.lbl_latText.Text = "latitude";
            // 
            // lbl_lat
            // 
            this.lbl_lat.AutoSize = true;
            this.lbl_lat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbl_lat.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_lat.Location = new System.Drawing.Point(1042, 257);
            this.lbl_lat.Name = "lbl_lat";
            this.lbl_lat.Size = new System.Drawing.Size(96, 22);
            this.lbl_lat.TabIndex = 24;
            this.lbl_lat.Text = "lbl_latitude";
            // 
            // lbl_natives
            // 
            this.lbl_natives.AutoSize = true;
            this.lbl_natives.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbl_natives.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_natives.Location = new System.Drawing.Point(840, 255);
            this.lbl_natives.Name = "lbl_natives";
            this.lbl_natives.Size = new System.Drawing.Size(95, 22);
            this.lbl_natives.TabIndex = 23;
            this.lbl_natives.Text = "lbl_natives";
            // 
            // lbl_planet
            // 
            this.lbl_planet.AutoSize = true;
            this.lbl_planet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbl_planet.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_planet.Location = new System.Drawing.Point(840, 127);
            this.lbl_planet.Name = "lbl_planet";
            this.lbl_planet.Size = new System.Drawing.Size(87, 22);
            this.lbl_planet.TabIndex = 22;
            this.lbl_planet.Text = "lbl_planet";
            // 
            // lbl_planetText
            // 
            this.lbl_planetText.AutoSize = true;
            this.lbl_planetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_planetText.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_planetText.Location = new System.Drawing.Point(840, 103);
            this.lbl_planetText.Name = "lbl_planetText";
            this.lbl_planetText.Size = new System.Drawing.Size(71, 26);
            this.lbl_planetText.TabIndex = 21;
            this.lbl_planetText.Text = "planet";
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_Search.ForeColor = System.Drawing.Color.PaleGreen;
            this.btn_Search.Location = new System.Drawing.Point(1162, 43);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(89, 32);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_planet
            // 
            this.cmb_planet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.cmb_planet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_planet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.cmb_planet.ForeColor = System.Drawing.Color.PaleGreen;
            this.cmb_planet.FormattingEnabled = true;
            this.cmb_planet.Location = new System.Drawing.Point(1002, 45);
            this.cmb_planet.Name = "cmb_planet";
            this.cmb_planet.Size = new System.Drawing.Size(121, 30);
            this.cmb_planet.TabIndex = 19;
            // 
            // cmb_category
            // 
            this.cmb_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.cmb_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.cmb_category.ForeColor = System.Drawing.Color.PaleGreen;
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(719, 45);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(121, 30);
            this.cmb_category.TabIndex = 18;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // cmb_position
            // 
            this.cmb_position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.cmb_position.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.cmb_position.ForeColor = System.Drawing.Color.PaleGreen;
            this.cmb_position.FormattingEnabled = true;
            this.cmb_position.Location = new System.Drawing.Point(513, 45);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(121, 30);
            this.cmb_position.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.Pict_planetRoute);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lbl_orDes);
            this.panel2.Controls.Add(this.lsb_routes);
            this.panel2.Controls.Add(this.lbl_Route);
            this.panel2.Controls.Add(this.lbl_Image);
            this.panel2.Controls.Add(this.lbl_Map_text);
            this.panel2.Controls.Add(this.lbl_SelectedRoute_text);
            this.panel2.Controls.Add(this.lbl_Order_Text);
            this.panel2.Location = new System.Drawing.Point(843, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 335);
            this.panel2.TabIndex = 39;
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btn_save.ForeColor = System.Drawing.Color.PaleGreen;
            this.btn_save.Location = new System.Drawing.Point(87, 267);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(165, 35);
            this.btn_save.TabIndex = 41;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Pict_planetRoute
            // 
            this.Pict_planetRoute.Location = new System.Drawing.Point(339, 3);
            this.Pict_planetRoute.Name = "Pict_planetRoute";
            this.Pict_planetRoute.Size = new System.Drawing.Size(180, 152);
            this.Pict_planetRoute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pict_planetRoute.TabIndex = 40;
            this.Pict_planetRoute.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button1.ForeColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(416, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_orDes
            // 
            this.lbl_orDes.AutoSize = true;
            this.lbl_orDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbl_orDes.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_orDes.Location = new System.Drawing.Point(182, 158);
            this.lbl_orDes.Name = "lbl_orDes";
            this.lbl_orDes.Size = new System.Drawing.Size(59, 22);
            this.lbl_orDes.TabIndex = 5;
            this.lbl_orDes.Text = "Ordes";
            // 
            // lbl_Route
            // 
            this.lbl_Route.AutoSize = true;
            this.lbl_Route.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbl_Route.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_Route.Location = new System.Drawing.Point(182, 185);
            this.lbl_Route.Name = "lbl_Route";
            this.lbl_Route.Size = new System.Drawing.Size(58, 22);
            this.lbl_Route.TabIndex = 4;
            this.lbl_Route.Text = "Route";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbl_Image.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_Image.Location = new System.Drawing.Point(181, 213);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(113, 22);
            this.lbl_Image.TabIndex = 3;
            this.lbl_Image.Text = "Select Image";
            // 
            // lbl_Map_text
            // 
            this.lbl_Map_text.AutoSize = true;
            this.lbl_Map_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_Map_text.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_Map_text.Location = new System.Drawing.Point(2, 213);
            this.lbl_Map_text.Name = "lbl_Map_text";
            this.lbl_Map_text.Size = new System.Drawing.Size(54, 26);
            this.lbl_Map_text.TabIndex = 2;
            this.lbl_Map_text.Text = "Map";
            // 
            // lbl_SelectedRoute_text
            // 
            this.lbl_SelectedRoute_text.AutoSize = true;
            this.lbl_SelectedRoute_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_SelectedRoute_text.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_SelectedRoute_text.Location = new System.Drawing.Point(2, 185);
            this.lbl_SelectedRoute_text.Name = "lbl_SelectedRoute_text";
            this.lbl_SelectedRoute_text.Size = new System.Drawing.Size(161, 26);
            this.lbl_SelectedRoute_text.TabIndex = 1;
            this.lbl_SelectedRoute_text.Text = "Selected Route";
            // 
            // lbl_Order_Text
            // 
            this.lbl_Order_Text.AutoSize = true;
            this.lbl_Order_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_Order_Text.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_Order_Text.Location = new System.Drawing.Point(2, 158);
            this.lbl_Order_Text.Name = "lbl_Order_Text";
            this.lbl_Order_Text.Size = new System.Drawing.Size(67, 26);
            this.lbl_Order_Text.TabIndex = 0;
            this.lbl_Order_Text.Text = "Order";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(11, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 428);
            this.panel1.TabIndex = 38;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.comboBox1.ForeColor = System.Drawing.Color.PaleGreen;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(867, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 30);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmb_position);
            this.Controls.Add(this.pictureBox1);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

