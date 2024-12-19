using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    abstract class Shape
    {
        public abstract void Draw();

        public void Check()
        {
            Console.WriteLine("Just checking shape .");
        }
        
            
        
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
        
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle. ");
        }
    }
}
