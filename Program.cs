// задание 2
/*
using System.ComponentModel.DataAnnotations;


Console.WriteLine("number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Min, Max;

if (number1 < number2)
{
    Min = number1;
    Max = number2;
}
else
{
    Min = number2;
    Max = number1;
}

Console.WriteLine("Min: " + Min);
Console.WriteLine("Max: " + Max);

*/

//задание 4
/*
Console.WriteLine("number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("number3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int Max;

if (number1 > number2 && number1 > number3)
{
    Max = number1;
}
else if (number2 > number1 && number2 > number3)
{
    Max = number2;
}
else
{
    Max = number3;
}
Console.WriteLine("max: " + Max);

*/

//задание 6
/*
Console.WriteLine("number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}

*/

// задание 8

Console.WriteLine("number: ");
int N = Convert.ToInt32(Console.ReadLine());

int number = 2;

while (number <= N)
{
   Console.WriteLine("number: " + number); 
   number += 2;
}
