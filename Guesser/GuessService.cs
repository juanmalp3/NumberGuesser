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

        private int numberGenerator() {
            Random rn = new Random();
            var random = rn.Next();
            return random;
        } 
    }
}
