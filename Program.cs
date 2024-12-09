// See https://aka.ms/new-console-template for more information
string name = "Arjun";
int count = 5;
long billGatesNetworth = 1000000000000000000;
var myVariable = 123;
bool isFlag = false;
char charVar = 'C'; // in single quote and not double quote

// string is stored in heap memory

Console.WriteLine("Hello " +name + ", welcome to dotnet World!!!");

// Template Literal
Console.WriteLine("I am richer than ${name}"); 

// update
string newBillionaireName = name.Replace("Arjun", "Mr. Arjun Naik");
Console.WriteLine("Hello " +newBillionaireName + ", welcome to dotnet World!!!");

// array CRUD
// create 
string[] playerList = ["Arjun", "Subham", "Sai"];
Console.WriteLine(playerList);
foreach (var item in playerList)
{
    Console.WriteLine(item);
}

// update
playerList[2] = "Pandu";
// LINQ - "update array Linq"
var newFavourite = playerList.Where((e) => e.StartsWith("S"));

foreach (var item in newFavourite)
{
    Console.WriteLine(item);
}

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