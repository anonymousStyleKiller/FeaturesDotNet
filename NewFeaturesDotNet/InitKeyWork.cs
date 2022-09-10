namespace NewFeaturesDotNet;

public class InitKeyWork
{
    public void M()
    {
        var p = new Person()
        {
            Name = "Anton",
            Surname = "Kharhcenko"
        };
        // Hear will be error
        // p.Name = "new";
        p.Surname = "Good";
    }
   
}

public class Person
{
    public string Name { get; init; }
    public string Surname { get; set; }
}