using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign03
{
    class SapphireDragon : Dragon
    {

        public SapphireDragon(string name, decimal size, bool good) : base(name, "Blue", size, good)
        {
            Type = "Blue";
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
