//UNED Programación Avanzada 830
//Estudiante Elmer Eduardo Salazar Flores

//Clase del formulario Registra Categoría de Producto

using Entidad_cajero_catego_prod;
using ManejoDatos;
using System;
using System.Windows.Forms;

namespace Tarea2_ElmerSalazar_304260158.Ventanas_o_Formularios
{
    public partial class Regis_Categoria : Form
    {
        public Regis_Categoria()
        {
            InitializeComponent();
        }

        private void btn_NuevoRegis_Click(object sender, EventArgs e)
        {
            //botón nuevo registro
            #region Runtina de limpiar las cajetillas de información 

            txt_Codigo_Categoria.Text = "";
            txt_Descripcion.Text = "";
            lab_estatus.Text = "Ingrese la Información";
            txt_Codigo_Categoria.Show();
            txt_Descripcion.Show();
            btn_Regis.Show();

            #endregion

        }

        private void btn_Regis_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean confirmacion; //variable para asegurarnos la acción


                Categoria nueva_categoria = new Categoria(); // instanciación de la calse categoria y creación variable nueva_categoría
                Manejo_de_datos baseDatos = new Manejo_de_datos(); //instanciación de la clase Manejo de Datos que es la que le pasa los datos a la base de datos

                //Datos con los que vamos a llenar las varibales de la clase cajero
                nueva_categoria.Codigo = Convert.ToInt32(txt_Codigo_Categoria.Text); //le pasamos el valor de la cajetilla codigo
                nueva_categoria.Descripcion = txt_Descripcion.Text; //le pasamos el valor de la cajetilla descripción


                // los datos que se llenaron en la clase categoría se envían para cargarlos a la base de Datos
                confirmacion = baseDatos.nuevaCategoria(nueva_categoria); //le mandamos toda la información por parámetro para que ejecute


                if (confirmacion)
                {
                    //si se realizó toda la operación se muestra un mensaje de confirmación
                    lab_estatus.Text = "SALIÓ TODO BIEN, GRACIAS A DIOS";
                    btn_Regis.Visible = false;


                    //Mensaje de sistema
                    string message = "Información almacenada de manera éxitosa";
                    string title = "Datos guardados";
                    MessageBox.Show(message, title);
                }
            }
            catch (Exception problema) //mensaje para atrapar los posibles errores
            {
                lab_estatus.Text = "TENEMOS UN PROBLEMA Y NO SE PUDO GUARDAR";
                MessageBox.Show("Que tirada, Ha sucedido un error: " + problema.Message.ToString(), "Error");
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //botón cerrar
        }

        private void Regis_Categoria_Load(object sender, EventArgs e)
        {

        }
    }
}
