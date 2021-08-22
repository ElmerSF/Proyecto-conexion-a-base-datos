//UNED Programación Avanzada 830
//Estudiante Elmer Eduardo Salazar Flores

//Clase del formulario Principal a partir de aquí se levanta el interfaz de usuario con todas las opciones del menu

using Entidad_cajero_catego_prod;
using ManejoDatos;
using System;
using System.Windows.Forms;

namespace Tarea2_ElmerSalazar_304260158.Ventanas_o_Formularios
{
    public partial class Regis_Producto : Form
    {
        Manejo_de_datos form_menu = new Manejo_de_datos(); //instanciamos la clase manejo de datos
        public Regis_Producto()
        {
            InitializeComponent();
            form_menu.Llenarcombo(Comb_lista); //ejecutamos la función para llenar el Combo box para llenar cada item
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevoRegis_Click(object sender, EventArgs e)
        {
            //limpiar las cajetillas con el botón de nuevo registro
            #region Presentación y ocultamiento de las cajetillas y limpieza 
            txt_codigo.Text = "";
            txt_descripcion.Text = "";
            txt_existencia.Text = "";
            txt_precio.Text = "";
            Comb_lista.Visible = true;
            txt_codigo.Visible = true;
            txt_descripcion.Visible = true;
            txt_existencia.Visible = true;
            txt_precio.Visible = true;
            lab_Estatus.Visible = true;

            btn_guardar.Enabled = true;
            btn_nuevoRegis.Enabled = false;
            #endregion
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //rutina para ocultar nuevamente las cajetillas como al pricipio
            #region ocultamiento de las cajetillas
            btn_nuevoRegis.Enabled = true;
            btn_guardar.Enabled = false;
            Comb_lista.Visible = false;
            txt_codigo.Visible = false;
            txt_descripcion.Visible = false;
            txt_existencia.Visible = false;
            txt_precio.Visible = false;

            #endregion

            #region Guardar un Nuevo Producto

            try
            {
                Boolean confirmacion; //variable para asegurarnos la acción

                Producto nuevoProducto = new Producto(); // instanciamos la clase Producto
                Manejo_de_datos baseDatos = new Manejo_de_datos(); //instanciación de la clase Manejo de Datos que es la que le pasa los datos a la base de datos

                //Datos con los que vamos a llenar las varibales de la clase Producto
                nuevoProducto.Codigo = Convert.ToInt32(txt_codigo.Text); // el codigo lo convertimos en variable tipo int
                nuevoProducto.Descripcion = txt_descripcion.Text; // tomamos el texto de descripción
                nuevoProducto.Precio = Convert.ToDecimal(txt_precio.Text); //tomamos el texto del precio y lo convertimos en decimales
                nuevoProducto.Existencia = Convert.ToInt32(txt_existencia.Text); // tomamos la cantidad de existencias de producto y la convertimos en tipo int
                nuevoProducto.Categoría = baseDatos.Asociar_codigo((string)Comb_lista.SelectedItem); //ejecutamos la función Asociar_codigo, le pasamos como argumento la seleción del combo box


                // los datos que se llenaron en la clase Prodcuto se envían para cargarlos a la base de Datos
                confirmacion = baseDatos.NuevoProducto(nuevoProducto); //le mandamos toda la información por parámetro para que ejecute


                if (confirmacion)
                {
                    //mensaje de confirmación de proceso exitoso
                    lab_Estatus.Text = "SALIÓ TODO BIEN, GRACIAS A DIOS";



                    //Mensaje de sistema
                    string message = "Información almacenada de manera éxitosa";
                    string title = "Datos guardados";
                    MessageBox.Show(message, title);
                }
            }
            catch (Exception problema) //mensaje de error para captar los problemas
            {
                lab_Estatus.Text = "TENEMOS UN PROBLEMA Y NO SE PUDO GUARDAR";
                MessageBox.Show("Que tirada, Ha sucedido un error: " + problema.Message.ToString(), "Error");
            }

            #endregion
        }


        private void Comb_lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Regis_Producto_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //botón cerrar
        }
    }

}
