using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign03
{
    class EmeraldDragon
    {
        public bool Good { get; private set; }
        public string Name { get; private set; }
        public decimal Size { get; private set; }
        public string Type = "Green";

        public EmeraldDragon(string name, decimal size, bool good)
        {
            Name = name;
            Size = size;
            Good = good;
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
