// Задача 2. Напишите программу, которая на вход принимает два числа и выдает какое число большее, а какое меньшее

 /*
Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());


if(number1 > number2)
{
    Console.WriteLine($"{number1} - max " );
    Console.WriteLine($"{number2} - min ");
}

    else
    {
        Console.WriteLine($"{number2} - max " );
        Console.WriteLine($"{number1} - min");
    }

*/

//Задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

/*
Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > number1)
{
    max = number2;
}

if (number3 > max)
{
    max = number3;
}

Console.Write($"max number: {max} ");

*/

//Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)

/*

Console.Write("Imput testing number ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write("Yes ");
}

else
{
    Console.Write("No ");
}

*/

//Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int min = 0;
int max = number;
int c = min + 1;

while(min <= max)
{
    c = (min + 1) % 2;
    min ++;
        if(c == 0)
        { 
            Console.WriteLine($"{min} ");
        }
}










  




