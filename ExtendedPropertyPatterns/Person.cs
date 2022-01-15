namespace ExtendedPropertyPatterns;

public class Person
{
    public string FirstName { get; set; } = "John";
    public string LastName { get; set; } = "Doe";
    public Country? Country { get; set; }
    public int Age { get; set; } = 22;
}


public class Country
{
    public string Name { get; set; } = "Canada";
    public string Code { get; set; } = "CA";
}

