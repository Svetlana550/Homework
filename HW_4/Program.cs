////////////// Домашняя работа к семинару 4  ///////////



// Задача 25. Напишите цикл, который принимает на вход два числа (А и В) 
// и возводит число А в натуральную степень В.

/*
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int i = 0; 
double result = 1;
while (i < b) 
{
    result *= a;
    i++;
}
Console.WriteLine($"Число {a} в степени {b} = {result}");

*/


// Задача 27. Программа, которая принимает на вход число 
// и выдает сумму цифр в числе

/*
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;

while (number != 0)
{
    sum += number % 10;
    number = number / 10;
}

Console.WriteLine("Сумма цифр в числе " + sum);

*/


// Задача 29. Программа, которая задает массив из 8 элементов 
// и выводит их на экран.
// считать элементы с консоли 

/*
int size = 8;
int[] result = new int[size]; 

Console.WriteLine("Введите элементы массива через пробел: ");
result = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

for (int i = 0; i < size; i++) Console.Write($"{result[i]}; ");
*/


// дополнение с семинара 5 (от преподавателя)

int [] array= new int [8]; // array = [0,0,0,0,0,0,0,0]

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,1000); // рандом [0,999]
    // array[i] = Convert.ToInt32(Console.ReadLine()); // с консоли
}
   
   // когда нужно преобразовать отр число размера массива
   // если пользователь ввел отр размер

   // if (size < 0) size = -size;