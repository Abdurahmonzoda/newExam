using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Shapes
{
    public class Circle : Shape
    {
        double radius;
        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius , string color , bool filled) : base(color , filled)
        {
            this.radius=radius;
        }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;  
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public string ToString()
        {

            return $"Shape color = {color} filled is : {filled} radius = {radius} "; 
        }
    }
}
