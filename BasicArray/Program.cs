// string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];
// // fraudulentOrderIDs[3] = "D000";

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


// foreach (string order in fraudulentOrderIDs)
// {
//     Console.WriteLine($"Processing order: {order}");
// }


// int[] inventory = [200, 450, 700, 175, 250];
// int bin = 0;
// int sum = 0;
// foreach (int item in inventory)
// {
//     bin++;
//     sum += item;
//     Console.WriteLine($"Bin {bin} = {item} items (runnin total {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory.");

string[] fraudulentOrderIDData = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string orderID in fraudulentOrderIDData)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine($"Potentiall fraudulent order ID: {orderID}");
    }
}