using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Shapes
{
    public class Rectangle : Shape
    {
        double width;
        double height;
        public Rectangle()
        {

        }
        public Rectangle(double width , double height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(double width,double height , string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.height = height;
        }
        public override double GetArea()
        {
            return height * width;
        }

        public override double GetPerimeter()
        {
            return 2*width + 2*height;
        }
        public double GetWidth()
        {
            return width;
        }
        public void SetWidth(double width)
        {
            this.width = width;
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double width)
        {
            this.height = height;
        }
        public string ToString()
        {
            return $"Shape color =  {color} filled = {filled} width = {width} lengt = {height}";
        }
    }
}
