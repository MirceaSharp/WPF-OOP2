using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OOP2
{
    class Circle
    {
        private double _radius;

        public double Straal {get;set;}

        public Circle(double Radius)
        {
            _radius = Radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * _radius;
        }
        public double CalculateSurface()
        {
            return  Math.PI * Math.Pow(_radius, 2);
        }
        public string FormattedCircumference()
        {
            return CalculateCircumference().ToString("F");
        }
        public string FormattedSurface()
        {
            return CalculateSurface().ToString("F");
        }

    }
}
