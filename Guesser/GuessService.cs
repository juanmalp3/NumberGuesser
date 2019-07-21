using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser
{
    class GuessService
    {
        public GuessService()
        { 
        }

        public int numberGenerator() {
            Random rn = new Random();
            var random = rn.Next(0,10);
            return random;
        }
    }
}
