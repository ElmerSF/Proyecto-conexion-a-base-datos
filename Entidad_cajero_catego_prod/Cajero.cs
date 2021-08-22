//UNED Programación Avanzada 830
//Estudiante Elmer Eduardo Salazar Flores

//Clase Cajero de la Biblioteca Entidad_cajero_catego_prod donde se establecen las variables

namespace Entidad_cajero_catego_prod
{
    public class Cajero
    {
        //declaramos las varibles
        public int id = 0;
        public string nombre;
        public string prim_Apellido;
        public string seg_Apellido = "";
        public int cajasig = 0;

        //establecemos los métodos Get y Set
        public int Identificacion { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Primer_Apellido { get => prim_Apellido; set => prim_Apellido = value; }
        public string Segundo_Apellido { get => seg_Apellido; set => seg_Apellido = value; }
        public int N_Caja_Asignada { get => cajasig; set => cajasig = value; }
    }
}
