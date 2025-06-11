string[] pallets = ["B14", "A10", "B12", "A13"];
Console.WriteLine("Sorted...");
Array.Sort(pallets); // Sorts the array in ascending order
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets); // Reverses the order of the elements in the array
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2); // Clears the first two elements of the array
if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}"); // The first element is now null after clearing and will throw an exception
Console.WriteLine($"Cleared 2 .. count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6); // Resizes the array to a new length
Console.WriteLine($"Resizing 6 .. count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// to remove a null value from the array, you need to count the number of non-null elements and create a new array with that size. Loop the original array and copy the non-null elements to the new array.


string value = "abc123";
char[] valueArray = value.ToCharArray(); // Converts the string to a character array
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = string.Join("-", valueArray); // Joins the characters into a string with commas
Console.WriteLine(result);

string[] items = result.Split('-'); // Splits the string into an array using the hyphen as a delimiter
foreach (string item in items)
{
    Console.WriteLine(item);
}

// EXERCISE1 : Complete a challenge to reverse words in a sentence

string panagram = "The quick brown fox jumps over the lazy dog";
string[] panagramWords = panagram.Split(' ');
string reversedSentence = "";

foreach (string word in panagramWords)
{
    char[] wordArray = word.ToCharArray();
    Array.Reverse(wordArray);
    string reversedWord = new string(wordArray);
    reversedSentence += string.Join(" ", reversedWord) + " ";
}

Console.WriteLine($"Reversed sentence: {reversedSentence}");


// EXERCISE2 : Complete a challenge to parse a string of orders, sort the orders and tag possible errors

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(',');
Array.Sort(orders);
foreach (string order in orders)
{
    if (order.Length != 4)
    {
        Console.WriteLine($"{order}\t- Error");
    }
    else
    {
        Console.WriteLine($"{order}");
    }
}