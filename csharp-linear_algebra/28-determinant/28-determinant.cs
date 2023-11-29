using System;

public class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is 2D or 3D
        if (rows != cols || (rows != 2 && rows != 3))
        {
            // Return -1 if the matrix is not 2D or 3D
            return -1;
        }

        double determinant = 0;

        if (rows == 2)
        {
            determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else if (rows == 3)
        {
            determinant = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                          matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                          matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        }

        return determinant;
    }
}
