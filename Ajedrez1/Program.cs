using System;


/* Todolist: 
    Piezas con sus propiedades (nombres y movimientos)
    Distribución del tablero (blanco,negro)
    Permitir el seguimiento del juego al errar movimiento
*/

namespace Ajedrez1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablero tablero = new Tablero();
            tablero.MostrarTablero();
        }
    }
}
