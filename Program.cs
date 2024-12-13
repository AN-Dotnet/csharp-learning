// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;
using System.Net.Sockets;
using CSharp.classes;
using csharpLearning;
using csharpLearning.classes;

string name = "Arjun";
int count = 5;
long billGatesNetworth = 1000000000000000000;
var myVariable = 123;
bool isFlag = false;
char charVar = 'C'; // in single quote and not double quote

// string is stored in heap memory

Console.WriteLine("Hello " +name + ", welcome to dotnet World!!!");

// Template Literal
// In C#, to include variables in a string, you can use string interpolation with the $ symbol.
Console.WriteLine($"I am richer than {name}"); 

// update
string newBillionaireName = name.Replace("Arjun", "Mr. Arjun Naik");
Console.WriteLine("Hello " +newBillionaireName + ", welcome to dotnet World!!!");
    // above can also be written as 
Console.WriteLine($"Hello {newBillionaireName}, welcome to dotnet World!!!");

Console.WriteLine("-----Array-----");
// array CRUD
// create 
string[] playerList = ["Arjun", "Subham", "Sai"];

// this will not print the entire array but it will rather print the type of the variable .eg System.String[]
Console.WriteLine(playerList); 

foreach (var item in playerList)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----Array update-----");
// update
playerList[2] = "Pandu";
// LINQ - "update array Linq"
var newFavourite = playerList.Where((e) => e.StartsWith("S"));

foreach (var item in newFavourite)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----foreach-----");
// foreach
for (var i = 0; i < 10; i++)
{
    Console.WriteLine("current value of I is "+ i);
}

string[] teamList = ["RCB", "MI", "CSK", "KKR", "RR"];

for (int i = 0; i < teamList.Length; i++)
{
    Console.WriteLine(teamList[i]);
}

foreach (var item in teamList)
{
    Console.WriteLine(item);
}

// list
teamList.ToList().ForEach((item) => {
    Console.WriteLine("for each: "+item);
});

Array.ForEach(teamList, e => Console.WriteLine("Array.ForEach: "+ e));

/*
    ----------- if else section -----------
*/
if (true) {
    Console.WriteLine("This is true");
}

// comaparison
var favoriteAuthor = "friedrich";
if (favoriteAuthor == "friedrich") {
    Console.WriteLine("you're probably insane");
}

var golf = true;
var running = true;

if ((golf == true) && (running == true)) {
    Console.WriteLine("Today was a great day!");
} else if ((golf == true) || (running == true)) {
    Console.WriteLine("Today was a descent day!");
} else {
    Console.WriteLine("I did nothing!...");
}

string aquariumFish = "puffer fish";
if (aquariumFish is string) {
    Console.WriteLine("Aquarium firsh is a string!");
}

/*
    ----------- Enum -----------
    enum is a value type (stack data structure is used)
*/
Console.WriteLine("-----Enum-----");
Console.WriteLine(Warning.codeRed);
Console.WriteLine((int)Warning.codeRed);

var status = Warning.CodeGreen;
if (status == Warning.CodeGreen)
{
    Console.WriteLine("match found!..");
}

/*
    ----------- Switch -----------
*/
Console.WriteLine("----- Switch -----");
// only ca use numbers and strings

var teamCaptain = "Arjun";
switch (teamCaptain)
{
    case "Sai": 
        // run code
        Console.WriteLine("Sai is the captain");
        break;
    case "Arjun":
        // run code
        Console.WriteLine("Arjun is the captain");
        break;
    default:
        // run code 
        Console.WriteLine("Captain is not decided yet");
        break;
}

// modern switch expression
var billionaire = "Jeff";
var result = billionaire switch {
    "Sai" => "Sai is richest man on the world!.",
    "Arjun" => "Arjun is richest man on the world!.",
    _ => "default case triggered"  // _ (underscore for default case)
};
Console.WriteLine(result);


/*
    ----------- While loop -----------
*/
// creating small application to check network connection just to demonstrate while loop
// Ping is a C# network library

// Console.WriteLine("----- While loop -----");
// Ping p1 = new Ping();
// PingReply PR = p1.Send("8.8.8.8"); //checking google server is up

// while(PR.Status.ToString() == "Success") {
//     Console.WriteLine(PR.Status.ToString() + "!");
//     PR = p1.Send("8.8.8.8");
//     Console.WriteLine("waiting 5 seconds for next request");
//     Thread.Sleep(5000);
// }

/*
    ----------- Class -----------
*/
Console.WriteLine("----- Class -----");
// CRUD
Rat wolfRat = new Rat();
Rat fancyRat = new Rat();

wolfRat.Name = "Wolf Rat";
wolfRat.Number = 1000;
wolfRat.IsRadioActive = false;

fancyRat.Name = "Fancy Rat";
wolfRat.Number = 500;
wolfRat.IsRadioActive = false;

// Read
Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);

// Update
Console.WriteLine("--updating names--");
wolfRat.Name = "WOLF RAT";
fancyRat.Name = "FANCY RAT";
Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);

// Delete
Console.WriteLine("--deleting names--");
wolfRat.Name = "";
fancyRat.Name = "";
Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);

/*
    ----------- Methods -----------
*/
Console.WriteLine("----- Methods -----");
// CRUD
RealEstate elmStreet = new() // another way of creating class obj ... RealEstate elmStreet = new RealEstate()
{
    Address = "Elm Street",
    SquareFootage = 1300,
    Price = 300000
};

var priceCalculated = elmStreet.CalculatePricePerSquareFoot();
Console.WriteLine($"price is {priceCalculated}");

/*
    ----------- Tuple -----------
*/
Console.WriteLine("----- Tuple -----");
var tupleValues = ("t", 2, "p"); // are defined in round brackets
 
Console.WriteLine(tupleValues.Item1);
Console.WriteLine(tupleValues.Item3); // can be accessed by unique item like this 

var tupleValuesWithNames = (First: "t",  Second: 2, Third: "p");
Console.WriteLine(tupleValuesWithNames.First);
Console.WriteLine(tupleValuesWithNames.Second); // can be accessed by unique item like this

// also type can be defined like this
(string a, int b, string c) tupleValuesWithType = ("t", 2, "p"); // this type can be defined to the method as well, check ReturnValuesWithTupleReturnType() in RealEstate class

var tupleValueResult = elmStreet.ReturnValuesWithTupleReturnType();
Console.WriteLine(tupleValueResult);

// destructuring 
(int a, string b, bool c) = elmStreet.ReturnValuesWithTupleReturnType();
Console.WriteLine(a);

/*
    ----------- Null reference exception -----------
*/
Console.WriteLine("----- Null reference exception -----");
int? value = null; // ? will give you power to accept null
Console.WriteLine(value);
string value2 = null!; // ! (bang operator) you are forcing the compilor to ignore
string? value3 = null; // ? is more correct way
Console.WriteLine(value2?.Length);

// null exception checks are mandatory
if (value3 is not null) {
    Console.WriteLine(value3.Length);
}

Console.WriteLine(value3 ?? "no value"); // binary operator

Console.WriteLine(value3 is not null ? "has value!" : "no value"); // ternary operation

/*
    ----------- Constructor -----------
*/
Console.WriteLine("----- Constructor -----");
Automobile automobile = new("Tramstrasse");
Console.WriteLine(automobile.Address);

/*
    ----------- static -----------
*/
Console.WriteLine("----- static -----");
TimeUtility.PrintTime();





enum Warning {
    codeRed,
    CodeBlue,
    CodeGreen
};