namespace NewFeaturesDotNet;

public class Range
{
    public void Init()
    {
        var arr = new[] { 1, 3, 5 };
        // create allocation
        var range = arr[1..];
    }

}