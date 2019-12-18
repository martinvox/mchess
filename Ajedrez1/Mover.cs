using System;

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
            Salir = false;
        }

        public bool Salir { get; set; }

        public void RealizarMovimiento()
        {
            EntradaDatos();

            if (!Salir)
                OrdenarPeones();
        }

        private void EntradaDatos()
        {
            //ingresar datos y validarlos
            //el programa se ejecuta hasta ingresar datos invalidos
            Console.WriteLine("Ingrese coordenada X");
            Salir = ValidarEntrada(int.TryParse(Console.ReadLine(), out puntoX));

            if (!Salir) //al ser distinto de salir se pasa la validación previa para moverse al próximo punto hasta ingresar punto de partida y destino
            {
                Console.WriteLine("Ingrese coordenada Y");
                Salir = ValidarEntrada(int.TryParse(Console.ReadLine(), out puntoY));
            }

            if (!Salir)
            {
                Console.WriteLine("Ingrese coordenada X");
                Salir = ValidarEntrada(int.TryParse(Console.ReadLine(), out destinoX));
            }

            if (!Salir)
            {
                Console.WriteLine("Ingrese coordenada Y");
                Salir = ValidarEntrada(int.TryParse(Console.ReadLine(), out destinoY));
            }
        }

        private bool ValidarEntrada(bool parsed)
        {
            bool error = false;

            if (!parsed)
                error = true;
            else if (puntoX < 0 || puntoY < 0 || destinoX < 0 || destinoY < 0)
                error = true;
            else if (puntoX > Tablero.tamano - 1 || puntoY> Tablero.tamano - 1 ||
                      destinoX > Tablero.tamano - 1 || destinoY > Tablero.tamano - 1)
                error = true;

            if (error)
                Console.WriteLine("Entrada invalida, saliendo del programa");

            return error;
        }

        private void OrdenarPeones()
        {
            peones[destinoX, destinoY] = peones[puntoX, puntoY]; //mover/copiar ficha
            peones[puntoX, puntoY] = Espacio; //ingresar un espacio en el lugar original
        }
    }
}
