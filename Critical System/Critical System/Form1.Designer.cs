
namespace Critical_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pgb_armament = new System.Windows.Forms.ProgressBar();
            this.pgb_sensor = new System.Windows.Forms.ProgressBar();
            this.pgb_motor = new System.Windows.Forms.ProgressBar();
            this.pgb_generador = new System.Windows.Forms.ProgressBar();
            this.pgb_refector = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_download = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Armament";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.PaleGreen;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Motor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.PaleGreen;
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Generador ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.PaleGreen;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reflector";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.PaleGreen;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sensor";
            // 
            // pgb_armament
            // 
            this.pgb_armament.Location = new System.Drawing.Point(130, 27);
            this.pgb_armament.Maximum = 60;
            this.pgb_armament.Name = "pgb_armament";
            this.pgb_armament.Size = new System.Drawing.Size(432, 23);
            this.pgb_armament.TabIndex = 5;
            // 
            // pgb_sensor
            // 
            this.pgb_sensor.Location = new System.Drawing.Point(130, 143);
            this.pgb_sensor.Maximum = 60;
            this.pgb_sensor.Name = "pgb_sensor";
            this.pgb_sensor.Size = new System.Drawing.Size(432, 23);
            this.pgb_sensor.TabIndex = 6;
            // 
            // pgb_motor
            // 
            this.pgb_motor.Location = new System.Drawing.Point(130, 56);
            this.pgb_motor.Maximum = 60;
            this.pgb_motor.Name = "pgb_motor";
            this.pgb_motor.Size = new System.Drawing.Size(432, 23);
            this.pgb_motor.TabIndex = 7;
            // 
            // pgb_generador
            // 
            this.pgb_generador.Location = new System.Drawing.Point(130, 85);
            this.pgb_generador.Maximum = 60;
            this.pgb_generador.Name = "pgb_generador";
            this.pgb_generador.Size = new System.Drawing.Size(432, 23);
            this.pgb_generador.TabIndex = 8;
            // 
            // pgb_refector
            // 
            this.pgb_refector.Location = new System.Drawing.Point(130, 114);
            this.pgb_refector.Maximum = 60;
            this.pgb_refector.Name = "pgb_refector";
            this.pgb_refector.Size = new System.Drawing.Size(432, 23);
            this.pgb_refector.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(12, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(507, 72);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_download
            // 
            this.lbl_download.AutoSize = true;
            this.lbl_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_download.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_download.Location = new System.Drawing.Point(126, 175);
            this.lbl_download.Name = "lbl_download";
            this.lbl_download.Size = new System.Drawing.Size(60, 24);
            this.lbl_download.TabIndex = 11;
            this.lbl_download.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(667, 301);
            this.Controls.Add(this.lbl_download);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pgb_refector);
            this.Controls.Add(this.pgb_generador);
            this.Controls.Add(this.pgb_motor);
            this.Controls.Add(this.pgb_sensor);
            this.Controls.Add(this.pgb_armament);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pgb_armament;
        private System.Windows.Forms.ProgressBar pgb_sensor;
        private System.Windows.Forms.ProgressBar pgb_motor;
        private System.Windows.Forms.ProgressBar pgb_generador;
        private System.Windows.Forms.ProgressBar pgb_refector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_download;
    }
}

