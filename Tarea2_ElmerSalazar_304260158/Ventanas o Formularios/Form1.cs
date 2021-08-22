//UNED Programación Avanzada 830
//Estudiante Elmer Eduardo Salazar Flores

//Clase del formulario Principal a partir de aquí se levanta el interfaz de usuario con todas las opciones del menu


using System;
using System.Windows.Forms;
using Tarea2_ElmerSalazar_304260158.Ventanas_o_Formularios;


namespace Tarea2_ElmerSalazar_304260158
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mostrarProductosDeUnaCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeCajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opción del menú registro de Cajeros, se presenta la ventana correspondiente
            Regis_Cajeros regcaj = new Regis_Cajeros();
            regcaj.Show();
        }

        private void mostrarCajerosRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opción del menú Mostrar Cajeros, se presenta la ventana correspondiente
            Mostrar_Cajeros moscaj = new Mostrar_Cajeros();
            moscaj.Show();
        }

        private void registroDeCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opción del Menú Registrar una nueva Categoría de Producto se presenta la ventana correspondiente
            Regis_Categoria ventregiscat = new Regis_Categoria();
            ventregiscat.Show();
        }

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opción del Menú Registrar un nuevo producto, se presenta la ventana correspondiente
            Regis_Producto regis_Producto = new Regis_Producto();
            regis_Producto.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opción del Menú Salir, se cierra la aplicación
            string mensaje = "¿Realmente quiere SALIR de este programa tan lindo?";
            const string cuadro = "Es en serio???";
            var resultado = MessageBox.Show(mensaje, cuadro,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {

                this.Close();
            }

        }

        private void mostrarCategoríasRegistradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opción del Menú Mostrar las categorías de Productos, se presenta la ventana correspondiente
            Mostrar_Categorias ver = new Mostrar_Categorias();

            ver.Visible = true;
        }

        private void mostrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registradosSinImportarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opción de Menú Mostrar todos los productos sin importar categoría, se presenta ventana correspondiente
            Mostrar_todos_Productos ver_prod = new Mostrar_todos_Productos();
            ver_prod.Visible = true;
        }

        private void registradosDeUnaCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opción de Menú Mostrar los productos según la categoría seleccionada, se presenta la ventana correspondiente
            Product_por_Categoria verProdCat = new Product_por_Categoria();
            verProdCat.Visible = true;
        }
    }
}
