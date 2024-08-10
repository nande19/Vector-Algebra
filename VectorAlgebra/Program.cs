using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorAlgebra
{
    public class Program
    {
        static void Main(string[] args)
        {
            //2D arrays 
            int[,,] vector1 = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
            int[,,] vector2 = { { { 1, 1 }, { 1, 1 } }, { { 1, 1 }, { 1, 1 } } };

            //results are stored here 
            var added = Arrays.AddVector3D(vector1, vector2);
            var subtracted = Arrays.SubtractVector3D(vector1, vector2);
            var multiplied = Arrays.ScalarMultiplyVector3D(vector1, 2);

            //printing the results
            Console.WriteLine("Addition Result:");
            PrintVector(added);
            Console.WriteLine("Subtraction Result:");
            PrintVector(subtracted);
            Console.WriteLine("Scalar Multiplication Result:");
            PrintVector(multiplied);
        }

        //takes 3D integear array and prints it
        static void PrintVector(int[,,] vector)
        {
            int x = vector.GetLength(0);
            int y = vector.GetLength(1);
            int z = vector.GetLength(2);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write(vector[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
       
    }
}
