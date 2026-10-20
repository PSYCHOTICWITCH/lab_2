using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class House
    {
        private int floors;

        public House() 
        {
            this.floors = 1;
        }
        public House(int floors)
        {
            if (floors > 0)
            {
                this.floors = floors;
            }
            else
            {
                Console.WriteLine("Неверные данные");
            }
        }

        public override string ToString()
        {
            if (floors % 10 == 1 && floors != 11)
            {
                return $"дом с {floors} этажом";
            }
            else
            {
                return $"дом с {floors} этажами";
            }

        }
    }
}
