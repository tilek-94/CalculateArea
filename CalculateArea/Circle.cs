using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Circle : IFigure
    {
        const double PI = 3.14;
        private double _radius { get; set; }
        public Circle(double radius)
        {
            _radius = radius;
        }
        /// <summary>
        /// площадь круга по радиусу
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return PI * Math.Pow(_radius, 2);
        }

    }
}
