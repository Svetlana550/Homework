// Домашняя работа к семинару 1


// Задача 2. Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
/*
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


if (firstNumber > secondNumber) 
{
    Console.WriteLine(firstNumber);    
}
else
{
    Console.WriteLine(secondNumber);  
}
*/


// Задача 4. Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
/*
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

if (secondNumber > max) 

    if (secondNumber > thirdNumber) 
{
    max = secondNumber;
    Console.WriteLine(max);    
}
    else
    {
     max = thirdNumber;
    Console.WriteLine(max); 
    }
else
{
    Console.WriteLine(max); 
}
*/


// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
/*
4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) 
{
    Console.WriteLine("Число " + number + " является чётным");    
}
    else
    {
    Console.WriteLine("Число " + number + " является НЕ чётным");    
    }
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
/*
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    Console.Write("Четные числа: ");
    for (int i = 1; i <= num; i++)
        if (i % 2 == 0)
        {
            Console.Write(i + ", ");
        }
}

else
{
    Console.WriteLine("Error: number should be more than 0");
}
