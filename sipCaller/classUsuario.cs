using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sipCaller
{
    public class classUsuario
    {
        public int idUsuario = 0;
        public string area = "";
        public string correo = "";
        public string extension = ""; 	
        public MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public MySqlCommand mcd;
        public MySqlDataAdapter adapter;

        public void openCon()
        {
            if (mcon.State == ConnectionState.Closed)
            {
                mcon.Open();
            }
        }

        public void closeCon()
        {
            if (mcon.State == ConnectionState.Open)
            {
                mcon.Close();
            }
        }
        public bool existe()
        {
            string sql = "SELECT * FROM sipDatabase.t_usuarios where extension=" + extension + ";"; 
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaProductos = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();
                adapter = new MySqlDataAdapter(mcd);
                adapter.Fill(tablaProductos);
                closeCon();
                if (tablaProductos.Rows.Count > 0)
                    return true;
                else
                    return false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                closeCon();
                return false;
            }
        }
        public void getUserByExtension()
        {
            string sql = "SELECT * FROM sipDatabase.t_usuarios where extension=" + extension + ";";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaUsuarios = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);


                adapter.Fill(tablaUsuarios);
                idUsuario = Convert.ToInt32(tablaUsuarios.Rows[0]["idUsuario"].ToString());
                area = tablaUsuarios.Rows[0]["area"].ToString();
                correo = tablaUsuarios.Rows[0]["correo"].ToString();
                extension = tablaUsuarios.Rows[0]["extension"].ToString();
                closeCon();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                closeCon();
            }


        }

        public void insert()
        {
            string q = "insert into sipDatabase.t_usuarios (area, correo, extension) " +
            "values('" + area + "','" + correo + "','" + extension + "');"; 

            Console.WriteLine(q);
            //MessageBox.Show(q);
            try
            {
                openCon();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Query Executed");
                }
                else
                {
                    //MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }
        }

        public void update()
        {
            string q = "update sipDatabase.t_usuarios set area='" + area                 
                + "', correo='" + correo                  
                + "' WHERE extension='" + extension + "';";

            //MessageBox.Show(q);
            try
            {
                openCon();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Query Executed");
                }
                else
                {
                    //MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }
        }        
    }
}
