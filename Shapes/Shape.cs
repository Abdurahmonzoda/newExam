using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Shapes
{
    public abstract class Shape
    {
        public string color { get; private set; }
        public bool filled { get; private set; }
        public Shape()
        {

        }
        public Shape(string color , bool filled)

        {
            this.color = color;
            this.filled = filled;   
        }
        public string GetCollor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color=color;
        }
        public abstract double GetArea(); 
        public abstract double GetPerimeter(); 
        public string ToString()
        {
            return $"Shape color = {color} filled is : {filled}"; 
        }


    }
}
