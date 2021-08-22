//UNED Programación Avanzada 830
//Estudiante Elmer Eduardo Salazar Flores

//Clase del formulario Mostra Categorías de Producto

using Entidad_cajero_catego_prod;
using ManejoDatos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tarea2_ElmerSalazar_304260158.Ventanas_o_Formularios
{
    public partial class Mostrar_Categorias : Form
    {
        public Mostrar_Categorias()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //botón de cerrar el formulario
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            try
            {

                List<Categoria> Info_categoria = new List<Categoria>(); //instanciación de la clase categoría
                Manejo_de_datos abrir_datos = new Manejo_de_datos(); // instanciación de clase manejo de datos


                Info_categoria = abrir_datos.TablaCategorias(); //se llama al proceso TablaCategoría y se almacena en variable Info_categoría  
                Area_de_Datos.DataSource = Info_categoria; //se pinta la información en el area de la interfaz


            }

            catch (Exception Errorcillo) //Mensaje de error para atrapar los errores
            {
                MessageBox.Show("SE CALLO Ha sucedido un error: " + Errorcillo.Message.ToString(), "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Mostrar_Categorias_Load(object sender, EventArgs e)
        {

        }
    }
}
