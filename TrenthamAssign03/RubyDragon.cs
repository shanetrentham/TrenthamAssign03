using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign03
{
    class RubyDragon : Dragon
    {

        public RubyDragon(string name, decimal size, bool good) : base(name, "Red", size, good)
        {
            Type = "Red";
        }

        public override string ToString()
        {
            if (Good)
            {
                return $"{Name} - {Type} - {Size} - Good";
            }
            else
                return $"{Name} - {Type} - {Size} - Evil";
        }
    }
}
