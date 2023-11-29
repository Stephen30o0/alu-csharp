using System;

public class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        int dimensions1 = vector1.Length;
        int dimensions2 = vector2.Length;

        if ((dimensions1 != 2 && dimensions1 != 3) || (dimensions2 != 2 && dimensions2 != 3) || (dimensions1 != dimensions2))
        {
            // Return -1 if vectors are not 2D or 3D or if they are not of the same size
            return -1;
        }

        double dotProduct = 0;
        for (int i = 0; i < dimensions1; i++)
        {
            dotProduct += vector1[i] * vector2[i];
        }

        return dotProduct;
    }
}
