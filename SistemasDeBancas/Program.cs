using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemasDeBancas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
             if (Login.Validar())
                Application.Run(new VentanaPrincipal());
            
               
                
            






        }
    }
}
