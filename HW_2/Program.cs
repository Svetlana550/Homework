// Домашняя работа, семинар 2

// Задача 10. Программа, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа


/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstNumber = number / 100;
int thirdNumber = number / 10;
int secondNumber = thirdNumber % 10;

Console.WriteLine(secondNumber);

*/

// Задача 13. Программа, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет


/*
Console.Write("Введите число: ");
string number = Console.ReadLine();
int numberCheck = Convert.ToInt32(number);

if (numberCheck / 100 > 1) Console.WriteLine($"Третья цифра от числа {numberCheck} = {number[2]} ");
else Console.WriteLine("Третьей цифры у данного числа нет");
*/


// задача 15. Программа, которая принимает на вход цифру, 
// обозначающую день недели и проверяет, является ли этот день выходным 


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7) Console.WriteLine("Выходной");
else Console.WriteLine("Не выходной");

