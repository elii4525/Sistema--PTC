using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Formularios;

namespace Vistas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new frmLogin1());
=======
            Application.Run(new frmInventarioAggMaterial());
>>>>>>> 519a879f660e95e54bb17f81fdbab86552c51936
        }
    }
}
