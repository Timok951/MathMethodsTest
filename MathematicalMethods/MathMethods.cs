using System;

namespace MathematicalMethods
{
    public class MathMethods
    {
        public double[] Discriminant(double a, double b, double c)
        {
            
            double d = b*b - 4*a*c;
            if (d > 0)
            {
                double x1 = (b * -1 + Math.Sqrt(d)) / 2 * a;
                double x2 = (b * -1 - Math.Sqrt(d)) / 2 * a;
                double[] x = new[] { x1, x2 };
                return x;

            }
            else if (d == 0)
            {

                double x1 = (b * -1) / 2 * a;
                double[] x = new[] { x1 };

                return (x);
            }

            else {
                return null;
            
            }

        }

        public double PrecentFromNumber (double num, double precent)
        {
            return num * 100 / precent;
        }

        static void Main(string[] args)
        {
           
        }
    }
}
