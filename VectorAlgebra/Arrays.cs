using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorAlgebra
{
    public class Arrays
    {
        //adds corresponding elements of two 3D vectors and returns the results
        public static int[,,] AddVector3D(int[,,] vector1, int[,,] vector2)
        {
            // Check if the vectors are of the same size
            if (vector1.GetLength(0) != vector2.GetLength(0) ||
                vector1.GetLength(1) != vector2.GetLength(1) ||
                vector1.GetLength(2) != vector2.GetLength(2))
            {
                throw new ArgumentException("Vectors must be of the same size.");
            }

            int x = vector1.GetLength(0);
            int y = vector1.GetLength(1);
            int z = vector1.GetLength(2);
            int[,,] result = new int[x, y, z];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        result[i, j, k] = vector1[i, j, k] + vector2[i, j, k];
                    }
                }
            }

            return result;
        }

        //subtracts corresponding elements of two 3D vectors and returns the resulting vector
        public static int[,,] SubtractVector3D(int[,,] vector1, int[,,] vector2)
        {
            // Check if the vectors are of the same size
            if (vector1.GetLength(0) != vector2.GetLength(0) ||
                vector1.GetLength(1) != vector2.GetLength(1) ||
                vector1.GetLength(2) != vector2.GetLength(2))
            {
                throw new ArgumentException("Vectors must be of the same size.");
            }

            int x = vector1.GetLength(0);
            int y = vector1.GetLength(1);
            int z = vector1.GetLength(2);
            int[,,] result = new int[x, y, z];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        result[i, j, k] = vector1[i, j, k] - vector2[i, j, k];
                    }
                }
            }

            return result;
        }

        //multiplies each element of a 3D vector by a scalar and returns the resulting vector   
        public static int[,,] ScalarMultiplyVector3D(int[,,] vector, int multiplier)
        {
            int x = vector.GetLength(0);
            int y = vector.GetLength(1);
            int z = vector.GetLength(2);
            int[,,] result = new int[x, y, z];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        result[i, j, k] = vector[i, j, k] * multiplier;
                    }
                }
            }

            return result;
        }


    }
}
