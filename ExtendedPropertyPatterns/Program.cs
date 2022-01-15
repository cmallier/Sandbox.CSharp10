using ExtendedPropertyPatterns;

var person = new Person()
{
    FirstName = "Abraham",
    LastName = "Lincoln",
    Age = 22,
    Country = new Country() { Name = "USA", Code = "US" }
};


if( person is Person { Country.Name: "USA" } )
{
    Console.WriteLine( "Is a U.S. citizen" );
}

if( person is { FirstName: "Abraham", Age: <= 22, Country.Code: "US" } )
{
    Console.WriteLine( "Probably Lincoln" );
}


/*

Equivalent to 
if( person is Person { Country: { Name: "USA" } } )

*/