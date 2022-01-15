namespace RecordStructs;

// record struct
// readonly record struct


public readonly record struct Measurement
{
    // New : Parameterless constructors (Must assigned values)
    public Measurement()
    {
        Value = 1;
        Description = "Aa";
        // MutableDescription = String.Empty;
    }

    public Measurement( int value )
    {
        Value = value;
        Description = String.Empty;
        // MutableDescription = String.Empty;
    }


    public readonly int Value { get; init; }
    public readonly string Description { get; init; }
    // public string MutableDescription { get; set; }
}


// Note : Assume class
public record Person( string FirstName, string LastName );
// or we can be explicite and using the class keyword
public record class PersonExplicit( string FirstName, string LastName );