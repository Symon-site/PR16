using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    internal class Vector
    {
        private double[] elements;

        public Vector(params double[] values)
        {
            elements = new double[values.Length];
            Array.Copy(values, elements, values.Length);
        }
        public double this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        public static double operator *(Vector v1, Vector v2)
        {
            if (v1.elements.Length != v2.elements.Length)
            {
                Console.WriteLine("Векторы должны быть одного размера!");
            }

            double result = 0;
            for (int i = 0; i < v1.elements.Length; i++)
            {
                result += v1.elements[i] * v2.elements[i];
            }
            return result;
        }

        public override string ToString()
        {
            return "[" + string.Join(", ", elements) + "]";
        }
    }
}
