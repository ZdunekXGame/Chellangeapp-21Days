
using System.ComponentModel.Design;

string name = ("Sebastian");
bool man = true;
int age = 22;

if (man == true)
{
    if (age >= 23 && name == "Sebastian")
    {
        Console.WriteLine("Sebastian, age 22");
    }
    else if (name != "Sebastian" && age < 30)
    {
        Console.WriteLine("Male under 30 years old");
    }
    else

    {
        if (age < 18)
        {
            Console.WriteLine("Underage male");
        }
        else if (man == false)
        {
            Console.WriteLine("A man is born");
        }
    }
}
 
{
    if (age == 22 && name == "Sebastian" && man == true)
    {
        Console.WriteLine("It's me, a 22-years-old man named Sebastian");
            }
}