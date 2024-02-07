using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culebra
{
    public enum Direccion
    {
        Arriba,
        Abajo,
        Izquierda,
        Derecha
    };

    public class Ajustes
    {
        public static int Ancho { get; set; }
        public static int Alto { get; set; }
        public static int Velocidad { get; set; }
        public static int Marcador { get; set; }
        public static int Puntos { get; set; }
        public static bool GameOver { get; set; }
        public static Direccion Direccion { get; set; }

        public Ajustes()
        {
            Ancho = 16;
            Alto = 16;
            Velocidad = 16;
            Puntos = 100;
            GameOver = false;
            Direccion = Direccion.Abajo;
        }
    }
}
