using System;

namespace Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of points:");
            int numPoints = int.Parse(Console.ReadLine());

            double[,] points = new double[numPoints, 2];

            Console.WriteLine("Enter the x, y values of the points:");
            for (int i = 0; i < numPoints; i++)
            {
                Console.Write("Point {0}: ", i + 1);
                string[] pointValues = Console.ReadLine().Split(',');
                points[i, 0] = double.Parse(pointValues[0]);
                points[i, 1] = double.Parse(pointValues[1]);
            }

            double[] coefficients = InterpolationPolynomial(points);

            Console.WriteLine("Interpolation polynomial:");
            for (int i = 0; i < coefficients.Length; i++)
            {
                Console.WriteLine(" + {0}x^{1}", coefficients[i], coefficients.Length - i - 1);
            }

            Console.WriteLine("f(-1) = {0}", EvaluatePolynomial(coefficients, -1));
            Console.WriteLine("f(0) = {0}", EvaluatePolynomial(coefficients, 0));
            Console.WriteLine("f(1) = {0}", EvaluatePolynomial(coefficients, 1));

            double[] derivativeCoefficients = Derivative(coefficients);

            Console.WriteLine("Derivative of interpolation polynomial:");
            for (int i = 0; i < derivativeCoefficients.Length; i++)
            {
                Console.WriteLine(" + {0}x^{1}", derivativeCoefficients[i], derivativeCoefficients.Length - i - 1);
            }
        }

        static double[] InterpolationPolynomial(double[,] points)
        {
            
        }

        static double[] GaussianElimination(double[,] a, double[] b)
        {
            
        }

        static double EvaluatePolynomial(double[] coefficients, double x)
        {
           
        }

        static double[] Derivative(double[] coefficients)
        {
            double[] derivativeCoefficients = new double[coefficients.Length - 1];
            for (int i = 0; i < derivativeCoefficients.Length; i++)
            {
                derivativeCoefficients[i] = (coefficients.Length - i - 1) * coefficients[i];
            }
            return derivativeCoefficients;
        }
    }
}
