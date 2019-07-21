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

        public int initialize()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Bienvenido a Guesser, seleccìona el modo que quieres jugar:");
            Console.WriteLine("1: Tu adivinas el número ");
            Console.WriteLine("2: La IA adivinará el número!");
            int choice = Convert.ToInt32(Console.ReadLine());
            opcionValida(choice);
            return choice;
        }

        private bool isValid(int choice)
        {
            if (choice != 1 && choice != 2)
            {
                return false;
            }
            return true;
        }

        public void opcionValida(int choice)
        {
            while (!isValid(choice))
            {
                Console.WriteLine("El caracter ingresado es invalido. Ingrese una de las opciones correctas");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void gameStarted (int choice)
        {
            if (choice == 1)
            {
                Console.WriteLine("Has elegido adivinar el número! Preparate...");
                playerGuess();

            }
            else
            {
                Console.WriteLine("Has elegido que la IA adivine tu número. Preparate...");
            }
        }

        public void playerGuess()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("Listo? La IA ha pensado en un número del 1 al 10. ¿Qué número es?");
            int guess = Convert.ToInt32(Console.ReadLine());
            GuessService guessing = new GuessService();
            int iaNumber = Convert.ToInt32(guessing.numberGenerator());
            isCorrect(guess, iaNumber);


        }

        public void isCorrect(int guess, int iaNumber)
        {
            int intentos = 3;
            while (guess != iaNumber && intentos >= 0)
            {
                intentos--;
                Console.WriteLine($"Ups! Fallaste, te quedan {intentos} intentos! Piensa bien");
                guess = Convert.ToInt32(Console.ReadLine());
                if (youLost(intentos))
                {
                    break;
                }

            }
            Console.WriteLine("Felicidades!! Acertaste el número. La PC está triste.");
        }

        private bool youLost (int intentos)
        {
            if (intentos <= 0)
            {
                Console.WriteLine("JAJAJAJAJA PERDISTE");
                return true;
            }
            return false;
        }
    }
}
