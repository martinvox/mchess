using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez1
{
    public class Mover : Peon
    {
        private int puntoX;
        private int puntoY;
        private int destinoX;
        private int destinoY;

        public Mover()
        {
            puntoX = 0;
            puntoY = 0;
            destinoX = 0;
            destinoY = 0;
            Exit = false;
        }

        public bool Exit { get; set; }

        public void RealizarMovimiento()
        {
            EntradaDatos();

            if (!Exit)
                OrdenarPeones();
        }

        private void EntradaDatos()
        {
            //get input and validate it
            //the program runs until user enters invalid input.
            Console.WriteLine("Ingrese coordenada X");
            Exit = ValidarEntrada(int.TryParse(Console.ReadLine(), out puntoX));

            if (!Exit) //if we passed the previous validation, move to the next coordinates
            {
                Console.WriteLine("Ingrese coordenada Y");
                Exit = ValidarEntrada(int.TryParse(Console.ReadLine(), out puntoY));
            }

            if (!Exit) //if we passed the previous validation, move to the next coordinates
            {
                Console.WriteLine("Ingrese coordenada X");
                Exit = ValidarEntrada(int.TryParse(Console.ReadLine(), out destinoX));
            }

            if (!Exit) //if we passed the previous validation, move to the next coordinates
            {
                Console.WriteLine("Ingrese coordenada Y");
                Exit = ValidarEntrada(int.TryParse(Console.ReadLine(), out destinoY));
            }
        }

        private bool ValidarEntrada(bool parsed)
        {
            bool error = false;

            if (!parsed)
                error = true;
            else if (puntoX < 0 || puntoY < 0 || destinoX < 0 || destinoY < 0)
                error = true;
            else if (puntoX > Tablero.DIMENSION - 1 || puntoY> Tablero.DIMENSION - 1 ||
                      destinoX > Tablero.DIMENSION - 1 || destinoY > Tablero.DIMENSION - 1)
                error = true;

            if (error)
                Console.WriteLine("Entrada invalida, saliendo del programa");

            return error;
        }

        private void OrdenarPeones()
        {
            peones[destinoX, destinoY] = peones[puntoX, puntoY]; //place the symbol of the target into destination coordinates
            peones[puntoX, puntoY] = Espacio; //set the target symbol to space
        }
    }
}
