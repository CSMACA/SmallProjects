using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoes
{
    public class Domino
    {
        public Domino(char direction)
        {
            Direction = direction;
        }
        /// <summary>
        /// Contains direction that the domino is falling.
        /// L,.,R
        /// </summary>
        public char Direction { get; set; }
    }
}
