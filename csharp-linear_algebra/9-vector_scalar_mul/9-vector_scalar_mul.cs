using System;

public class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        int dimensions = vector.Length;

        if (dimensions != 2 && dimensions != 3)
        {
            // Return a vector containing -1 if the vector is not 2D or 3D
            return new double[] { -1 };
        }

        double[] result = new double[dimensions];
        for (int i = 0; i < dimensions; i++)
        {
            result[i] = vector[i] * scalar;
        }

        return result;
    }
}
