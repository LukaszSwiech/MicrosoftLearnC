// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPoisition = message.IndexOf(openSpan); // returns -1 if not found
// int closingPosition = message.IndexOf(closeSpan);

// openingPoisition += openSpan.Length; // Length of "<span>" is 6, 'avoid maginc number'

// int length = closingPosition - openingPoisition;
// Console.WriteLine(message.Substring(openingPoisition, length));


string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1; // Move past the '(' character
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));


while (true)
{
    int openingPoisition = message.IndexOf('(');
    if (openingPoisition == -1)
    {
        break; // No more opening parentheses found
    }

    openingPoisition += 1; // Move past the '(' character
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPoisition;
    Console.WriteLine(message.Substring(openingPoisition, length));

    message = message.Substring(closingPosition + 1); // Move past the closing parenthesis
}


// Work with different types of symbol sets with IndexOfAny()
Console.WriteLine($"\n\n");


string message2 = "Hello World!";
char[] charsToFind = { 'a', 'e', 'i' };

int index = message2.IndexOfAny(charsToFind);

Console.WriteLine($"Found ' {message2[index]}' in '{message2}' at index {index}.");


// Find opening symbols in a message using IndexOfAny()
Console.WriteLine($"\n\n");

string message3 = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message3}");

char[] openingSymbols = ['[', '{', '('];
int strartPosition = 5;

int openingPosition = message3.IndexOfAny(openingSymbols);
Console.WriteLine($"Found WITHOUT using start position: {message3.Substring(openingPosition)}");

openingPosition = message3.IndexOfAny(openingSymbols, strartPosition);
Console.WriteLine($"Found WITH using start position {strartPosition}: {message3.Substring(openingPosition)}");


// Find matching closing symbols in a message using IndexOfAny()
Console.WriteLine($"\n\n");


string message4 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition2 = 0;

while (true)
{
    int openingPosition2 = message4.IndexOfAny(openSymbols, closingPosition2);
    if (openingPosition2 == -1)
    {
        break; // No more opening symbols found
    }

    string currentSymbol = message4.Substring(openingPosition2, 1);
    char matchingSymbol = ' ';
    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string

    openingPosition2 += 1;
    closingPosition2 = message4.IndexOf(matchingSymbol, openingPosition2);

    // Finally, you can use the techniques you already learned to extract the substring

    int length = closingPosition2 - openingPosition2;
    Console.WriteLine(message4.Substring(openingPosition2, length));


}


// Use the Remove() and Replace() methods
Console.WriteLine($"\n\n");

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);


string message5 = "This--is--ex-amp-le--da-ta";
message5 = message5.Replace("--", " ");
message5 = message5.Replace("-", "");
Console.WriteLine(message5);


// Challenge to extract, replace, and remove data from an input string
// Desired output:
// Quantity: 5000
// Output: <h2>Widgets &reg;</h2><span>5000</span>
Console.WriteLine($"\n\n");
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = input;

int startIndex = input.IndexOf("<span>");
int endIndex = input.IndexOf("</span>");
int startIndexLength = "<span>".Length;
int endIndexLength = "</span>".Length;

int lengthQ = endIndex - startIndex;
quantity = "Quantity: " + input.Substring(startIndex + startIndexLength, lengthQ - endIndexLength + 1);
string[] removeStrings = ["<div>", "</div>"];
int[] removeStringsLengths = ["<div>".Length, "</div>".Length];
int divStartIndex;

for (int i = 0; i < removeStrings.Length; i++)
{
    divStartIndex = output.IndexOf(removeStrings[i]);
    output = output.Remove(divStartIndex, removeStringsLengths[i]);
}

output = "Output: " + output.Replace("&trade;", "&reg;");

Console.WriteLine(quantity);
Console.WriteLine(output);