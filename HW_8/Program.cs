// Домашняя работа к семинару 8

// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/*
Console.Clear();

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRandInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
    Console.WriteLine();
    }
}

void MatrixSorted(int[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1]) // сортировка построчно
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}

int[,] matrix = CreateMatrixRandInt(rows, columns, 0, 19);

Console.WriteLine();
Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);

MatrixSorted(matrix);

Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");

PrintMatrix(matrix);
Console.WriteLine();

*/


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
/*
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

/*
Console.Clear();

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRectang(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
         for (int j = 0; j < columns; j++)
        {
             matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();        
    }
}

int SumString(int[,] matrix, int i)
// метод получения суммы элементов каждой строки(i) массива matrix
{
    int sumString = matrix[i, 0];
    for (int j = 1; j < columns; j++)
    {
        sumString += matrix[i, j];
    }
    return sumString;
}

int[,] matrix = CreateMatrixRectang(rows, columns, 0, 10);
Console.WriteLine();
PrintMatrix(matrix);

int minSum = 0;
int sumString = SumString(matrix, 0);
Console.WriteLine();
Console.WriteLine($"Сумма {0} строки = {sumString}");

for (int i = 1; i < rows; i++)
{
    int tempSum = SumString(matrix, i);
    if (sumString > tempSum)
    {
        sumString = tempSum;
        minSum = i;
    }
Console.WriteLine($"Сумма {i} строки = {sumString}");    
}

Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSum}");
Console.WriteLine();

*/


// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
/*
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*
Console.Clear();

Console.Write("Введите количество строк и столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = new int[n, n];
int[,] secondMatrix = new int[n, n];
int[,] resultMatrix = new int[n, n];

void CreateMatrixRnD(int[,] matrix, int min, int max)
{
    for (int i = 0; i < n; i++)
    {
         for (int j = 0; j < n; j++)
        {
             matrix[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();        
    }
}

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int k = 0; k < n; k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

CreateMatrixRnD(firstMatrix, 1, 6); // [1, 5]
CreateMatrixRnD(secondMatrix, 1, 6); // [1, 5]
MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);

Console.WriteLine("\n\n" + "Первая матрица: ");
PrintMatrix(firstMatrix);

Console.WriteLine("\n\n" + "Вторая матрица: ");
PrintMatrix(secondMatrix);

Console.WriteLine("\n\n" + "Результирующая матрица: ");
PrintMatrix(resultMatrix);

*/


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

/*
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Clear();

int n = 2;
int[,,] matrix = new int[n, n, n];

void CreateMatrix(int[,,] matrix)
{
    int[] tempMatrix = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    int number;
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        tempMatrix[i] = new Random().Next(10, 100);
        number = tempMatrix[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tempMatrix[i] == tempMatrix[j])
                {
                    tempMatrix[i] = new Random().Next(10, 100);
                    j = 0;
                    number = tempMatrix[i];
                }
                number = tempMatrix[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[x, y, z] = tempMatrix[count];
                count++;
            }
        }
    }
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}

CreateMatrix(matrix);
PrintMatrix(matrix);
