// using System.Text.Json
// Is in another file (here GlobalUsings.cs) using global keyword
// Or
// .csproj
//   <ItemGroup Condition="'$(ImplicitUsings)' == 'enable'">
//    < Using Include = "System.Text.Json" />
//   </ItemGroup>


var person = new Person( "John", "Doe" );

var json = JsonSerializer.Serialize( person, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase } ); 

Console.WriteLine( json );

public record Person( string FirstName, string LastName );
