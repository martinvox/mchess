using System;


namespace Ajedrez1
{
    public class Peon
    {
        public const char SimboloPeon = 'X';
        public const char Espacio = ' ';
        public static char[,] peones;

        public Peon()
        {
            peones = new char[Tablero.tamano, Tablero.tamano];
            PopPeon(); //llena los espacios de las primeras dos filas de cada lado con espacios (Espacio) y peones
        }

        private void PopPeon()
        {
            for (int filas = 0; filas < Tablero.tamano; filas++)
            {
                for (int columnas = 0; columnas < Tablero.tamano; columnas++)
                {
                    // ingresa SimboloPeon en las primeras 2 filas
                    if (filas == 0 || filas == 1 || filas == Tablero.tamano - 2 || filas == Tablero.tamano - 1)
                        peones[filas, columnas] = SimboloPeon;
                    else
                        peones[filas, columnas] = Espacio;
                }
            }
        }
    }
}
