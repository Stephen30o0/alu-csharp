using System;

public class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        int dimensions1 = vector1.Length;
        int dimensions2 = vector2.Length;

        if ((dimensions1 != 2 && dimensions1 != 3) || (dimensions2 != 2 && dimensions2 != 3) || (dimensions1 != dimensions2))
        {
            // Return a vector containing -1 if vectors are not 2D or 3D or if they are not of the same size
            return new double[] { -1 };
        }

        double[] result = new double[dimensions1];
        for (int i = 0; i < dimensions1; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }

        return result;
    }
}
