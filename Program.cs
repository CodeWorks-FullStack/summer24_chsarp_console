// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");

// ANCHOR strings

// explicit typing, my type is assigned directly
string firstName = "Jeremy";

string lastName = "Fowler";

char middleInitial = 'B';

// implicit typing, my type is assigned based in the data type itself
var catchPhrase = "It's time to learn!";

Console.WriteLine(firstName + middleInitial + lastName);

Console.WriteLine($"My name is {firstName} {middleInitial} {lastName}, and my catchphrase is {catchPhrase}");

// ANCHOR booleans

bool likesCats = true;

bool likesRawTomatoes = false;

if (likesCats)
{
  Console.WriteLine($"{firstName} likes cats");
}
else
{
  Console.WriteLine("Someone wrote bad code");
}

// ANCHOR numbers

int numberOfCrocs = 8;

long goalAmountOfCrocs = 20000000000;

double sandwichesEaten = 2.3;
numberOfCrocs--;
numberOfCrocs++;

Console.WriteLine($"Mick has {numberOfCrocs} pairs of crocs but he wants {goalAmountOfCrocs} pairs of crocs");

Console.WriteLine(sandwichesEaten);

// ANCHOR weird stuff

// var x; undefined does not exist, everything must have a definition

string x = null; // strings cannot be null
// int x = null; numbers cannot be null
Console.WriteLine(x);

// ANCHOR arrays

// NOTE arrays are terrible in C#
string[] catNames = ["Gopher", "Falcon", "Georgie"];

for (int i = 0; i < catNames.Length; i++)
{
  string name = catNames[i];
  Console.WriteLine($"Hi my name is {name}! Meow meow feed me");
}

List<string> dogNames = ["Dipper", "Pluto"];

dogNames.Add("Hooper"); // similar to push
dogNames.Add("Doug");

dogNames.Remove("Doug"); // similar??? to splice

foreach (string dogName in dogNames)
{
  Console.WriteLine($"Bark bark my name is {dogName}");
}


// ANCHOR objects

// NOTE pojos don't *really* exist in C#

Cat gopher = new Cat("Gopher", true);

// cat.Name = "Lindsey"; cannot set this value

// Console.WriteLine(@$"
// Meow I am a cat and my name is {gopher.Name} 
// and I {(gopher.LikesCheese ? "love" : "hate")} cheese");

// Console.WriteLine(gopher.JudgeCat());

List<Cat> cats = [gopher, new Cat("Frankie", false)];

cats.ForEach(cat =>
{
  Console.WriteLine(cat.JudgeCat());
});

class Cat
{
  // NOTE this is the constructor
  public Cat(string name, bool threwUpOnTheBed)
  {
    this.Name = name;
    this.LikesCheese = true;
    this.ThrewUpOnTheBed = threwUpOnTheBed;
  }

  public string Name { get; } // I can only get the cat's name, I can't set it to something different
  public bool LikesCheese { get; set; } // I can get this property and change it

  // NOTE only the cat knows that they threw up on the bed because this is private
  private bool ThrewUpOnTheBed { get; set; }

  public string JudgeCat()
  {
    if (this.ThrewUpOnTheBed)
    {
      return "I might have thrown up on the bed...";
    }
    return "I didn't throw up on the bed";
  }
}
