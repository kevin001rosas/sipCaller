namespace sipCaller
{
    partial class formSipRegister
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
            this.botonConectar = new System.Windows.Forms.Button();
            this.textBoxPuerto = new System.Windows.Forms.TextBox();
            this.textBoxServidor = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonConectar
            // 
            this.botonConectar.Location = new System.Drawing.Point(83, 110);
            this.botonConectar.Name = "botonConectar";
            this.botonConectar.Size = new System.Drawing.Size(158, 23);
            this.botonConectar.TabIndex = 0;
            this.botonConectar.Text = "Guardar Configuración";
            this.botonConectar.UseVisualStyleBackColor = true;
            this.botonConectar.Click += new System.EventHandler(this.botonConectar_Click);
            // 
            // textBoxPuerto
            // 
            this.textBoxPuerto.Location = new System.Drawing.Point(83, 84);
            this.textBoxPuerto.Name = "textBoxPuerto";
            this.textBoxPuerto.Size = new System.Drawing.Size(158, 20);
            this.textBoxPuerto.TabIndex = 1;
            this.textBoxPuerto.Text = "5061";
            // 
            // textBoxServidor
            // 
            this.textBoxServidor.Location = new System.Drawing.Point(83, 58);
            this.textBoxServidor.Name = "textBoxServidor";
            this.textBoxServidor.Size = new System.Drawing.Size(158, 20);
            this.textBoxServidor.TabIndex = 2;
            this.textBoxServidor.Text = "192.168.1.74";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(83, 32);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(158, 20);
            this.textBoxContraseña.TabIndex = 3;
            this.textBoxContraseña.Text = "1504";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(83, 6);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(158, 20);
            this.textBoxUsuario.TabIndex = 4;
            this.textBoxUsuario.Text = "1504";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Puerto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Servidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Extensión";
            // 
            // formSipRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 147);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxServidor);
            this.Controls.Add(this.textBoxPuerto);
            this.Controls.Add(this.botonConectar);
            this.Name = "formSipRegister";
            this.Text = "formSipRegister";
            this.Load += new System.EventHandler(this.formSipRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonConectar;
        private System.Windows.Forms.TextBox textBoxPuerto;
        private System.Windows.Forms.TextBox textBoxServidor;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}