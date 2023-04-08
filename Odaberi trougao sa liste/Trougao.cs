using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odaberi_trougao_sa_liste
{
    public class Trougao
    {
        private double a;
        private double b;
        private double c;

        public Trougao(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public override string ToString()
        {
            return "a = " + a + ", b = " + b + ", c = " + c;
        }

        public double Obim()
        {
            return a + b + c;
        }

        public double Povrsina()
        {
            double s = Obim() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public string Vrsta()
        {
            double max;
            if (c >= a && c >= b) max = c;
            else if (b >= a && b >= c) max = b;
            else max = a;

            double zbirKvadrata = a * a + b * b + c * c;
            if (max * max == zbirKvadrata - max * max)
                return "Trougao je pravougli";
            else if (max * max > zbirKvadrata - max * max)
                return "Trougao je tupougli";
            else
                return "Trougao je ostrougli";
        }

        public char TemeMax()
        {
            if (c >= a && c >= b) return 'C';
            else if (b >= a && b >= c) return 'B';
            else return 'A';
        }
    }
}