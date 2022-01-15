
// Func
var func = () => "some value";
Console.WriteLine( func() );

// instead of
// Func<string> func = () => "some value";


var func2 = string? ( int a ) => a < 5 ? "less than five" : null;
Console.WriteLine( func2( 6 ) is null ? "is null" : "is not null" );

// instead of
// Func<int, string?>? func3 = string? ( int a ) => a < 5 ? "less than five" : null;


// Action
var action = ( int a ) => Console.WriteLine( $"the int is {a}");
action( 3 );

// instead of
// Action<int> action = ( int a ) => Console.WriteLine( $"the int is {a}");
