using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
namespace Learning05
{
   public class Circle : Shape
    {
        private double _radius;
        public Circle(string color, double radius) : base (color)
        {        
            _radius = radius; 
        }
        public override double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
   }
}

