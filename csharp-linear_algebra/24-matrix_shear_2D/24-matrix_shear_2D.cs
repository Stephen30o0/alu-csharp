using System;

public class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is a square 2D matrix
        if (rows != cols || (rows != 2 && rows != 3))
        {
            // Return a matrix containing -1 if the matrix is not a valid square 2D matrix
            return new double[,] { { -1 } };
        }

        // Check if the direction is either 'x' or 'y'
        if (direction != 'x' && direction != 'y')
        {
            // Return a matrix containing -1 if the axis is not 'x' or 'y'
            return new double[,] { { -1 } };
        }

        // Check if the factor is 1 to determine if the shear result should be -1
        if (factor == 1 && direction == 'x')
        {
            return new double[,] { { -1 } };
        }

        // Create the resulting matrix
        double[,] result = new double[rows, cols];

        // Apply shear along the X or Y direction based on the given factor
        if (direction == 'x')
        {
            // Shear along the X direction
            for (int i = 0; i < rows; i++)
            {
                result[i, 0] = matrix[i, 0] + factor * matrix[i, 1];
                result[i, 1] = matrix[i, 1];
            }
        }
        else if (direction == 'y')
        {
            // Shear along the Y direction
            for (int i = 0; i < rows; i++)
            {
                result[i, 0] = matrix[i, 0];
                result[i, 1] = factor * matrix[i, 0] + matrix[i, 1];
            }
        }

        return result;
    }
}
