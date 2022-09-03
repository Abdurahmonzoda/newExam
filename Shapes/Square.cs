using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Shapes
{
    public class Square : Rectangle
    {
        double side;
        public Square()
        {

        }
        public Square(double side)
        {
            this.side = side;
        }
        public Square(double side, string color, bool filled) : base(side, side , color , filled)
        {

        }
        public override double GetArea()
        {
            return side*side;
        }

        public override double GetPerimeter()
        {
            return side * 4;
        }
        public double GetSide()
        {
            return side;
        }
        public void SetSide(double side)
        {
            SetSide(side); 
        }
        public void SetWidth(double side)
        {
            SetWidth(side); 
        }
        public void SetLength(double side)
        {
            this.side = side;
        }

        public string ToString()
        {
            return $"Shape color = {color} filled = {filled} width = {GetWidth()} length = {GetHeight()} ";
        }
    }
}
