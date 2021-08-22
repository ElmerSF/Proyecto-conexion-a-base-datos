//UNED Programación Avanzada 830
//Estudiante Elmer Eduardo Salazar Flores

//Clase del formulario Mostrar todos los productos

using Entidad_cajero_catego_prod;
using ManejoDatos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tarea2_ElmerSalazar_304260158.Ventanas_o_Formularios
{
    public partial class Mostrar_todos_Productos : Form
    {
        public Mostrar_todos_Productos()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //botón de cerrar la ventana
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            try
            {

                List<Producto> Info_product = new List<Producto>(); //instanciación de la lista Producto
                Manejo_de_datos abrir_datos = new Manejo_de_datos(); // instanciación de clase manejo de datos


                Info_product = abrir_datos.TablaProduct(); //se llama al proceso TablaProducto y se almacena en variable Info_prodcut 
                Area_de_datos.DataSource = Info_product; //se pinta la información en el area de la interfaz


            }

            catch (Exception Errorcillo) //mensaje de error para atrapar los errores
            {
                MessageBox.Show("SE CALLO Ha sucedido un error: " + Errorcillo.Message.ToString(), "Error");
            }
        }

        private void Mostrar_todos_Productos_Load(object sender, EventArgs e)
        {

        }
    }
}
