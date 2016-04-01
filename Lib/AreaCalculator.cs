using System;

namespace Lib
{
    public class TriangleAreaCalculator
    {
        internal double A, B, C;
        private double _cat1, _cat2;

        public TriangleAreaCalculator(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            Precision = InitialPrecision;
        }

        private const double InitialPrecision = .00001;

        public double Precision { get; set; }

        private bool Validate()
        {
            if (A <= 0 || B <= 0 || C <= 0)
                return false;
            //Находим гипотенузу и катеты
            double hyp = Math.Max(Math.Max(A, B), Math.Max(B, C));
            _cat1 = Math.Abs(hyp - C) < Precision ?
                Math.Min(A, B) :
                Math.Abs(hyp - B) < Precision ?
                Math.Min(A, C) :
                Math.Min(B, C);
            _cat2 = Math.Abs(_cat1 - A) < Precision ?
                Math.Min(B, C) :
                Math.Abs(_cat1 - B) < Precision ?
                Math.Min(A, C) :
                Math.Min(A, B);
            //Проверяем по теореме Пифагора
            return Math.Abs(Math.Pow(hyp, 2) - (Math.Pow(_cat1, 2) + Math.Pow(_cat2, 2))) < Precision;
        }

        public double GetArea()
        {
            if (!Validate())
                throw new Exception("Некорректно указаны параметры");
            // S = 1/2 * a * b
            return _cat1 * _cat2 / 2;
        }
    }
}
