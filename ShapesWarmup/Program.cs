using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesWarmup
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Shape
    {
        protected Shape(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public abstract double CalculateArea();

        
    }

    public class Rectangle : Shape
    {
        public Rectangle(int length, int width, string name = "Rectangle") : base(name)
        {
        }

        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }

}
