//UNED Programación Avanzada 830
//Estudiante Elmer Eduardo Salazar Flores

//Clase Producto perteneciente a la biblioteca Entidad_cajero_catego_prod donde se establecen las variables

namespace Entidad_cajero_catego_prod
{
    public class Producto
    {
        //declaración de las variables
        private int codigo = 0;
        private string descripcion = "";
        private decimal precio;
        private int existencia = 0;
        private int categoría = 0;

        //declaración de los métodos Get y Set
        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Existencia { get => existencia; set => existencia = value; }
        public int Categoría { get => categoría; set => categoría = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
}
