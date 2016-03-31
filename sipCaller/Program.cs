using System;
using System.Windows.Forms;

namespace sipCaller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            //Application.Run(new FormCallAssistant());

            
            classUsuario usuario = new classUsuario();
            usuario.extension = "extension";
            usuario.getUserByExtension(); 

            usuario.area = "area";
            usuario.correo = "correo";
            usuario.extension = "extension";
            //usuario.insert(); 


            
            classInventario inventario = new classInventario();
            inventario.
            inventario.getInventarioById(); 
            inventario.equipo = "Equipo";
            inventario.fechaCompra = "Fecha";
            inventario.factura = "factura";
            //inventario.insert(); 

            classReporte reporte = new classReporte();
            reporte.id_categoría = "categoria";
            reporte.extension = "extension"; 
            reporte.num_inventario = "Numero"; 
            reporte.problema = "problema";
            reporte.fecha_repo = "fechaRepo"; 
            reporte.fecha_cierra = "fechaCierre"; 
            reporte.solución = "solucion"; 
            reporte.calificación = "calificacion";
            reporte.abierto = true;
            reporte.insert(); 

            classCategoria categoría = new classCategoria();
            categoría.descripcion = "descripcion";
            categoría.insert(); 
                                                                                                                            

            
        }
    }
}
