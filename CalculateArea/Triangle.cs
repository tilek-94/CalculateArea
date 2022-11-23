using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Triangle : IFigure
    {
        private double _A { get; set; }
        private double _B { get; set; }
        private double _C { get; set; }
        private double _P { get; set; }

        public Triangle(double a, double b, double c)
        {
            _A = a;
            _B = b;
            _C = c;
        }
        /// <summary>
        /// Площадь треугольника  
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            _P = (_A + _B + _C) / 2;
            return Math.Sqrt(_P * (_P - _A) * (_P - _B) * (_P - _C));
        }
        /// <summary>
        /// Проверку на то, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool GetInfoTriangleRectangular()
        {
            if (_A * _A == _B * _B + _C * _C || _B * _B == _A * _A + _C * _C || _C * _C == _A * _A + _B * _B)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
