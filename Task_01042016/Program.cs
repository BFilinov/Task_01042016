using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib;

namespace Task_01042016
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new TriangleAreaCalculator(1, 1, Math.Sqrt(2));
            calculator.Precision = .1;
            double area = calculator.GetArea();
        }
    }
}
