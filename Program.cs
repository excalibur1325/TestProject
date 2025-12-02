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

/*string [] fraudulentOrderIDs  = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string orderID in fraudulentOrderIDs)
{
    if (orderID.StartsWith ("B"))
    {
        Console.WriteLine(orderID);
    }
}*/

/*Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine( myValue == "a");*/



//THIS IS THE START OF WEEK 4 

/*Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);*/

/*string myValue = "a";
Console.WriteLine(myValue == "a");*/

/*string myValue1 = " a";
string myValue2 = "A";
Console.WriteLine(myValue1.Trim().ToLower() == myValue2.Trim().ToLower());*/

/*string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());*/

/*Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");*/

/*Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);*/

/*string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));*/

//int saleAmount = 1001;
//int discount = saleAmount >= 1000 ? 100 : 50;
//Console.WriteLine($"Your discount is: {discount}. Congrats!");
//Console.WriteLine($"Your discount is: {(saleAmount > 1000 ? 100 : 50)}");

//Generating a 'Heads' or 'Tails' program with conditional operators
/*Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");*/

//Another way to write line2 and line3 is as follows:
/*Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");*/

//string permission = "Admin|Manager";
//Random level = new Random();
/*int level = 58;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >=20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}*/

/*Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);
    if (current >= 8) continue;
    Console.WriteLine(current);
} while (current != 7);*/

/*while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
System.Console.WriteLine($"Last number: {current}");*/

//The beginning of the battle challenge

/*int invincible = 10;
int BattleBeast = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    BattleBeast -= roll;
    Console.WriteLine($"BattelBeast was damaged and lost {roll} health and now has {BattleBeast} health.");

    if (BattleBeast <= 0) continue;

    roll = dice.Next(1, 11);
    invincible -= roll;
    Console.WriteLine($"Invincible was damaged and lost {roll} health and now has {invincible} health.");

} while (invincible > 0 && BattleBeast > 0);

Console.WriteLine(invincible > BattleBeast ? "Invincible survives!" : "BattleBeast conquered another.");*/

//END

//Nullable type string
/*string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);*/

//User Enter at least 3 Characters
/*string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try  again.");
        }
    }
}   while (validEntry == false);*/

// Capturing user input in a string variable named readResult

/*int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);*/

//Code Project 1
/*string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();*/

// Project 2
/*string? readResult;
string positionName = "";
bool validEntry = false;

do
{
    Console.WriteLine("Enter your position name (Administrator, Manager, or Executive)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        positionName = readResult.Trim();
    }

    if (positionName.ToLower() == "administrator" || positionName.ToLower() == "manager" || positionName.ToLower() == "executive")
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The position entered, \"{positionName}\" is not valid. ");
    }
} while (validEntry == false);

Console.WriteLine($"Your input value ({positionName}) has been accepted.");
readResult = Console.ReadLine();*/

//Project 3

/*string[] gameDialog1 = new string[2] { "Do you want to go right or left?", "Either way, decision is yours to make." };
int stringsCount = gameDialog1.Length;

string gameDialog2 = "";
int characterLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    gameDialog2 = gameDialog1[i];
    characterLocation = gameDialog2.IndexOf(".");

    string characterAnswer;

    while (characterLocation != -1)
    {
        characterAnswer = gameDialog2.Remove(characterLocation);

        gameDialog2 = gameDialog2.Substring(characterLocation + 1);

        gameDialog2 = gameDialog2.TrimStart();

        characterLocation = gameDialog2.IndexOf(".");

        Console.WriteLine(characterAnswer);
    }

    characterAnswer = gameDialog2.TrimEnd();
    Console.WriteLine(characterAnswer);
}*/