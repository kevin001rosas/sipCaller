﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sipCaller
{
    public class classInventario
    {
        public int idInventario = 0;
        public string equipo = "";
        public string fechaCompra = "";
        public string factura = "";
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
            string sql = "SELECT * FROM sipDatabase.t_inventarios where idInventario=" + idInventario + ";";
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
            string sql = "SELECT * FROM sipDatabase.t_inventarios where idInventario=" + idInventario + ";";
            mcd = new MySqlCommand(sql, mcon);
            DataTable tablaUsuarios = new DataTable();
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                openCon();

                adapter = new MySqlDataAdapter(mcd);


                adapter.Fill(tablaUsuarios);

                equipo = tablaUsuarios.Rows[0]["equipo"].ToString();
                fechaCompra = tablaUsuarios.Rows[0]["fechaCompra"].ToString();
                factura = tablaUsuarios.Rows[0]["factura"].ToString();
                
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
            string q = "insert into sipDatabase.t_inventarios (equipo, fechaCompra, factura) " +
            "values('" + equipo+ "','" + fechaCompra+ "','" + factura+ "');";

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
            string q = "update sipDatabase.t_inventarios set equipo='" + equipo
                + "', fechaCompra='" + fechaCompra
                + "', factura='" + factura
                + "' WHERE idInventario=" + idInventario + ";";

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
