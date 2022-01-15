using RecordStructs;

var m1 = new Measurement();
Console.WriteLine( $"{m1.Value} | {m1.Description}" ); // 1 | Aa
Console.WriteLine( m1.ToString() );

// m1.Value = 2; // Wrong: Readonly value

var m2 = default(Measurement);
Console.WriteLine( $"{m2.Value} | {m2.Description}" ); // 0 | ""


// New in C#10 : with
var m3 = m1 with { Value = 2 };
Console.WriteLine( m3 );