using System;
using System.Collections.Generic;
using System.Text;

namespace task6
{
    class Triangle
    {
        public double A, B, C; double P, S, dA, dB, dC;
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public virtual bool ExistTriangle()
        {
            return ((A + B > C) || (B + C > A) || (C + A > B));
        }

        public string ShowInfo()
        {
            return ($"{A}, {B}, {C}");
        }

        public virtual double Perimetr()
        {
            P = A + B + C;
            return P;
        }

        public virtual double Square()
        {
            S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            return S;
        }

        public virtual string Degrees()
        {
            dA = Math.Acos(Math.Pow(B, 2) + Math.Pow(C, 2) - Math.Pow(A, 2)) / (2 * B * C);
            dB = Math.Acos(Math.Pow(A, 2) + Math.Pow(C, 2) - Math.Pow(B, 2)) / (2 * A * C);
            dC = Math.Acos(Math.Pow(B, 2) + Math.Pow(A, 2) - Math.Pow(C, 2)) / (2 * B * A);
            return ($"{dA}, {dB}, {dC}");
        }
    }
}
