//Console.WriteLine("Signed integral types:");

/*Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} {ushort.MaxValue}");
Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");*/


//int [] data = new int [3];

//string shortenedString = "This is a string";
//Console.WriteLine (shortenedString);

//int val_A =2;
//int val_B = val_A;
//val_B = 5;

//Console.WriteLine("--Value Types--");
//Console.WriteLine($"val_A: {val_A}");
//Console.WriteLine($"val_B: {val_B}");

//int [] ref_A= new int[1];
//ref_A[0]= 2;
//int [] ref_B = ref_A;
//ref_B[0]= 5;

//Console.WriteLine("--Reference Types--");
//Console.WriteLine($"ref_A[0]: {ref_A[0]}");
//Console.WriteLine($"ref_B[0]: {ref_B[0]}");

/*string [] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");*/

/*string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");*/

/*string [] names = {"Rowena", "Robin", "Bao", "Dijon", "Zac",};
foreach (string name in names) 
{
    Console.WriteLine(name);
}

int [] inventory = {200,450,700,175,250};
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running Total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");*/

string [] fraudulentOrderIDs  = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string orderID in fraudulentOrderIDs)
{
    if (orderID.StartsWith ("B"))
    {
        Console.WriteLine(orderID);
    }
}