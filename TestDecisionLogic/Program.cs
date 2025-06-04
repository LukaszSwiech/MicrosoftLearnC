Random dice = new();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;


if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! Extra points for you!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! Extra points for you!");
        total += 2;
    }

}
else if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
{
    Console.WriteLine("You rolled triples! Extra points for you!");
    total += 6;
}

Console.WriteLine($"You rolled a {roll1}, a {roll2}, and a {roll3}. Total: {total}.");

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win an used car!");
}
else if (total >= 5)
{
    Console.WriteLine("You win a new bike!");
}
else
{
    Console.WriteLine("You win an used bike!");
}
