using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez1
{
    public class Peon
    {
        public const char SimboloPeon = 'X';
        public const char Espacio = ' ';
        public static char[,] peones;

        public Peon()
        {
            peones = new char[Tablero.DIMENSION, Tablero.DIMENSION];
            PopPeon();//populate pawn array with X and Spaces
        }

        private void PopPeon()
        {
            for (int r = 0; r < Tablero.DIMENSION; r++)
            {
                for (int c = 0; c < Tablero.DIMENSION; c++)
                {
                    //place X into forst 2 and last 2 rows of the array
                    if (r == 0 || r == 1 || r == Tablero.DIMENSION - 2 || r == Tablero.DIMENSION - 1)
                        peones[r, c] = SimboloPeon;
                    else
                        peones[r, c] = Espacio;
                }
            }
        }
    }
}
