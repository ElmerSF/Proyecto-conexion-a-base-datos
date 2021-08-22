//UNED Programación Avanzada 830
//Estudiante Elmer Eduardo Salazar Flores

//Clase Categoría perteneciente a la biblioteca Entidad_cajero_catego_prod donde se establecen las variables

namespace Entidad_cajero_catego_prod
{
    public class Categoria
    {
        //se declaran las variables
        private int codigo = 0;
        private string descripción = "";

        //se declaran los métodos Get y Set
        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripción; set => descripción = value; }
    }
}
