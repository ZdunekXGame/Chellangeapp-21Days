
using System.ComponentModel.Design;

string name = ("Sebastian");
string surname = (" Zduńczyk");
bool man = true;
int age2 = 27;
string name2 = "Żaneta";
bool woman = true;
int age3 = -5;
string results = name + surname;
int age = age2 + age3;
char favortieLetter = 'S';

if (results == name + surname && favortieLetter == 'T')
{
    Console.WriteLine("I am " + results + " " + age + " years old");
}
else if (!man == true)
{
    Console.WriteLine("Her name is " + name2 + " and has " + age2 + " years old");
}
else if (woman == true)
    if (results == name + surname && favortieLetter == 'S' && !man == false && age < age2 && age2 <= 27)
    {
        Console.WriteLine("I am " + results + " " + age + " years old, " + "Her name is " + name2 + " and has " + age2 + " years old.");
    }