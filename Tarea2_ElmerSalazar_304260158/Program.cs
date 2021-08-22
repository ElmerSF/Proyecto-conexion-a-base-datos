//UNED Programación Avanzada 830
//Estudiante Elmer Eduardo Salazar Flores

//Clase Program donde se establece la función Main que incluye desplegar el formulario principal

using System;
using System.Windows.Forms;

namespace Tarea2_ElmerSalazar_304260158
{
    static class Program
    {
        // se arranca el programa y se hace visible el primer formulario
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
