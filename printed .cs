using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac29._2
{
    internal class Printed
    {
        int copies;
        string name;
        int price;

        public int Copies { get => copies; set => copies = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }

        public Printed() { }

        public Printed(int copies, string name, int price)
        {
            Copies = copies;
            Name = name;
            Price = price;
        }

        public virtual int Cost()
        {
            return Copies * Price;
        }
        /// <summary>
        /// Вывод
        /// </summary>
        public virtual void Output()
        {
            Console.WriteLine($"Название:{Name} Колво копий:{Copies} Цена:{Price}");
        }
    }
}
