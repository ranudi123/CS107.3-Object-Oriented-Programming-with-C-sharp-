using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Q4
{
    class Shape
    {
        private string shapeType;
        private double area;

        public Shape(string shapeType)
        {
            this.shapeType = shapeType;
        }

        public double GetArea()
        {
            return area;
        }

        public void SetArea(double area)
        {
            this.area = area;
        }

        public string GetShapeType()
        {
            return shapeType;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape type: {0}", shapeType);
            Console.WriteLine("Area: {0}", area);
            Console.ReadLine();
        }
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width) : base("Rectangle")
        {
            this.length = length;
            this.width = width;
            SetArea(CalculateArea(length, width));
        }

        public double CalculateArea(double length, double width)
        {
            return length * width;
        }

        public void SetDimensions(double length, double width)
        {
            this.length = length;
            this.width = width;
            SetArea(CalculateArea(length, width));
        }
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius) : base("Circle")
        {
            this.radius = radius;
            SetArea(CalculateArea(radius));
        }

        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
            SetArea(CalculateArea(radius));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 3);
            rectangle.DisplayShapeInfo();

            Circle circle = new Circle(4);
            circle.DisplayShapeInfo();

            Console.ReadLine();
        }
    }
}
