using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_figurer
{
    class Triangle : Shape
    {
        public double BaseLength { get; private set; }
        public double Height { get; private set; }
        public Triangle(double baselength, double height)
        {
            BaseLength = baselength;
            Height = height;
        }
        public override double GetArea()
        {
            return BaseLength * Height * 0.5;
        }
    }
}
