
namespace WeaponsSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDetectar = new System.Windows.Forms.Button();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.beforeVideo = new System.Windows.Forms.Timer(this.components);
            this.video = new AxWMPLib.AxWindowsMediaPlayer();
            this.afterVideo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetectar
            // 
            this.btnDetectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectar.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnDetectar.Location = new System.Drawing.Point(502, 550);
            this.btnDetectar.Name = "btnDetectar";
            this.btnDetectar.Size = new System.Drawing.Size(111, 45);
            this.btnDetectar.TabIndex = 0;
            this.btnDetectar.Text = "Detectar";
            this.btnDetectar.UseVisualStyleBackColor = true;
            this.btnDetectar.Click += new System.EventHandler(this.btnDetectar_Click);
            // 
            // btnAtacar
            // 
            this.btnAtacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtacar.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnAtacar.Location = new System.Drawing.Point(502, 601);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(111, 45);
            this.btnAtacar.TabIndex = 2;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTipo.Location = new System.Drawing.Point(255, 582);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(132, 46);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Aliado";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzquierda.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnIzquierda.Location = new System.Drawing.Point(12, 582);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(57, 61);
            this.btnIzquierda.TabIndex = 4;
            this.btnIzquierda.Text = "←";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecha.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnDerecha.Location = new System.Drawing.Point(138, 582);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(57, 61);
            this.btnDerecha.TabIndex = 5;
            this.btnDerecha.Text = "→";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbajo.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnAbajo.Location = new System.Drawing.Point(75, 582);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(57, 61);
            this.btnAbajo.TabIndex = 6;
            this.btnAbajo.Text = "↓";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // btnArriba
            // 
            this.btnArriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArriba.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnArriba.Location = new System.Drawing.Point(75, 515);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(57, 61);
            this.btnArriba.TabIndex = 7;
            this.btnArriba.Text = "↑";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.Transparent;
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(250, 250);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(128, 128);
            this.image.TabIndex = 8;
            this.image.TabStop = false;
            // 
            // beforeVideo
            // 
            this.beforeVideo.Interval = 300;
            this.beforeVideo.Tick += new System.EventHandler(this.beforeVideo_Tick);
            // 
            // video
            // 
            this.video.Enabled = true;
            this.video.Location = new System.Drawing.Point(-1, 0);
            this.video.Name = "video";
            this.video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video.OcxState")));
            this.video.Size = new System.Drawing.Size(627, 667);
            this.video.TabIndex = 9;
            // 
            // afterVideo
            // 
            this.afterVideo.Interval = 1000;
            this.afterVideo.Tick += new System.EventHandler(this.afterVideo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(625, 655);
            this.Controls.Add(this.video);
            this.Controls.Add(this.image);
            this.Controls.Add(this.btnArriba);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.btnDetectar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weapons System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetectar;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Timer beforeVideo;
        private AxWMPLib.AxWindowsMediaPlayer video;
        private System.Windows.Forms.Timer afterVideo;
    }
}

