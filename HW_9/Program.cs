// Домашняя работа к семинару 9

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8"

// решили такую же задачу 65 на уроке

/*
Console.Clear();

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M > N) return; // выход из программы (иначе выдаст ошибку)

string PrintNumbers(int start, int end) 
{
    if (start == end) return start.ToString();  
    return (start + ", " + PrintNumbers(start+1, end));
}
Console.WriteLine($"Числа от {M} до {N} = '{PrintNumbers(M, N)}'");

*/

// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*

Console.Clear();

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N) return; // если M > N -> выход из программы 
int sum = 0;

int PrintSumNumbers(int start, int end, int sum) 
{
    sum += end;         // суммируем числа, начиная с конца заданного периода
    if (end <= start) return sum;  
    return PrintSumNumbers(start, end-1, sum); // уменьшаем конечное число на 1
}
Console.WriteLine($"Сумма чисел от {M} до {N} = {PrintSumNumbers(M, N, sum)}");

*/

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

// работает для 2 и 3, но не работает для чисел 4 и 5 = stack overflow: Repeat 19281 times:

Console.Clear();

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M < 0 || N < 0) return; // проверка чисел, выход из программы 

int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    // возвращает значение n+1, выход из программмы
    else
    if (n == 0) return FunctionAkkerman(m - 1, 1);
    else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    // оба значения положительные
}

Console.WriteLine();
Console.Write($"Функция Аккермана = {FunctionAkkerman(M, N)} ");
Console.WriteLine();

