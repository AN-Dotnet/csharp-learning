// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;
using System.Net.Sockets;
using csharp.classes;
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
// codeNo.2 here
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

/*
    ----------- List -----------
*/
Console.WriteLine("----- List -----");
// CRUD
// Create
List<int> numberList = new List<int>{1, 2, 3, 4, 5}; // = [1, 2, 3, 4, 5]

// Read
foreach (var item in numberList)
{
    Console.WriteLine(item);
}

// Update

numberList.Add(6); // add it to the back of the list
// insert
numberList.Insert(6,7); // (index, value);
numberList.Insert(7,2);
numberList.Insert(8,9);
numberList.Insert(9,2);

var newNum = numberList.Where((i) => i == 2); // this will returns brand new List
newNum.ToList().ForEach(item => Console.WriteLine(item));

/* below will not work because Array.ForEach is specifically designed to work with arrays, not with collections like List<T>. 
 Since numberList is a List<int>, not an array, Array.ForEach will not work directly.
*/
// Array.ForEach(newNum, item => Console.WriteLine(item)); 
// Array.ForEach(numberList, item => Console.WriteLine(item)); 

Console.WriteLine("--printing-");
// we can use foreach on the List directly
numberList.ForEach(item => Console.WriteLine(item)); 

Console.WriteLine("--delete-");
// Delete
numberList.Remove(2); // removes the value 2 ....removes the first occurrence of that matched value
numberList.ForEach(item => Console.WriteLine(item));
// delete at index
numberList.RemoveAt(3); // removes the value 2 ....removes the first occurrence of that matched value
numberList.ForEach(item => Console.WriteLine(item));

/*
    ----------- Records -----------
*/
Console.WriteLine("----- Records -----");
Person person1 = new ("Teddy", "Smith", new string[1] { "555-1234"});
Person person2 = new ("Teddy", "Smith", new string[1] { "555-1234"});

// Immutability (Shallow Immutability)
// person1.LastName = "smith"; // this will not allow us to change 
// person1.PhoneNumbers[0] = "222-324234"; // but this will allow us to change

// Equality ........ can be checked based on the below
// value type - 1. Check the type 2. Check the contents
// Referential - by memory (hex code)
Console.WriteLine(person1 == person2);

// Non-destructive Mutation (Copy)
Person person3 = person2 with {LastName = "Brewski"};
Console.WriteLine(person3.ToString());

// codeNo.1 here

/*
    ----------- Delegates -----------
*/
Console.WriteLine("----- Delegates -----");
Action loggerAction = () => {
    System.Console.WriteLine("This is simple");
};

Func<int, int> loggerFunc = (int x) => {
    return x + 2; 
};

// SuperCustom loggerFuncWithCustomFunc = (int x) => {
//     return x + 2;
// };

// public delegate int SuperCustom(int x); // custom delegate

var list = Enumerable.Range(1, 10).Select(i => i * 3).ToList();

// callback
var callCall = (Action func) =>
{
    func();
};

callCall(() => Console.WriteLine("callback"));
callCall(loggerAction);

// Built-in Delegates
// C# provides built-in generic delegate types, such as Func, Action, and Predicate.
DelegateExample.main();

// 1.Action
// Represents a method that has no return value.
Action<string> greet = name => Console.WriteLine($"Hello, {name}");
greet("Alice"); // Output: Hello, Alice

// 2. Func
// Represents a method that returns a value.
Func<int, int, int> sum = (x, y) => x + y;
Console.WriteLine(sum(10, 20)); // Output: 30

// 3. Predicate
// Represents a method that returns a bool.
Predicate<int> isPositive = num => num > 0;
Console.WriteLine(isPositive(10)); // Output: True

/*
    ----------- Dictionary -----------
*/
Console.WriteLine("----- Dictionary -----");
// 1. Create a dictionary
Dictionary<int, string> students = new Dictionary<int, string>();

// 2. Add elements
students.Add(1, "Alice");
students.Add(2, "Bob");
students.Add(3, "Charlie");

// 3. Access elements
Console.WriteLine(students[1]); // Output: Alice

students.Add(4, "Diana");
students[5] = "Eve"; // Another way to add

// 3. Access Elements
string studentName = students[2]; // Retrieves "Bob"
Console.WriteLine(studentName);

// Note: If the key doesn't exist, it will throw a KeyNotFoundException. Use TryGetValue to safely retrieve values.
if (students.TryGetValue(3, out string student))
{
    Console.WriteLine($"value found is {student}");
}
else
{
    Console.WriteLine("Key not found!");
}

// 4. Check for Keys or Values
bool hasKey = students.ContainsKey(2); // Checks if key 2 exists
bool hasValue = students.ContainsValue("Alice"); // Checks if "Alice" exists

// 5. Iterate Over a Dictionary
foreach (var kvp in students)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

foreach (int key in students.Keys)
{
    Console.WriteLine($"Key: {key}");
}

foreach (var val in students.Values)
{
    Console.WriteLine($"Value: {val}");
}

/*
    ----------- Hash -----------
*/
Console.WriteLine("----- Hash -----");








// codeNo.1 :
public record Person(string FirstName, string LastName, string[] PhoneNumbers); // defining and initialising the record

// codeNo.2 :
enum Warning {
    codeRed,
    CodeBlue,
    CodeGreen
};