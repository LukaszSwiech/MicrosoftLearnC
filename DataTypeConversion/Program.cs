// EXERCISE 1: String to Decimal Conversion
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal results = 0m;
string finalString = "";
foreach (string value in values)
{
    if (decimal.TryParse(value, out decimal result))
    {
        results += result;
    }
    else
    {
        finalString += value;
    }
}
Console.WriteLine($"Sum of valid numbers: {results}");
Console.WriteLine($"Invalid values concatenated: {finalString}");


//EXERCISE 2: Data Type Conversion
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32(value1 / value2); // Convert the result of division to int
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3; // Convert the result of division to decimal
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// TRAINING MATERIAL

// int first = 2;
// string second = "4";
// int results = first + second;
// Console.WriteLine(results);

// error CS0029: Cannot implicitly convert type 'string' to 'int'


// int first = 2;
// string second = "4";
// string results = first + second; // safe conversion to string
// Console.WriteLine(results);


// int myInt = 3;
// Console.WriteLine($"myInt: {myInt}");
// decimal myDecimal = myInt; // int fits into decimal
// Console.WriteLine($"decimal: {myDecimal}");


// decimal myDecimal2 = 3.14m;
// Console.WriteLine($"decimal: {myDecimal2}");
// int myInt2 = (int)myDecimal2; // explicit conversion from decimal to int - casting
// Console.WriteLine($"int: {myInt2}");


// decimal myDecimal3 = 1.23456789m;
// Console.WriteLine($"decimal: {myDecimal3}");
// float myFloat = (float)myDecimal3; // explicit conversion from decimal to float - casting
// Console.WriteLine($"float: {myFloat}");


// int firstInt = 5;
// int secondInt = 7;
// string message = firstInt.ToString() + secondInt.ToString();
// Console.WriteLine(message);


// string firstString = "5";
// string secondString = "7";
// int sum = int.Parse(firstString) + int.Parse(secondString); // parsing strings to integers
// Console.WriteLine(sum);


// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) + Convert.ToInt32(value2); // using Convert class
// Console.WriteLine(result);


// int value = (int)1.5m; // will ignore the decimal part
// Console.WriteLine(value);
// int sameValue = Convert.ToInt32(1.5m); // will round the value
// Console.WriteLine(sameValue);

// STRING TO INT 1
//string name = "Bob";
//Console.WriteLine(int.Parse(name)); // will throw an exception because "Bob" cannot be converted to int

// string stringValue = "123";
// int stringToIntResults = 0;
// if (int.TryParse(stringValue, out stringToIntResults)) // returns true if conversion is successful
// {
//     Console.WriteLine($"Conversion successful: {stringToIntResults}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// // STRING TO INT 2
// string stringValue = "123";
// int stringToIntResults = 0;
// if (int.TryParse(stringValue, out stringToIntResults)) // returns true if conversion is successful
// {
//     Console.WriteLine($"Measurement: {stringToIntResults}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }
// Console.WriteLine($"Measurement (w/ offset): {50 + stringToIntResults}");


// // STRING TO INT 3
// string value = "bad value";
// int result = 0;
// if (int.TryParse(value, out result)) // returns false if conversion fails
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }
// if (result > 0)
//    Console.WriteLine($"Measurement (w/ offset): {50 + result}");


