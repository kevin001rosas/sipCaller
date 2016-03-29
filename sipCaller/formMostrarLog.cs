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
    public partial class formMostrarLog : Form
    {
        public DataTable tablaLogs = new DataTable(); 
        public formMostrarLog()
        {
            InitializeComponent();
        }

        private void formMostrarLog_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Llamada", typeof(string));
            table.Columns.Add("Fecha", typeof(string));
            table.Columns.Add("Hora", typeof(string));

            string[] lines = System.IO.File.ReadAllLines(Application.StartupPath + "\\log.txt");            
            // Display the file contents by using a foreach loop.            
            
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                string[] words = line.Split('|');
                table.Rows.Add(words[0], words[1], words[2]);                 
            }
            dataGridView1.DataSource = table;
            autosizeGrid(); 
        }

        private void autosizeGrid()
        {

            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
    }
}
