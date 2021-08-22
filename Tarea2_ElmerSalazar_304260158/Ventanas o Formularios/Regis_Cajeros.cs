//UNED Programación Avanzada 830
//Estudiante Elmer Eduardo Salazar Flores

//Clase del formulario Registro de Cajeros

using Entidad_cajero_catego_prod;
using ManejoDatos;
using System;
using System.Windows.Forms;


namespace Tarea2_ElmerSalazar_304260158.Ventanas_o_Formularios
{
    public partial class Regis_Cajeros : Form
    {
        public Regis_Cajeros()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_RegisCajero_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean confirmacion; //variable para asegurarnos la acción


                Cajero nuevo_cajero = new Cajero(); // instanciación de la calse cajero y creación variable nuevo_cajero
                Manejo_de_datos baseDatos = new Manejo_de_datos(); //instanciación de la clase Manejo de Datos que es la que le pasa los datos a la base de datos

                //Datos con los que vamos a llenar las varibales de la clase cajero
                nuevo_cajero.Identificacion = Convert.ToInt32(txt_Id.Text); //le pasamos el valor de la cajetilla ID
                nuevo_cajero.Nombre = txt_Nombre.Text; //le pasamos el valor de la cajetilla nombre
                nuevo_cajero.Primer_Apellido = txt_PrimApellido.Text; // le pasamos el valor de la cajetilla primer apellido
                nuevo_cajero.Segundo_Apellido = txt_SegApellido.Text; //le pasamos el valor de la cajetilla segundo apellido
                nuevo_cajero.N_Caja_Asignada = Convert.ToInt32(txt_NCaja.Text); //le pasamos el valor de la cajetilla caja asignada y lo convertimos en una variable tipo int

                // los datos que se llenaron en la clase cajero se envían para cargarlos a la base de Datos
                confirmacion = baseDatos.nuevoCajero(nuevo_cajero); //le mandamos toda la información por parámetro para que ejecute


                if (confirmacion)
                {
                    //Mensaje de confirmación de la operación exitosa
                    Info_usuario.Text = "SALIÓ TODO BIEN, GRACIAS A DIOS";
                    btnLimpiar.Show();
                    btn_RegisCajero.Visible = false;

                    //Mensaje de sistema
                    string message = "Información almacenada de manera éxitosa";
                    string title = "Datos guardados";
                    MessageBox.Show(message, title);
                }
            }
            catch (Exception problema) //Mensaje de error para atrapar cualquier problema
            {
                Info_usuario.Text = "TENEMOS UN PROBLEMA Y NO SE PUDO GUARDAR";
                MessageBox.Show("Que tirada, Ha sucedido un error: " + problema.Message.ToString(), "Error");
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            //rutina con la que se limpian las cajetillas
            #region Rutina limpiar las cajetillas
            txt_Id.Text = " ";
            txt_Nombre.Text = " ";
            txt_PrimApellido.Text = " ";
            txt_SegApellido.Text = " ";
            txt_NCaja.Text = " ";
            Info_usuario.Text = "Vamos por el siguiente, Venga!!";
            btn_RegisCajero.Visible = true;
            btnLimpiar.Visible = false;
            #endregion
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //botón cerrar
        }

        private void Regis_Cajeros_Load(object sender, EventArgs e)
        {

        }
    }
}
