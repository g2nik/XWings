
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
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.imagenNave = new System.Windows.Forms.PictureBox();
            this.beforeVideoTimer = new System.Windows.Forms.Timer(this.components);
            this.videoDestruccion = new AxWMPLib.AxWindowsMediaPlayer();
            this.afterVideoTimer = new System.Windows.Forms.Timer(this.components);
            this.imagenPlanos = new System.Windows.Forms.PictureBox();
            this.lblPlanos = new System.Windows.Forms.Label();
            this.videoModelo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.imagenNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoDestruccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPlanos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetectar
            // 
            this.btnDetectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectar.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnDetectar.Location = new System.Drawing.Point(224, 582);
            this.btnDetectar.Name = "btnDetectar";
            this.btnDetectar.Size = new System.Drawing.Size(177, 64);
            this.btnDetectar.TabIndex = 0;
            this.btnDetectar.Text = "Detectar";
            this.btnDetectar.UseVisualStyleBackColor = true;
            this.btnDetectar.Click += new System.EventHandler(this.btnDetectar_Click);
            // 
            // btnAtacar
            // 
            this.btnAtacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnAtacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtacar.ForeColor = System.Drawing.Color.Red;
            this.btnAtacar.Location = new System.Drawing.Point(425, 582);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(201, 64);
            this.btnAtacar.TabIndex = 2;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = false;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
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
            // imagenNave
            // 
            this.imagenNave.BackColor = System.Drawing.Color.Transparent;
            this.imagenNave.Image = ((System.Drawing.Image)(resources.GetObject("imagenNave.Image")));
            this.imagenNave.Location = new System.Drawing.Point(250, 250);
            this.imagenNave.Name = "imagenNave";
            this.imagenNave.Size = new System.Drawing.Size(128, 128);
            this.imagenNave.TabIndex = 8;
            this.imagenNave.TabStop = false;
            // 
            // beforeVideoTimer
            // 
            this.beforeVideoTimer.Interval = 300;
            this.beforeVideoTimer.Tick += new System.EventHandler(this.beforeVideo_Tick);
            // 
            // videoDestruccion
            // 
            this.videoDestruccion.Enabled = true;
            this.videoDestruccion.Location = new System.Drawing.Point(-1, -6);
            this.videoDestruccion.Name = "videoDestruccion";
            this.videoDestruccion.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoDestruccion.OcxState")));
            this.videoDestruccion.Size = new System.Drawing.Size(1193, 682);
            this.videoDestruccion.TabIndex = 9;
            // 
            // afterVideoTimer
            // 
            this.afterVideoTimer.Interval = 1000;
            this.afterVideoTimer.Tick += new System.EventHandler(this.afterVideo_Tick);
            // 
            // imagenPlanos
            // 
            this.imagenPlanos.Location = new System.Drawing.Point(638, 321);
            this.imagenPlanos.Name = "imagenPlanos";
            this.imagenPlanos.Size = new System.Drawing.Size(496, 322);
            this.imagenPlanos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPlanos.TabIndex = 10;
            this.imagenPlanos.TabStop = false;
            // 
            // lblPlanos
            // 
            this.lblPlanos.AutoSize = true;
            this.lblPlanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanos.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblPlanos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlanos.Location = new System.Drawing.Point(632, 9);
            this.lblPlanos.Name = "lblPlanos";
            this.lblPlanos.Size = new System.Drawing.Size(97, 31);
            this.lblPlanos.TabIndex = 12;
            this.lblPlanos.Text = "Planos";
            this.lblPlanos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // videoModelo
            // 
            this.videoModelo.Enabled = true;
            this.videoModelo.Location = new System.Drawing.Point(638, 43);
            this.videoModelo.Name = "videoModelo";
            this.videoModelo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoModelo.OcxState")));
            this.videoModelo.Size = new System.Drawing.Size(496, 272);
            this.videoModelo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1148, 655);
            this.Controls.Add(this.videoDestruccion);
            this.Controls.Add(this.lblPlanos);
            this.Controls.Add(this.imagenPlanos);
            this.Controls.Add(this.imagenNave);
            this.Controls.Add(this.btnArriba);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.btnDetectar);
            this.Controls.Add(this.videoModelo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weapons System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.imagenNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoDestruccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPlanos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetectar;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.PictureBox imagenNave;
        private System.Windows.Forms.Timer beforeVideoTimer;
        private AxWMPLib.AxWindowsMediaPlayer videoDestruccion;
        private System.Windows.Forms.Timer afterVideoTimer;
        private System.Windows.Forms.PictureBox imagenPlanos;
        private System.Windows.Forms.Label lblPlanos;
        private AxWMPLib.AxWindowsMediaPlayer videoModelo;
    }
}

