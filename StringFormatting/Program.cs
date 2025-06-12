// Exercise - Complete a challenge to apply string interpolation to a form letter

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine("Dear {0},", customerName);
Console.WriteLine("As a customer of our {0} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n", currentProduct);
Console.WriteLine($"Currently, you own {currentShares:N2} shares at reutrn of {currentReturn:P2}.\n");
Console.WriteLine($"Our new productm {newProduct} offers a return of {newReturn:P2}. Given your current volme, your potential profil would be {newProfit:C2}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";
comparisonMessage += currentProduct.PadRight(20);
comparisonMessage += $"{currentReturn:P2}".PadRight(10);
comparisonMessage += $"{currentProfit:C2}".PadLeft(10);
comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += $"{newReturn:P2}".PadRight(10);
comparisonMessage += $"{newProfit:C2}".PadLeft(10);


Console.WriteLine(comparisonMessage);


// LEARNING MATERIALS

// string first = "Hello";
// string second = "World";
// string result = string.Format("{1} {0}!", first, second);
// Console.WriteLine(result);
// Console.WriteLine("{0} {0} {0}!", first, second);

// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");


// // decimal price = 123.45m;
// // int discount = 50;
// // Console.WriteLine($"Pirce: {price:C} (Save {discount:C})");


// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N1} units");


// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");


// decimal price = 67.55m;
// decimal salePrice = 59.99m;
// string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price!", (price - salePrice), price);

// yourDiscount += $" A discount of {((price - salePrice) / price):P2}!";
// Console.WriteLine(yourDiscount);


// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"    Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"          Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");


// //Padding and alignment

// string one = "Hello";
// string two = "World";
// string sumString = string.Format("{0} {1}!", one, two);
// Console.WriteLine(sumString);


// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));


// string paymentId = "769C";
// string payeeName = "John Deer";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);
// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

