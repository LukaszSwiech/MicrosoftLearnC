Console.WriteLine("Signed integral types:");
Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");
Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");
Console.WriteLine($"uint: {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong: {ulong.MinValue} to {ulong.MaxValue}");
Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"byte: {byte.MinValue} to {byte.MaxValue}");


Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// Reference types

int[] data;
data = new int[3];


int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");

//resist the temptation to guess at the parts of your code, including the selection of data types that may impact your application's performance.
// SQL Server's type system is different from C#'s type system. As a result, some mapping between the two must happen before you can save data into that database.

// If your application's purpose is to interface with a database, then you would likely need to consider how the data is stored and how much data is stored. The choice of a larger data type might impact the amount (and cost) of the physical storage required to store all the data your application will generate.