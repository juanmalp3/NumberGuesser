using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GameService game = new GameService();
            int Choice = game.initialize();
            game.gameStarted(Choice);

            Console.ReadKey();
        }
    }
}
