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

        result[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        result[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        result[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        return result;
    }
}
