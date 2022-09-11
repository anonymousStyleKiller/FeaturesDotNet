namespace NewFeaturesDotNet;

public static class PatternMatching
{
    public static void IsSpecificTriangle(Triangel triangel)
    {
        if (triangel is Triangel { Base: 8, Height: 8 } tri)
        {
            Console.WriteLine();
        }    
        
        
        if (triangel is Triangel { Name: var x } tri2)
        {
            Console.WriteLine();
        }   
    }


    public static string ReturnDesc(string shape, int length)
    {
        return (shape, length) switch
        {
            ("Rect", 1) => "This is test",
            (_, _) => "Default",
        };
    }
}

public class Triangel
{
    public int Base { get; set; }
    public int Height { get; set; }
    public object Name { get; set; }
}

public class Test
{
    public void TestMethod()
    {
        int[] one = { 1 };
        Console.WriteLine(one is [1]);
    }
}



