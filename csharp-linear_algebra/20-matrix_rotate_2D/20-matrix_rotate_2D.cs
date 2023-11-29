using System;

public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is a square 2D matrix
        if (rows != cols || (rows != 2 && rows != 3))
        {
            // Return a matrix containing -1 if the matrix is not a valid square 2D matrix
            return new double[,] { { -1 } };
        }

        // Create the resulting matrix
        double[,] result = new double[rows, cols];

        // Iterate through the matrix elements
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Apply rotation to each element value in the matrix
                double x = matrix[i, j] * Math.Cos(angle) - matrix[i, j + 1] * Math.Sin(angle);
                double y = matrix[i, j] * Math.Sin(angle) + matrix[i, j + 1] * Math.Cos(angle);

                // Assign the rotated value to the resulting matrix
                result[i, j] = x;
                result[i, j + 1] = y;
            }
        }

        return result;
    }
}
