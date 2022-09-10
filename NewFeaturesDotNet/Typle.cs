namespace NewFeaturesDotNet;

public class Typle
{
    public void Init()
    {
        int x = 10, y = 20;
        Console.WriteLine(x);
        Console.WriteLine(y);
        (x, y) = (y, x);
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}