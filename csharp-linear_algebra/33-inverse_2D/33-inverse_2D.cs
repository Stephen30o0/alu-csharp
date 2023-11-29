using System;

public class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is a 2x2 matrix
        if (rows != 2 || cols != 2)
        {
            // Return [-1] if the matrix is not 2D
            return new double[,] { { -1 } };
        }

        double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        // Check if the matrix is non-invertible (determinant equals zero)
        if (determinant == 0)
        {
            // Return [-1] for non-invertible matrix
            return new double[,] { { -1 } };
        }

        double[,] inverseMatrix = new double[2, 2];

        inverseMatrix[0, 0] = matrix[1, 1] / determinant;
        inverseMatrix[0, 1] = -matrix[0, 1] / determinant;
        inverseMatrix[1, 0] = -matrix[1, 0] / determinant;
        inverseMatrix[1, 1] = matrix[0, 0] / determinant;

        return inverseMatrix;
    }
}
