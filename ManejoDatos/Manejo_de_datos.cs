//UNED Programación Avanzada 830
//Estudiante Elmer Eduardo Salazar Flores

//Clase ManejoDatos perteneciente a la biblioteca Manejo_de_datos donde se manipulan todas las variables y se establece la 
// comunicación con la base de Datos
// Esta es la clase que hace todo el "brete" =)



//uso de las Biblioteca creada
using Entidad_cajero_catego_prod;
using System;
using System.Collections.Generic;
//acceso a la configuración para tomar la conexión
using System.Configuration;
//acceso a la base de datos
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManejoDatos
{
    public class Manejo_de_datos
    {
        //variable para pasar el parámetro de la conexión que es toda la cadena con la ruta y seguridad requerida
        private static string claveconexion = ConfigurationManager.ConnectionStrings["cadenaconexion"].ConnectionString;

        
        #region Guardar Información de un nuevo Cajero

        //Agregar a la base de datos la información contenida en la clase cajero, cuando se llena el formulario
        public Boolean nuevoCajero(Cajero newCajero)
        {
            Boolean confirmacion; //asegurarnos que se realizó

            //estructura del parametro de los datos para la base de datos en la tabla de CAJEROS 
            String parametro = " insert into dbo.Cajero(Identificacion, Nombre, PrimerApellido, SegundoApellido, CajaAsignada) values (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @CajaAsignada)";
            SqlConnection conectar; //nueva variable tipo sql

            SqlCommand orden = new SqlCommand(); //se instancia sqlComand
            conectar = new SqlConnection(claveconexion); // a la variable sql conectar se le pasa el parámetro de conexión a la base de datos

            //definir los parametros y ejecucion a la base datos
            orden.CommandType = CommandType.Text;
            orden.CommandText = parametro;
            orden.Connection = conectar;
            conectar.Open(); //se abre la conexión

            //parametrizacion de los datos hacia la base de datos
            orden.Parameters.AddWithValue("@Identificacion", newCajero.Identificacion);
            orden.Parameters.AddWithValue("@Nombre", newCajero.Nombre);
            orden.Parameters.AddWithValue("@PrimerApellido", newCajero.Primer_Apellido);
            orden.Parameters.AddWithValue("@SegundoApellido", newCajero.Segundo_Apellido);
            orden.Parameters.AddWithValue("@CajaAsignada", newCajero.N_Caja_Asignada);

            confirmacion = orden.ExecuteNonQuery() > 0; //revisar si se realizó la carga de la información


            return confirmacion;
        }

        #endregion

        #region Mostrar datos de Cajeros Registrados
        //Creación de una nueva lista del tipo cajero
        public List<Cajero> TablaCajeros()
        
        {
            
            List<Cajero> TablaCajeros = new List<Cajero>();


            SqlConnection conectar; //declaramos variable de conexión
            SqlCommand orden = new SqlCommand(); // varible de tipo sql comand
            conectar = new SqlConnection(claveconexion); //le pasamos el parámetro de la conexión
            SqlDataReader leerDatos; //creación de variable de lectura SqlDataReader
            //cadena de parámetro para ejecución en la base de datos
            String comando_baseDatos = " SELECT Identificacion,Nombre, PrimerApellido, SegundoApellido, CajaAsignada FROM Cajero ";

            //definir los parametros y ejecucion a la base datos
            orden.CommandType = CommandType.Text;
            orden.CommandText = comando_baseDatos;
            orden.Connection = conectar;
            conectar.Open(); //se abre la conexión
            leerDatos = orden.ExecuteReader(); // datos que devuelve la consulta en base datos

            //llenar el listado
            if (leerDatos.HasRows) //leer mientras haya celdas
            {
                while (leerDatos.Read())  //ciclo para llenar la lista con los valores de la base de datos
                {
                    TablaCajeros.Add(new Cajero
                    {
                        Identificacion = Convert.ToInt32(leerDatos.GetString(0)),
                        Nombre = leerDatos.GetString(1),
                        Primer_Apellido = leerDatos.GetString(2),
                        Segundo_Apellido = leerDatos.GetString(3),
                        N_Caja_Asignada = leerDatos.GetInt32(4)
                    });


                }
            }

            return TablaCajeros; //se retorna la lista
        }


        #endregion

        #region Guardar categoria de Producto
        //Rutina para agregar una nueva categoría de producto a la base de datos
        public Boolean nuevaCategoria(Categoria new_categoria)
        {
            Boolean confirmacion;

            //estructura del parametro de los datos para la base de datos en la tabla de Categoría de producto 
            String parametro = "insert Categoria (Codigo, Descripcion) values (@codigo, @descripcion)";
            SqlConnection conectar; //nueva variable tipo sql

            SqlCommand orden = new SqlCommand(); //se instancia sqlComand
            conectar = new SqlConnection(claveconexion); // a la variable sql conectar se le pasa el parámetro de conexión a la base de datos

            //definir los parametros y ejecucion a la base datos
            orden.CommandType = CommandType.Text;
            orden.CommandText = parametro;
            orden.Connection = conectar;
            conectar.Open();

            //parametrizacion de los datos hacia la base de datos
            orden.Parameters.AddWithValue("@codigo", new_categoria.Codigo);
            orden.Parameters.AddWithValue("@descripcion", new_categoria.Descripcion);


            confirmacion = orden.ExecuteNonQuery() > 0; //revisar si se realizó la carga de la información


            return confirmacion;
        }

        #endregion

        #region Llenar el Combobox con las categorias a seleccionar
        //Esta Rutina busca los valores en la base de datos en el apartado de Categorías de Producto
        //una vez que los obtiene llena un Combobox con dichos valores
        public void Llenarcombo(ComboBox menu_categorias) //en la varible menú de categorías traemos el parámetro
        {

            SqlConnection conectar; //nueva variable tipo sql
            SqlCommand orden = new SqlCommand(); // variable sqlComand
            conectar = new SqlConnection(claveconexion); //le pasamos la ruta de conexión
            string parametro = "select * from Categoria"; //parametro para la base de datos

            //definir los parámetros y ejecución hacia la base de datos
            orden.CommandType = CommandType.Text;
            orden.CommandText = parametro;
            orden.Connection = conectar;
            conectar.Open(); //abrimos la conexión

            menu_categorias.Items.Clear(); //limpiamos antes de inicia

            SqlDataReader leerDatos; //variable de lectura
            leerDatos = orden.ExecuteReader(); // ejecución de la lectura

            while (leerDatos.Read()) //ciclo mientras se esté leyendo para llenar el combobox
            {
                menu_categorias.Items.Add(leerDatos[1].ToString()

                    );

            }

            menu_categorias.SelectedIndex = 0; //lo estacionamos en el primer valor
        }
        #endregion

        #region Asociar la Categoria de Producto al código
        //con esta rutina asociamos el valor selecionado en el Combobox de Categorías para obtener el 
        //codigo de esa categoría 

        public int Asociar_codigo(string seleccion)
        {
            int resultado;
            SqlConnection conectar; //nueva variable tipo sql


            conectar = new SqlConnection(claveconexion); //le pasamos ruta de conexión

            conectar.Open(); //abrimos la conexión

            //parametro para la base de datos
            string parametro = "select Codigo from Categoria where Descripcion = '" + seleccion + "' ";
            SqlCommand orden = new SqlCommand(); //instanciamos una nueva variable comando tipo SqlComand

            //definir los parametros y ejecucion a la base datos
            orden.CommandType = CommandType.Text;
            orden.CommandText = parametro;
            orden.Connection = conectar;
                                 
            SqlDataReader leerDatos; //definimos una variable de lectura
            leerDatos = orden.ExecuteReader(); //ejecutamos la lectura

            leerDatos.Read(); 

            //a la variable resultado le pasamos el valor numérico de la lectura de la base de Datos
            resultado = Convert.ToInt32(leerDatos[0]);




            return resultado;
        }

        #endregion

        #region Guardar Producto
        public Boolean NuevoProducto(Producto new_producto)
        {
            Boolean confirmacion;

            //estructura del parametro de los datos para la base de datos en la tabla de producto 
            //parametro en la base de datos para insertar un nuevo registro
            String parametro = "insert Producto (Codigo, Descripcion, Precio, Cantidad, CodigoCategoria) values (@codigo, @descripcion, @precio, @cantidad, @codigoCategoria)";
            SqlConnection conectar; //nueva variable tipo sql

            SqlCommand orden = new SqlCommand(); //se instancia sqlComand
            conectar = new SqlConnection(claveconexion); // a la variable sql conectar se le pasa el parámetro de conexión a la base de datos

            //definir los parametros y ejecucion a la base datos
            orden.CommandType = CommandType.Text;
            orden.CommandText = parametro;
            orden.Connection = conectar;
            conectar.Open();

            //parametrizacion de los datos hacia la base de datos
            orden.Parameters.AddWithValue("@codigo", new_producto.Codigo);
            orden.Parameters.AddWithValue("@descripcion", new_producto.Descripcion);
            orden.Parameters.AddWithValue("@precio", new_producto.Precio);
            orden.Parameters.AddWithValue("@cantidad", new_producto.Existencia);
            orden.Parameters.AddWithValue("@codigoCategoria", new_producto.Categoría);


            confirmacion = orden.ExecuteNonQuery() > 0; //revisar si se realizó la carga de la información


            return confirmacion;
        }
        #endregion

        #region Mostrar Categorías de Produtos

        //Lista con los datos de la tabla categorías
        public List<Categoria> TablaCategorias()

        {

            List<Categoria> TablaCategoria = new List<Categoria>();


            SqlConnection conectar;
            SqlCommand orden = new SqlCommand();
            conectar = new SqlConnection(claveconexion); //le pasamos la ruta 
            SqlDataReader leerDatos; // variable para lectura
            //cadena coon el comnando para la base de datos
            String comando_baseDatos = " select Codigo, Descripcion from Categoria ";

            //definir los parametros y ejecucion a la base datos
            orden.CommandType = CommandType.Text;
            orden.CommandText = comando_baseDatos;
            orden.Connection = conectar;
            conectar.Open();
            leerDatos = orden.ExecuteReader(); // datos que devuelve la consulta en base datos

            //llenar el listado si hay celdas
            if (leerDatos.HasRows)
            {
                while (leerDatos.Read()) //mientras haya lectura
                {
                    TablaCategoria.Add(new Categoria //llena la tablaCategoría con la lectura
                    {
                        Codigo = Convert.ToInt32(leerDatos.GetInt32(0)),
                        Descripcion = leerDatos.GetString(1)

                    });


                }
            }

            return TablaCategoria;
        }


        #endregion


        #region Mostrar productos según seleción de Categoría

        public List<Producto> TablaProductXCatego(int seleccionada)

        {
            //nueva lista de para tabla de productos por categoría
            List<Producto> TablaProductXCatego = new List<Producto>();

            SqlConnection conectar; //declaramos variable sql
            SqlCommand orden = new SqlCommand(); // se instancia comando Sql
            conectar = new SqlConnection(claveconexion); //le pasamos la ruta de conexión
            SqlDataReader leerDatos; //variable de lectura
            //parametro para la base de datos selecionamos toda la informacion bajo el parámetro seleccionada que es la seleción hecha por el usuario
            String comando_baseDatos = " select * from Producto where CodigoCategoria = ' " + seleccionada + " '";

            //definir los parametros y ejecucion a la base datos
            orden.CommandType = CommandType.Text;
            orden.CommandText = comando_baseDatos;
            orden.Connection = conectar;
            conectar.Open(); //abrimos la conexión
            leerDatos = orden.ExecuteReader(); // datos que devuelve la consulta en base datos

            //llenar el listado si hay celdas
            if (leerDatos.HasRows)
            {
                while (leerDatos.Read())
                {
                    TablaProductXCatego.Add(new Producto //llenamos la tabla con la información leída
                    {
                        Codigo = Convert.ToInt32(leerDatos.GetInt32(0)),
                        Descripcion = leerDatos.GetString(1),
                        Precio = leerDatos.GetDecimal(2),
                        Existencia = leerDatos.GetInt32(3),
                        Categoría = leerDatos.GetInt32(4)

                    });


                }
            }

            return TablaProductXCatego;
        }


        #endregion


        #region Mostrar todos los Productos

        public List<Producto> TablaProduct()

        {
            //nueva lista para llenar con la información de prodcutos
            List<Producto> TablaProduct = new List<Producto>();


            SqlConnection conectar; //variable de conexión
            SqlCommand orden = new SqlCommand(); //instanciamos nuevo comando Sql
            conectar = new SqlConnection(claveconexion); //le pasamos la ruta de conexión
            SqlDataReader leerDatos; //variable de lectura
            //parametro para ejecución en la base de datos, selecionar de la tabla producto toda la información
            String comando_baseDatos = " select Codigo, Descripcion, Precio, Cantidad, CodigoCategoria from Producto";

            //definir los parametros y ejecucion a la base datos
            orden.CommandType = CommandType.Text;
            orden.CommandText = comando_baseDatos;
            orden.Connection = conectar;
            conectar.Open(); //abrimos la conexión
            leerDatos = orden.ExecuteReader(); // datos que devuelve la consulta en base datos

            //llenar el listado si hay celdas
            if (leerDatos.HasRows)
            {
                while (leerDatos.Read())
                {
                    TablaProduct.Add(new Producto  //los datos los almacenamos en la tabla de Productos
                    {
                        Codigo = Convert.ToInt32(leerDatos.GetInt32(0)),
                        Descripcion = leerDatos.GetString(1),
                        Precio = leerDatos.GetDecimal(2),
                        Existencia = leerDatos.GetInt32(3),
                        Categoría = leerDatos.GetInt32(4)

                    });


                }
            }

            return TablaProduct;
        }

        #endregion


    }
}


