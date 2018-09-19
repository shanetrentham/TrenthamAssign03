using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign03
{
    class DragonBuilder
    {
        Dragon dragon;

        public DragonBuilder()
        {
            dragon = null;
        }

        public void BuildDragon()
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Type: ");
            string type = Console.ReadLine();

            Console.WriteLine("Size: ");
            decimal size = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Good or Evil: ");
            string UserIn = Console.ReadLine();
            Boolean good = true;

            if (UserIn == "Good" || UserIn == "good")
            {
                good = true;
            }
            else if (UserIn == "Evil" || UserIn == "evil")
            {
                good = false;
            }

            dragon = new Dragon(name, type, size, good);
        }

        public Dragon GetDragon()
        {
            return dragon;
        }
    }
}
