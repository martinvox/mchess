using System;


namespace Ajedrez1
{
    public class Tablero
    {
        private string[,] tablero;
        public const int tamano = 8;

        private Mover mover;

        public Tablero()
        {
            mover = new Mover();
            tablero = new string[tamano, tamano];
            TableroHorizontal= "+---";
            TableroVertical = "| ";
        }

        public string TableroHorizontal { get; set; }
        public string TableroVertical { get; set; }

        public void MostrarTablero()
        {
            while (!mover.Salir)
            {
                Console.Clear();
                Console.WriteLine("Ajedrez libre\nNOTA: Ingresar un caracter invalido cerrará el programa\n");
                Console.WriteLine("X en eje vertical // Y en eje horizontal\n");
                Console.WriteLine("X/Y  0   1   2   3   4   5   6   7"); // escritura de numeros del eje Y

                for (int filas = 0; filas < tamano; filas++)
                {
                    Console.Write("  ");//espaciado izquierdo
                    for (int columnas = 0; columnas < tamano; columnas++)
                    {
                        Console.Write(TableroHorizontal); //patrón horizontal +===
                    }

                    Console.Write("+\n");

                    for (int contador = 0; contador < tamano; contador++)
                    {
                        if (contador == 0)
                            Console.Write(filas + " "); //escritura de numeros del eje Y

                        Console.Write(TableroVertical + Peon.peones[filas, contador] + " "); //mostrar los peones centrados con un espacio
                    }

                    Console.Write("|\n");
                }
                //impresion de ultima linea
                Console.Write("  "); //espaciado
                for (int contador = 0; contador < tamano; contador++)
                {
                    Console.Write(TableroHorizontal);
                }

                Console.Write("+\n\n");
                mover.RealizarMovimiento();
            }
        }

    }
}
