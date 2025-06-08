string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
string sentence = string.Empty;

//foreach (string myString in myStrings)

for (int i = 0; i < myStrings.Length; i++)
{
    periodLocation = myStrings[i].IndexOf(".");

    while (periodLocation != -1)
    {
        sentence = myStrings[i].Substring(0, periodLocation).Trim();
        myStrings[i] = myStrings[i].Remove(0, periodLocation + 1);
        Console.WriteLine(sentence);
        periodLocation = myStrings[i].IndexOf('.');
    }

    sentence = myStrings[i].Trim();
    Console.WriteLine(sentence);
}