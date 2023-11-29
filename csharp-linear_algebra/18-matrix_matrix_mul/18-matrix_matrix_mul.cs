using System;

public class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2 || (rows1 != 2 && rows1 != 3) || (cols1 != 2 && cols1 != 3) || (rows2 != 2 && rows2 != 3) || (cols2 != 2 && cols2 != 3))
        {
            // Return a matrix containing -1 if matrices cannot be multiplied
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows1, cols2];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }
}
