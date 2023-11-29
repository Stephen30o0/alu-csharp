using System;

public class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        // Check if both vectors are 3D
        if (vector1.Length != 3 || vector2.Length != 3)
        {
            // Return a vector containing -1 if either vector is not 3D
            return new double[] { -1 };
        }

        double[] result = new double[3];

        double i = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        double j = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        double k = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        if (i == 0 && j == 0 && k == 0)
        {
            // If the result is a zero vector, return a zero vector
            return new double[] { 0, 0, 0 };
        }

        result[0] = i;
        result[1] = j;
        result[2] = k;

        return result;
    }
}
