namespace NewFeaturesDotNet;

public class Tuple
{
    public void Init()
    {
        int x = 10, y = 20;
        Console.WriteLine(x);
        Console.WriteLine(y);
        (x, y) = (y, x);
        Console.WriteLine(x);
        Console.WriteLine(y);

        var rect = new Rectangle(1,2,3,4);
        var (x1, x2, _, _) = (rect with{x = 10});
    }
}

internal record Rectangle(int x, int y, int h, int z)
{
    public void Deconstruct(out int x1, out int x2) => (x1, x2) = (x, y);
}