/////////// Домашняя работа к семинару 7 /////////////////


// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


/*
Console.WriteLine("Введите два числа: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

double [,] numbers = new double[rows, columns];

for (int i = 0; i < numbers.GetLength(0); i++)
    {  
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().NextDouble() * 100;
            Console.Write(Math.Round(numbers[i, j],1) + "\t");   
        }
        Console.WriteLine();            
    }

*/


// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
/*
1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

/*

Console.WriteLine("Введите два числа: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11); // заполнение массива
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите номер строки и номер столбца элемента: ");
int rowsCheck = Convert.ToInt32(Console.ReadLine());
int columnsCheck = Convert.ToInt32(Console.ReadLine());
bool flagResult = false;
int result = 0;

Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == rowsCheck && j == columnsCheck) // поиск заданного элемента
        {
            result = matrix[i,j];
            flagResult = true;
            break;     // цикл останавливается
        }
    }
}

if (flagResult) Console.WriteLine("Element found: " + result);
else Console.WriteLine("Element not found");

*/



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
/*
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


Console.WriteLine("Введите 2 числа: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

double[,] GetArray(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 100, 1);
        }
    }
    return matrix;
}

double[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);

void PrintArray(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[] averageSumColumns = new double[rows];
for (int j = 0, n = 0; j < columns; j++)
{
    double sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += resultMatrix[i, j];
    }
    averageSumColumns[n] = sum / rows;
    Console.WriteLine("Среднее арифметическое столбца " + (n + 1) + " = " + Math.Round(averageSumColumns[n],1));
    n++;
}

