
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Armament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.PaleGreen;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Motor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.PaleGreen;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Generador ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.PaleGreen;
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reflector";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.PaleGreen;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sensor";
            // 
            // pgb_armament
            // 
            this.pgb_armament.Location = new System.Drawing.Point(87, 23);
            this.pgb_armament.Maximum = 60;
            this.pgb_armament.Name = "pgb_armament";
            this.pgb_armament.Size = new System.Drawing.Size(432, 23);
            this.pgb_armament.TabIndex = 5;
            // 
            // pgb_sensor
            // 
            this.pgb_sensor.Location = new System.Drawing.Point(87, 139);
            this.pgb_sensor.Maximum = 60;
            this.pgb_sensor.Name = "pgb_sensor";
            this.pgb_sensor.Size = new System.Drawing.Size(432, 23);
            this.pgb_sensor.TabIndex = 6;
            // 
            // pgb_motor
            // 
            this.pgb_motor.Location = new System.Drawing.Point(87, 52);
            this.pgb_motor.Maximum = 60;
            this.pgb_motor.Name = "pgb_motor";
            this.pgb_motor.Size = new System.Drawing.Size(432, 23);
            this.pgb_motor.TabIndex = 7;
            // 
            // pgb_generador
            // 
            this.pgb_generador.Location = new System.Drawing.Point(87, 81);
            this.pgb_generador.Maximum = 60;
            this.pgb_generador.Name = "pgb_generador";
            this.pgb_generador.Size = new System.Drawing.Size(432, 23);
            this.pgb_generador.TabIndex = 8;
            // 
            // pgb_refector
            // 
            this.pgb_refector.Location = new System.Drawing.Point(87, 110);
            this.pgb_refector.Maximum = 60;
            this.pgb_refector.Name = "pgb_refector";
            this.pgb_refector.Size = new System.Drawing.Size(432, 23);
            this.pgb_refector.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(12, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(507, 72);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(530, 301);
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
    }
}

