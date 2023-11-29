using System;

public class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows == 0 || cols == 0)
        {
            // Return an empty matrix if the input matrix is empty
            return new double[,] { };
        }

        double[,] result = new double[cols, rows];

        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                result[i, j] = matrix[j, i];
            }
        }

        return result;
    }
}
