using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser
{
    class GameService
    {
        public GameService()
        {
               
        }

        public int Initialize()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Bienvenido a Guesser, seleccìona el modo que quieres jugar:");
            Console.WriteLine("1: Tu adivinas el número ");
            Console.WriteLine("2: La IA adivinará el número!");
            int choice = Convert.ToInt32(Console.ReadLine());
            OpcionValida(choice);
            return choice;
        }

        private bool IsValid(int choice)
        {
            if (choice != 1 && choice != 2)
            {
                return false;
            }
            return true;
        }

        public void OpcionValida(int choice)
        {
            while (!IsValid(choice))
            {
                Console.WriteLine("El caracter ingresado es invalido. Ingrese una de las opciones correctas");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void GameStarted (int choice)
        {
            if (choice == 1)
            {
                Console.WriteLine("Has elegido adivinar el número! Preparate...");
            }
            else
            {
                Console.WriteLine("Has elegido que la IA adivine tu número. Preparate...");
            }
        }
    }
}
