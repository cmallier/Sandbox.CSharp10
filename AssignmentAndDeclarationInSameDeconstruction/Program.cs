var person = new Person( "John", "Doe" );


// New in C#10
string fn = "";
(fn, string ln) = person;

Console.WriteLine( $"{fn} {ln}" );


// instead of
// var (fn, ln) = person;
// (string fn, string ln) = person;


public record Person( string FirstName, string LastName );