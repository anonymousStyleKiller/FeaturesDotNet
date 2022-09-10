namespace NewFeaturesDotNet;

public static class PatternMatching
{
    public static void IsSpecificTriangle(Triangel triangel)
    {
        if (triangel is Triangel { Base: 8, Height: 8 } tri)
        {
            Console.WriteLine();
        }    
    }
}

public class Triangel
{
    public int Base { get; set; }
    public int Height { get; set; }
}

