using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2910
{
    class Matrix
    {
        private int[,] matrix;
        private int rows;
        private int columns;

        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
            Rows = matrix.GetLength(0);
            Columns = matrix.GetLength(1);
        }
        public Matrix(int rows, int cols)
        {
            this.matrix = new int[rows, cols];
            Rows = matrix.GetLength(0);
            Columns = matrix.GetLength(1);
        }

        public int Rows
        {
            get { return rows; }
            private set { rows = value; }
        }
        public int Columns
        {
            get { return columns; }
            private set { columns = value; }
        }


        public int this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= Rows)
                {
                    throw new Exception("Invalid row index");
                }
                else if (col < 0 || col >= Columns)
                {
                    throw new Exception("Invalid col index");
                }
                else
                {
                    return matrix[row, col];
                }
            }
            set
            {
                if (row < 0 || row >= Rows)
                {
                    throw new Exception("Invalid row index");
                }
                else if (col < 0 || col >= Columns)
                {
                    throw new Exception("Invalid col index");
                }
                else
                {
                    matrix[row, col] = value;
                }
            }
        }

        public static Matrix operator +(Matrix other, Matrix other1)
        {
            if (other.matrix.GetLength(0) != other1.Rows || other.Columns != other1.Columns)
            {
                throw new Exception("Matrices must be the same size");
            }
            else
            {
                Matrix result = new Matrix(other.Rows, other1.Columns);
                for (int i = 0; i < other.Rows; i++)
                {
                    for (int j = 0; j < other1.Columns; j++)
                    {
                        result[i, j] = other[i, j] + other1[i, j];
                    }
                }
                return result;
            }
        }

        public static Matrix operator -(Matrix other, Matrix other1)
        {
            if (other.Rows != other1.Rows || other.Columns != other1.Columns)
            {
                throw new Exception("Matrices must be the same size");
            }
            else
            {
                Matrix result = new Matrix(other.Rows, other1.Columns);
                for (int i = 0; i < other.Rows; i++)
                {
                    for (int j = 0; j < other.Columns; j++)
                    {
                        result[i, j] = other[i, j] - other1[i, j];
                    }
                }
                return result;
            }
        }

        public static Matrix operator *(Matrix other, Matrix other1)
        {
            if (other.Columns != other1.Rows)
            {
                throw new Exception("Matrices must be compatible for multiplication");
            }
            else if (other.Rows != other1.Columns)
            {
                throw new Exception("Matrices must be compatible for multiplication");
            }
            else
            {
                Matrix result = new Matrix(other.Rows, other1.Columns);

                for (int i = 0; i < other.Rows; i++)
                {
                    for (int j = 0; j < other1.Columns; j++)
                    {
                        for (int k = 0; k < other.Rows; k++)
                        {
                            result[i, j] += other[i, k] * other1[k, j];
                        }
                    }
                }

                return result;
            }
        }

        public static Matrix operator *(Matrix other, int num)
        {
            Matrix result = new Matrix(other.Rows, other.Columns);

            for (int i = 0; i < other.Rows; i++)
            {
                for (int j = 0; j < other.Columns; j++)
                {
                    result[i, j] = other[i, j] * num;
                }
            }
            return result;
        }

        public static bool operator ==(Matrix other, Matrix other1)
        {
            return (other.ToString() == other1.ToString());
        }
        public static bool operator !=(Matrix other, Matrix other1)
        {
            return !(other.ToString() == other1.ToString());
        }

        public override string ToString()
        {
            string[] result = new string[Rows * Columns + Rows];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    result[i * (Columns + 1) + j] = matrix[i, j].ToString() + " ";
                }
                result[i * (Columns +1) + Columns] = "\n"; 
            }
            return String.Join("", result);
        }

        public override bool Equals(object? obj)
        {
            return (this.ToString() == obj?.ToString());
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void RandomNums()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrix[i, j] = new Random().Next(0, 10);
                }
            }
        }

        private int MinMax(bool choose)
        {
            int num = matrix[0, 0];
            if (choose == false)
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (matrix[i, j] < num)
                        {
                            num = matrix[i, j];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (matrix[i, j] > num)
                        {
                            num = matrix[i, j];
                        }
                    }
                }
            }
            return num;
        }

        public int Max()
        {
            return MinMax(true);
        }

        public int Min()
        {
            return MinMax(false);
        }
    }
}