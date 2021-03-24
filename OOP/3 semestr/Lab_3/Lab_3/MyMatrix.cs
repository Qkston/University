using System;
using System.Linq;

namespace Lab_3
{
    public class MyMatrix
    {
        private double[,] matrix;
        public double this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }
        public MyMatrix(MyMatrix newMatrix)
        {
            MyMatrix _matrix = newMatrix;
        }

        public MyMatrix(double[,] mat)
        {
            matrix = mat;
        }
        public MyMatrix(double[][] _matrix)
        {
            bool straight = true;
            for (int i = 0; straight && i < _matrix.Length; i++)
            {
                for (int j = 0; straight && j < _matrix[i].Length; j++)
                {
                    if (_matrix[i].Length != _matrix[0].Length)
                    {
                        Console.WriteLine("Impossible. Matrix not rectangular!");
                        straight = false;
                    }
                    this.matrix[i, j] = _matrix[i][j];
                }
            }
        }
        public MyMatrix(string[] mat)
        {
            int[] temp;
            double[,] temp2 = new double[mat.Length, mat.Length];
            for (int i = 0; i < mat.Length; i++)
            {
                temp = mat[i].Split().Select(int.Parse).ToArray();
                for (int j = 0; j < temp.Length; j++)
                {
                    temp2[i, j] = temp[j];
                }
            }
            matrix = temp2;
        }
        public int GetHeight()
        {
            return matrix.GetLength(0);
        }
        public int GetWidth()
        {
            return matrix.GetLength(1);
        }
        public static MyMatrix Sum(MyMatrix first, MyMatrix second)
        {
            double[,] array1 = new double[first.GetHeight(), first.GetWidth()];
            if (first.GetHeight() != second.GetHeight() || first.GetWidth() != second.GetWidth())
            {
                Console.WriteLine("Impossible. Matrixes not the same!");
            }
            else
            {
                for (int i = 0; i < first.GetHeight(); i++)
                {

                    for (int j = 0; j < first.GetWidth(); j++)
                    {
                        array1[i, j] = first[i, j] + second[i, j];
                    }
                }
            }
            MyMatrix resMass = new MyMatrix(array1);
            return resMass;
        }
        public static MyMatrix operator +(MyMatrix first, MyMatrix second)
        {
            return MyMatrix.Sum(first, second);
        }
        public static MyMatrix multiply(MyMatrix a, MyMatrix b)
        {
            double[,] array1 = new double[a.GetHeight(), b.GetWidth()];
            for (int i = 0; i < a.GetWidth(); i++)
            {
                for (int i1 = 0; i1 < b.GetWidth(); i1++)
                {
                    for (int i2 = 0; i2 < b.GetWidth(); i2++)
                    {
                        array1[i, i1] += a[i, i2] * b[i2, i1];
                    }
                }
            }
            MyMatrix resMass = new MyMatrix(array1);
            return resMass;
        }
        public static MyMatrix operator *(MyMatrix a, MyMatrix b)
        {
            return MyMatrix.multiply(a, b);
        }
        override public String ToString()
        {
            string line = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    line += matrix[i, j] + " ";
                }
                line += Environment.NewLine;
            }
            return line;
        }
        protected double[,] GetTransponedArray()
        {
            double[,] transponedArray = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    transponedArray[i, j] = matrix[j, i];
                }
            }
            return transponedArray;
        }
        public MyMatrix GetTransponedCopy()
        {
            MyMatrix result = new MyMatrix(GetTransponedArray());
            return result;
        }
        public void TransponeMe()
        {
            this.matrix = GetTransponedArray();
        }
    }
}