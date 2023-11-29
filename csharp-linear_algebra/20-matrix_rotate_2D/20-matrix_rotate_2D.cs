using System;

public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols || rows < 2)
        {
            // Return a matrix containing -1 if the matrix is not a valid square 2D matrix
            return new double[,] { { -1 } };
        }

        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double x = i - rows / 2.0;
                double y = j - cols / 2.0;

                // Apply rotation transformation
                double newX = x * cosAngle - y * sinAngle + rows / 2.0;
                double newY = x * sinAngle + y * cosAngle + cols / 2.0;

                // Interpolate the rotated value from the original matrix
                result[i, j] = Interpolate(matrix, newX, newY);
            }
        }

        return result;
    }

    private static double Interpolate(double[,] matrix, double x, double y)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int x1 = (int)Math.Floor(x);
        int x2 = Math.Min(x1 + 1, rows - 1);
        int y1 = (int)Math.Floor(y);
        int y2 = Math.Min(y1 + 1, cols - 1);

        double q11 = matrix[x1, y1];
        double q21 = matrix[x2, y1];
        double q12 = matrix[x1, y2];
        double q22 = matrix[x2, y2];

        double value = ((x2 - x) * (y2 - y) * q11 + (x - x1) * (y2 - y) * q21 +
                        (x2 - x) * (y - y1) * q12 + (x - x1) * (y - y1) * q22);

        return value;
    }
}
