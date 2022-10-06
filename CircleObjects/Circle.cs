using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    internal class Circle
    {
        //properties
        public double radius { get; set; }

        //constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return Math.Round(circumference, 2);
        }
        public double CalculateArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return Math.Round(area, 2);
        }


    }
}