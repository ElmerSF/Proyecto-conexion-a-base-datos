//UNED Programación Avanzada 830
//Estudiante Elmer Eduardo Salazar Flores

//Clase del Mostrar Cajeros

using Entidad_cajero_catego_prod;
using ManejoDatos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Tarea2_ElmerSalazar_304260158.Ventanas_o_Formularios
{
    public partial class Mostrar_Cajeros : Form
    {

        public Mostrar_Cajeros()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            try
            {

                List<Cajero> Info_cajeros = new List<Cajero>(); //instanciación de la clase cajero
                Manejo_de_datos abrir_datos = new Manejo_de_datos(); // instanciación de clase manejo de datos


                Info_cajeros = abrir_datos.TablaCajeros(); //se llama al proceso TablaCajeros y se almacena en variable Info_cajeros  
                Area_datos.DataSource = Info_cajeros; //se pinta la información en el area de la interfaz


            }

            catch (Exception Errorcillo) //excepción para atrapar los errores que se presenten
            {
                MessageBox.Show("SE CALLO Ha sucedido un error: " + Errorcillo.Message.ToString(), "Error");
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // botón para cerrar el formulario
        }

        private void Mostrar_Cajeros_Load(object sender, EventArgs e)
        {

        }
    }
}
