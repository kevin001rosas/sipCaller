using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sipCaller
{
    public class classReporte
    {
        public int idReporte = 0;
        public string id_categoría = "";
        public string extension = "";
        public string num_inventario = "";
        public string problema = "";
        public string fecha_repo = "";
        public string fecha_cierra = "";
        public string solución = "";
        public string calificación = "";
        public bool abierto = true; 
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
            string sql = "SELECT * FROM sipDatabase.t_reportes where idReporte=" + idReporte + ";";
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
        public void getInventarioById()
        {
            string sql = "SELECT * FROM sipDatabase.t_reportes where idReporte=" + idReporte + ";";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaUsuarios = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);


                adapter.Fill(tablaUsuarios);

                id_categoría = tablaUsuarios.Rows[0]["id_categoría"].ToString();
                extension = tablaUsuarios.Rows[0]["extension"].ToString();
                num_inventario = tablaUsuarios.Rows[0]["num_inventario"].ToString();
                problema = tablaUsuarios.Rows[0]["problema"].ToString();
                fecha_repo = tablaUsuarios.Rows[0]["fecha_repo"].ToString();
                fecha_cierra = tablaUsuarios.Rows[0]["fecha_cierra"].ToString();
                solución = tablaUsuarios.Rows[0]["solución"].ToString();
                calificación = tablaUsuarios.Rows[0]["calificación"].ToString();
                abierto = Convert.ToBoolean(tablaUsuarios.Rows[0]["abierto"].ToString());
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
            string q = "insert into sipDatabase.t_reportes "+
                "(id_categoría, "+
                "extension, "+
                "num_inventario, "+
                "problema, "+
                "fecha_repo, "+
                "fecha_cierra, "+
                "solución, "+
                "calificación, "+
                "abierto) " +
            "values('" + id_categoría +
            "','" + extension +
            "','" + num_inventario +
            "','" + problema +
            "','" + fecha_repo +
            "','" + fecha_cierra +
            "','" + solución +
            "','" + calificación +
            "'," + abierto + ");";
            Console.WriteLine(q);
            MessageBox.Show(q);
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
            string q = "update sipDatabase.t_reportes set id_categoría='" + id_categoría
                + "', extension='" + extension
                + "', num_inventario='" + num_inventario
                + "', problema='" + problema
                + "', fecha_repo='" + fecha_repo
                + "', fecha_cierra='" + fecha_cierra
                + "', solución='" + solución
                + "', calificación='" + calificación
                + "', abierto='" + abierto
                + "' WHERE idReporte=" + idReporte + ";";



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
