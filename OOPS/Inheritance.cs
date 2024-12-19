using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Animal
    {
        public void eat()
        {
            Console.WriteLine("Animal Eats");
        }

    }
    class Cat : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Meow");
        }
    }

}
