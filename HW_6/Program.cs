////////// Домашняя работа к семинару 6 ///////////



// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
Console.WriteLine("Введите числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int amountPositiveNumbers = 0;
int size = array.Length;

for (int i = 0; i < size; i++) 
{
    if (array[i] > 0) amountPositiveNumbers++;    
}
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 = {amountPositiveNumbers} ");
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями:
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b1 - b2) / (k2 - k1);
double y = k2 * x + b2;
Console.Write($"Точка пересечения двух прямых: {x}, {y}");

*/

// Доп. задачка:
// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numDecimal = num;
int i = 0;
string[] result = new string[num];
while (num >= 1)
{
    result[i] = Convert.ToString(num % 2);
    i++;
    num = num / 2;
};
Array.Reverse(result);
Console.WriteLine($"Десятичное число {numDecimal} в двоичном виде {String.Join("", result)}");



