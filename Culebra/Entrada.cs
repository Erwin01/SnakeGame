using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culebra
{
    public class Entrada
    {
        // Clase tipo Lista que carga botones de teclado disponibles
        private static Hashtable KeyTable = new Hashtable();

        // Metodo que Realiza una comprobación para ver si se presiona un botón en particular
        public static bool KeyPressed(Keys key)
        {
            if (KeyTable[key] == null)
            {
                return false;
            }
            else
            {
                return (bool)KeyTable[key];
            }
        }

        // Metodo para Detectar si se presiona un botón del teclado
        public static void ChangeState(Keys key, bool state)
        {
            KeyTable[key] = state;
        }
    }
}
