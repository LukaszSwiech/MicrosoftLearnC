for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
    if (i == 6)
        break;
}// 


string[] names = { "Alice", "Bob", "Charlie", "David" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }


//foreach (var name in names)
for (int i = 0; i < names.Length; i++)
{
    // for each error: Cannot assign to 'name' because it is a 'foreach iteration variable'
    if (names[i] == "David")
        names[i] = "Sammy";
}

foreach (var name in names)
    Console.WriteLine(name);


for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
        Console.WriteLine(i + " - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine(i + " - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine(i + " - Buzz");
    else
        Console.WriteLine(i);
}