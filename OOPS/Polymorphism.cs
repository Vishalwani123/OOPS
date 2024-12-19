using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    //internal class Polymorphism
    //{
    //}
    class Ani
    {
        public virtual void Speak()
        {
            Console.WriteLine("The Animal should Speak also.");
        }
       
    }
    class Rat : Ani
    {
        public override void Speak()
        {
            Console.WriteLine("The Rat should Speak also.");

        }
    }
}
