//////////////    Домашняя работа к семинару 5    /////////////



//Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// num % 2 == 0, то четное число

/*

int[] array = new int[4];
int size = array.Length; 
int countEvenNumbers = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100,500); // рандом [100,499]
    // Console.Write(array[i] + ", ");

    if (array[i] % 2 == 0) countEvenNumbers++;
}

Console.WriteLine($"[ {String.Join(", ", array)} ]");

if (countEvenNumbers == 0) Console.WriteLine($"В массиве нет четных чисел");
else Console.WriteLine($"Количество четных чисел = {countEvenNumbers}");

*/



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// в цикле for использовать шаг i+=2
// for (i=1; i < size; i+=2)
// sum = sum + array[i];

/*

int[] array = new int[6];
int size = array.Length; 
int sumNumbers = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(10,100); // рандом [10,99]
    // Console.Write(array[i] + ", ");
}
for (int i = 1; i < size; i+=2) sumNumbers = sumNumbers + array[i];

Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.WriteLine($"Сумма чисел на нечётных позициях = {sumNumbers}");

*/


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double
// double max = 0;
// double min = 0;
// double diff = 0;
// NextDouble - от 0 до 1, для задания массива случайных дробных чисел
// Math.Round(num,2) - округлить до 2 знаков 


double[] array = new double[4];
int size = array.Length; 
double differenceMaxMin = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().NextDouble() * 100; 
    Console.Write(Math.Round(array[i], 2) + " ");
}

double max = array[0];
double min = array[0];   
for (int i = 0; i < size; i++)
{
    if (array[i] < min) min =  array[i];
    if (array[i] > max) max =  array[i];
}

// differenceMaxMin = Math.Round(max - min, 2);
differenceMaxMin = max - min;

// Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.WriteLine($"Макс = {Math.Round(max,2)}, мин = {Math.Round(min,2)}");
Console.WriteLine($"Разница между макс и мин = {Math.Round(differenceMaxMin,2)}");


