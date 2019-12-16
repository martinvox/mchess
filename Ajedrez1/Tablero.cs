using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez1
{
    public class Tablero
    {
        private string[,] tablero;
        public const int DIMENSION = 8; //original 8x8 board

        private Mover mover;

        public Tablero()
        {
            mover = new Mover();
            tablero = new string[DIMENSION, DIMENSION];
            TableroHorizontal= "+---";
            TableroVertical = "| ";
        }

        public string TableroHorizontal { get; set; }
        public string TableroVertical { get; set; }

        public void MostrarTablero()
        {
            while (!mover.Exit)
            {
                Console.Clear();
               // Console.WriteLine("X/Y");
                Console.WriteLine("X/Y  0   1   2   3   4   5   6   7"); // x axis header

                for (int r = 0; r < DIMENSION; r++)
                {
                    Console.Write("  ");//left spacing - 2 spaces
                    for (int c = 0; c < DIMENSION; c++)
                    {
                        Console.Write(TableroHorizontal); //write the horizontal pattern
                    }

                    Console.Write("+\n");

                    for (int c = 0; c < DIMENSION; c++)
                    {
                        if (c == 0)
                            Console.Write(r + " "); //y axis header

                        Console.Write(TableroVertical + Peon.peones[r, c] + " "); //display the pawn neatly centered
                    }

                    Console.Write("|\n");
                }

                //the bottom line needs to be printed separately
                Console.Write("  "); //left spacing
                for (int c = 0; c < DIMENSION; c++)
                {
                    Console.Write(TableroHorizontal);
                }

                Console.Write("+\n\n");
                mover.RealizarMovimiento();
            }
        }

    }
}
