﻿/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
  Console.WriteLine(orderID);
}

//intendations, spacing and blank lines

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"\n\nDice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{

  if ((roll1 == roll2) && (roll2 == roll3))
  {
    Console.WriteLine("You rolled triples!  +6 bonus to total!");
    total += 6;
  }
  else
  {
    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
    total += 2;
  }
}

/* 
The following code converts a string message
into a char array, reverses the characters,
counts the number of 'o's in the reversed
message, converts it back to a string, and
prints the reversed message along with the
count of 'o's.
*/

string str = "The quick brown fox jumps over the lazy dog.";

char[] originalMessage = str.ToCharArray();
Array.Reverse(originalMessage);

int letterCount = 0;

foreach (char letter in originalMessage)
{
  if (letter == 'o')
  {
    letterCount++;
  }
}

string newMessage = new String(originalMessage);

Console.WriteLine($"\n\n{newMessage}");
Console.WriteLine($"'o' appears {letterCount} times.");