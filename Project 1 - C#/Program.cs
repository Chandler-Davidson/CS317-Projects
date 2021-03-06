﻿using System;
using System.IO;

namespace Project1
{
    class Program
    {
        static void Main()
        {
            // Read matrix in from file
            var parser = new Parser<double>();
            var matrix = parser.ParseFile();

            // Sort each row of the matrix
            var matrix1 = matrix.SortMatrix(MatrixSorter.SortingMethod1);
            var matrix2 = matrix.SortMatrix(MatrixSorter.SortingMethod2);

            Console.WriteLine(matrix);
            Console.WriteLine(matrix1);
            Console.WriteLine(matrix2);

            // Write the contents of each matrix to file
            File.WriteAllText("cmd0031_1.txt", matrix1.GenerateReport());
            File.WriteAllText("cmd0031_2.txt", matrix2.GenerateReport());
        }
    }
}
