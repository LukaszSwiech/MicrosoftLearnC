int heroHealth = 10;
int monsterHealth = 10;
int heroAttack;
int monsterAttack;

Random random = new Random();

do
{
    heroAttack = random.Next(1, 5);
    monsterAttack = random.Next(1, 5);

    monsterHealth -= heroAttack;
    Console.WriteLine($"Hero attacks monster for {heroAttack} damage. Monster heatlh: {monsterHealth}");
    if (monsterHealth <= 0)
        continue;

    heroHealth -= monsterAttack;
    Console.WriteLine($"Monster attacks hero for {monsterAttack} damage. Hero health: {heroHealth}");


} while (monsterHealth > 0 && heroHealth > 0);

Console.WriteLine(monsterHealth <= 0 ? "Hero wins!" : "Monster wins!");
Console.ReadLine();