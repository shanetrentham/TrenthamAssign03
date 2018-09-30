using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign03
{
    class Dignity
    {
        ArrayList dignity = new ArrayList();
        ArrayList DragonType = new ArrayList();

        public void AddDragon(Dragon dragon)
        {
            dignity.Add(dragon);
        }

        public int Count()
        {
            return dignity.Count;
        }

        public override string ToString()
        {
            string alldragons = "";
            foreach (string dragon in dignity)
            {
                alldragons += dragon + "\n";
            }
            return alldragons;
        }

        public Dragon GetLargest()
        {
            Dragon largest = new Dragon("", "", 0, true);

            foreach (Dragon dragon in dignity)
            {
                if (dragon.GetSize() > largest.GetSize())
                {
                    largest = dragon;
                }
            }
            return largest;
        }

        public Dragon GetLargestofType(string type)
        {
            foreach (Dragon dragon in dignity)
            {
                if (dragon.getType() == type)
                {
                    DragonType.Add(dragon);
                }

            }
            if (DragonType.Count == 0)
            {
                Console.WriteLine($"There are no dragons of {type} in the dignity");
                return null;
            }
            else
            {
                Dragon Largest = new Dragon("", "", 0, true);
                foreach (Dragon dragon in DragonType)
                {
                    if (dragon.GetSize() > Largest.GetSize())
                    {
                        Largest = dragon;
                    }
                }
                return Largest;
            }


        }

        public int GetGood()
        {
            int total = 0;
            foreach (Dragon dragon in dignity)
            {
                if (dragon.GetGood())
                {
                    total++;
                }
            }
            return total;
        }

        public int GetBad()
        {
            int total = 0;
            foreach (Dragon dragon in dignity)
            {
                if (dragon.GetGood() == false)
                {
                    total++;
                }
            }
            return total;
        }
        public void GetAllDragons()
        { 
            foreach(var dragon in dignity)
            {
                Console.WriteLine(dignity.ToString());
            }
        }

        public void GetLargerThanSize(decimal size)
        {
            foreach(Dragon dragon in dignity)
            {
                if (dragon.GetSize() > size)
                {
                    Console.WriteLine(dragon.ToString());
                }
                else
                    Console.WriteLine($"There are no dragons larger than {size} feet");
            }


        }
    }
}
