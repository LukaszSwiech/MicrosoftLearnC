// bool flag = true;
// int value;

// if (flag)
// {
//     value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }

// Console.WriteLine($"Outside the code block: {value}");


// int value;

// if (true)
// {
//     value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }

// Console.WriteLine($"Outside the code block: {value}");


// string name = "John";

// if (name == "Steve")
//     Console.WriteLine("Found Steve");
// else if (name == "John")
//     Console.WriteLine("Found John");
// else
//     Console.WriteLine("Found someone else");


int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = false;
int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
       found = true;
}

if (found) 
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");