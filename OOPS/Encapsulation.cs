using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace OOPS
{
    internal class Encapsulation
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Please Enter positive age. ");
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Name is " + name);
            Console.WriteLine("The Age is " + age);
        }
            


    }
}
