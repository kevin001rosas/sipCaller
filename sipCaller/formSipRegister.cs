using Ozeki.VoIP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sipCaller
{
    public partial class formSipRegister : Form
    {
        string usuario = "";
        string contraseña = ""; 
        string servidor = ""; 
        string puerto = ""; 
        public formSipRegister()
        {
            InitializeComponent();           

        }

        private void formSipRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void botonConectar_Click(object sender, EventArgs e)
        {
            this.usuario = textBoxUsuario.Text;
            this.contraseña = textBoxContraseña.Text;
            this.servidor = textBoxServidor.Text;
            try
            {
                int entero = Convert.ToInt32(textBoxPuerto.Text);
                this.puerto = textBoxPuerto.Text; 
            }
            catch 
            {
                MessageBox.Show("Por favor introduce un puerto válido");
                return; 
            }
            this.Hide(); 
        }

        public void getRegisterData(string [] data)
        {
            data[0] = textBoxUsuario.Text;
            data[1] = textBoxContraseña.Text;
            data[2] = textBoxServidor.Text;
            data[3] = textBoxPuerto.Text;
        }

       
    }
}
