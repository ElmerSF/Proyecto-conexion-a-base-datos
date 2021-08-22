//UNED Programación Avanzada 830
//Estudiante Elmer Eduardo Salazar Flores

//Clase del formulario Producto por Categoría

using Entidad_cajero_catego_prod;
using ManejoDatos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tarea2_ElmerSalazar_304260158.Ventanas_o_Formularios
{
    public partial class Product_por_Categoria : Form
    {
        Manejo_de_datos form_menu = new Manejo_de_datos(); //instanciamos la clase manejo de datos
        public Product_por_Categoria()
        {
            InitializeComponent();
            form_menu.Llenarcombo(Comb_Categoria); //ejecutamos función para llenar el Combo box con las opciones
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //botón cerrar
        }

        private void Product_por_Categoria_Load(object sender, EventArgs e)
        {

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            try
            {

                List<Producto> Info_product = new List<Producto>(); //instanciación una nueva lista llamada Info_product del tipo Producto
                Manejo_de_datos abrir_datos = new Manejo_de_datos(); // instanciación de clase manejo de datos

                //aqui se toma la selección del item del combobox se convierte en dato string y se le envía como argumento
                //a la afunción asociar código que obtiene el código correspondiente a la categoría seleccionada
                //el codigo retornado se le envía como argumento a la función TablaProductXCategoría que hace una lista con las coincidencias
                //lo que retorne se le asigna a la varible Info_product
                Info_product = abrir_datos.TablaProductXCatego(abrir_datos.Asociar_codigo((string)Comb_Categoria.SelectedItem)); 
                Area_datos_products.DataSource = Info_product; //se pinta la información en el area de la interfaz


            }

            catch (Exception Errorcillo) //mensaje de error para atrapar las excepciones
            {
                MessageBox.Show("SE CALLO Ha sucedido un error: " + Errorcillo.Message.ToString(), "Error");
            }
        }
    }
}
