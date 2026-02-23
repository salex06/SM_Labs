using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SM_LAB2.utils
{
    public class Vector
    {
        private List<double> vec;

        public int Size {
            get => vec.Count;
        }

        public Vector() {
            vec = new List<double>();
        }

        public Vector(List<double> vec) {
            this.vec = [.. vec];
        }

        public void Add(int index, double value) {
            if (index >= Size)
                throw new Exception($"Индекс {index} выходит за границы массива размера {Size}");

            vec[index] += value;
        }

        public void Mul(int index, double value) {
            if (index >= Size)
                throw new Exception($"Индекс {index} выходит за границы массива размера {Size}");

            vec[index] *= value;
        }

        public void Append(double value) {
            vec.Add(value);
        }

        public double Get(int index) {
            if (index >= Size)
                throw new Exception($"Индекс {index} выходит за границы массива размера {Size}");

            return vec[index];
        }

        public string Print() {
            StringBuilder sb = new StringBuilder();
            foreach (double d in vec) {
                sb.Append(Math.Round(d, 2).ToString() + " ");
            }

            return sb.ToString();
        }

        public static Vector operator -(Vector vector1) {
            for (int i = 0; i < vector1.Size; ++i) {
                vector1.Mul(i, -1);
            }

            return vector1;
        }

        public static Vector operator +(Vector vector1, Vector vector2)
        {
            Vector vec3 = new Vector();
            if (vector1.Size != vector2.Size) {
                throw new Exception("Размеры векторов не равны");
            }

            for (int i = 0; i < vector1.Size; ++i) {
                vec3.Append(vector1.Get(i) + vector2.Get(i));
            }

            return vec3;
        }

        public static Vector operator -(Vector vector1, Vector vector2)
        {
            return vector1 + (-vector2);
        }

        public static Vector operator +(Vector vector1, double val) {
            for (int i = 0; i < vector1.Size; ++i)
            {
                vector1.Add(i, val);
            }

            return vector1;
        }

        public static Vector operator -(Vector vector1, double val)
        {
            return vector1 + (-val);
        }

        public static Vector operator *(Vector vector1, double val)
        {
            for (int i = 0; i < vector1.Size; ++i)
            {
                vector1.Mul(i, val);
            }

            return vector1;
        }
    }
}
