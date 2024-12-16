Console.WriteLine("These tasks are done by Shahad Eissa\n");

Console.WriteLine("============================= C# paramitive type: ==============================");
Console.WriteLine("==================================== Task 1: ===================================");
int thisInt = 100;
double thisDouble = 10.0;
string thisString = "this is a string";
bool thisBool = true;
Console.WriteLine("integer value is: " + thisInt);
Console.WriteLine("double value is:  " + thisDouble);
Console.WriteLine("string value is: " + thisString);
Console.WriteLine("boolean value is: " + thisBool);

Console.WriteLine("\n==================================== Task 2: ===================================");
int converstion1 = Convert.ToInt32(thisDouble);
Console.WriteLine(converstion1); // here a new variable has been created an integer of thisDouble
double converstion2 = Convert.ToDouble(thisInt);
Console.WriteLine(converstion2); // here a new variable has been created a double of thisInt

//Console.WriteLine("\n\n==================================== Bonus 1: ==================================");
//char is used to declare one character be it a (number, special character, letter)
//char is more memory efficient than a string 
//char can be used to manipulate strings and extracting a single character out of them 

Console.WriteLine("\n\n================================ C# variables: =================================");
Console.WriteLine("==================================== Task 1: ===================================");
string studentName; // Camel case
double grade_point_average; // Underscoring / Snake case
string FavoriteSubject; // Pascal case
// If we wanted to print it for output asthetics (uncomment the following):
//Console.WriteLine("studentName ->  Camel case \ngrade_point_average -> Underscoring / Snake Case \nFavoriteSubject -> Pascal case");

Console.WriteLine("\n==================================== Task 2: ===================================");
double Area;
double Width = 6;
double Length = 5;
Area = Width * Length;
Console.WriteLine("Area is: " + Area);

Console.WriteLine("\n\n==================================== Bonus 2: ==================================");
int variable = 5; //a variable could be possibly change later on (immutable)
Console.WriteLine("enter a number");
const int constant = 6; // a constant is declared and can not be changed later on (mutable)
Console.WriteLine("the constant is :" + constant + "\tthe variable is " + variable);
// say a company called "shahad's co". a constant (const string nameOfCo = "shahad's co"), is helpful here to be used in the website for example

Console.WriteLine("============================= Challenge: ==============================");
//Control flow
Console.WriteLine("enter current hour: ");
int currentHour = Convert.ToInt32(Console.ReadLine());
if (currentHour >= 11 && currentHour <= 14)
{
    Console.WriteLine("Time for lunch!");
}