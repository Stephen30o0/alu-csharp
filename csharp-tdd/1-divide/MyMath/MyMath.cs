using System;

namespace MyMath
{
    /// <summary>
    /// Provides mathematical operations on matrices.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divide all elements of a matrix by a specified number.
        /// </summary>
        /// <param name="matrix">The input matrix to divide.</param>
        /// <param name="num">The number to divide all elements by.</param>
        /// <returns>A new matrix containing divided elements.</returns>
        /// <remarks>
        /// If num is 0, this method will print "Num cannot be 0" and return null.
        /// If the input matrix is null, it returns null.
        /// </remarks>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            if (matrix == null)
                return null;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] / num;
                }
            }

            return result;
        }
    }
}
