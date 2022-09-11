namespace NewFeaturesDotNet;

public class ExWhen
{
    public void Test()
    {
        try
        {

        }
        catch (Exception e) when(e.HResult >1000_00)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}