// // CODE PROJECT 1: write code that validates integer input

// string? userInput;
// bool validNumber;
// bool acceptedValue = false;

// Console.WriteLine("Please enter a number between 5 and 10:");

// do
// {
//     userInput = Console.ReadLine();
//     validNumber = int.TryParse(userInput, out int numericValue);

//     if (validNumber)
//     {
//         if (numericValue >= 5 && numericValue <= 10)
//         {
//             Console.WriteLine($" Your number ({numericValue}) is valid.");
//             acceptedValue = true;
//         }
//         else
//         {
//             Console.WriteLine($"You enterer {numericValue}, which is not in the range of 5 to 10. Please try again.");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Invalid number, please try again.");
//     }


// } while (!acceptedValue);


// CODE PROJECT 2:  write code that validates string input


string? userInput;
bool validString = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User):");

do
{
    userInput = Console.ReadLine();

    if (userInput == "Administrator" || userInput == "Manager" || userInput == "User")
    {
        validString = true;
        Console.WriteLine($"Your role ({userInput}) has been accepted.");
    }
    else
    {
        Console.WriteLine("Invalid role name, please try again.");
    }

} while (!validString);