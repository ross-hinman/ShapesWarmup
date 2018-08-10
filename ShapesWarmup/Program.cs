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
            var rectangle = new Rectangle(5, 4, "Rectangle");
            Console.WriteLine(rectangle.ToString());
            
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
        public override string ToString()
        {
            return $"{Name} does not have an implimented area";
        }

        
    }

    public class Rectangle : Shape
    {
        public Rectangle(int length, int width, string name = "Rectangle") : base(name)
        {
            Width = width;
            Length = length;
        }
        public int Width { get; set; }
        public int Length { get; set; }

        public override double CalculateArea()
        {
            return (Length * Width);
        }

        public override string ToString()
        {
            return $"The {Name} has area {CalculateArea()}";
        }
    }
    public class Square : Rectangle
    {
        public Square(int length, string name = "Square") : base(length)
        {
            Name = name;   
        }
        public string Name { get; set; }

        public override double CalculateArea()
        {
            return (Length*Length);
        }
    }


}
