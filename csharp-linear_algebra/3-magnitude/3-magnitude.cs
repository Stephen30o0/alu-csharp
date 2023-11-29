using System;

public class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        int dimensions = vector.Length;

        if (dimensions != 2 && dimensions != 3)
        {
            return -1; // Return -1 for vectors that are not 2D or 3D
        }

        double sumOfSquares = 0;
        foreach (double component in vector)
        {
            sumOfSquares += Math.Pow(component, 2);
        }

        double magnitude = Math.Sqrt(sumOfSquares);
        // Round the magnitude to the nearest hundredth
        magnitude = Math.Round(magnitude, 2);

        return magnitude;
    }

    public static void Main(string[] args)
    {
        double[] vector2D = { 3.0, 4.0 }; // Example 2D vector
        double[] vector3D = { 1.0, 2.0, 3.0 }; // Example 3D vector
        double[] invalidVector = { 1.0, 2.0, 3.0, 4.0 }; // Example invalid vector

        Console.WriteLine("Magnitude of 2D vector: " + Magnitude(vector2D));
        Console.WriteLine("Magnitude of 3D vector: " + Magnitude(vector3D));
        Console.WriteLine("Magnitude of invalid vector: " + Magnitude(invalidVector));
    }
}
