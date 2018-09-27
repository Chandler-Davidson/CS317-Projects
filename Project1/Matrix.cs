﻿using System;
using System.Collections.Generic;

namespace Project1
{
    /// <summary>
    /// 2D List collection that represents a matrix.
    /// </summary>
    public class Matrix<T> : List<List<T>>
        where T : IComparable<T>
    {
        /// <summary>
        /// The number of comparisons made.
        /// </summary>
        /// <value>The comparison count.</value>
        public int ComparisonCount { get; set; }

        /// <summary>
        /// The number of assignments made.
        /// </summary>
        /// <value>The assignment count.</value>
        public int AssignmentCount { get; set; }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:Project1.Matrix`1"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:Project1.Matrix`1"/>.</returns>
        public override string ToString()
        {
            var str = "";
            foreach (var row in this)
            {
                foreach (var number in row)
                {
                    str += number.ToString().PadRight(8);
                }

                str += Environment.NewLine + Environment.NewLine;
            }

            return str;
        }

        /// <summary>
        /// Generates a comprehensive report of the matrix.
        /// </summary>
        /// <returns>The report.</returns>
        public string GenerateReport()
        {
            return
                "Matrix generated by: Method 1.\n" +
                $"Data type: {typeof(T).Name}\n" +
                $"Comparisons made: {ComparisonCount}\n" +
                $"Assignments made: {AssignmentCount}\n" +
                $"Matrix:\n\n{this}"; 
        }

        public static Matrix<T> operator ++ (Matrix<T> matrix)
        {
            matrix.ComparisonCount += 1;
            return matrix;
        }
    }
}
