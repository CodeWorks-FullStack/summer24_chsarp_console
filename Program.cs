// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");

// explicit typing, my type is assigned directly
string firstName = "Jeremy";

string lastName = "Fowler";

char middleInitial = 'B';

// implicit typing, my type is assigned based in the data type itself
var catchPhrase = "It's time to learn!";

Console.WriteLine(firstName + middleInitial + lastName);

Console.WriteLine($"My name is {firstName} {middleInitial} {lastName}, and my catchphrase is {catchPhrase}");