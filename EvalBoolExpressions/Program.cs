// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);


// string myValue = "a";
// Console.WriteLine(myValue != "a");


// string value1 = " a";
// string value2 = "A";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);


// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));


// int a = 7;
// int b = 6;
// Console.WriteLine(a != b);
// string s1 = "Hello";
// string s2 = "Hello";
// Console.WriteLine(s1 != s2);


// int orderAmount = 1001;
// Console.WriteLine($"Discount: {(orderAmount > 1000 ? 100 : 50)}");


// Random random = new Random();
// Console.WriteLine($"{(random.Next(0, 2) == 0 ? "Heads" : "Tails")}");


string permission = "Admin|Manager";
int level = 53;

Console.WriteLine(permission.Contains("Admin") && level > 55
    ? "Welcome, Super Admin user."
    : permission.Contains("Admin")
        ? "Welcome, Admin user."
        : permission.Contains("Manager") && level > 20
            ? "Contact an Admin for access."
            : "You do not have sufficient privileges.");