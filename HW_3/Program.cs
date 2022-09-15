////////////// Домашняя работа, семинар 3.

// Задача 19. Программа, которая принимает на вход пятизначное число
// и проверяет, является число палиндромом
//14212 - нет
//23432 - да
//12821 - да

/*

Console.WriteLine("Введите число:");
string? number = Console.ReadLine();
int i = 0;
int size = number.Length - 1;
while ((i<size) && (number[i] == number[size]))
{
    i++;
    size--;
}

if (number[i] == number[size]) Console.WriteLine("Число: " + number + " является палинромом");
else Console.WriteLine("Число: " + number + " не является палинромом");

*/


// Задача 21. Программа, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.


/*

Console.Write("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

//int x = (x2 - x1) * (x2 - x1) 
//int y = (y2 - y1) * (y2 - y1);
//int z = (z2 - z1) * (z2 - z1);
//double result = Math.Sqrt((x + y + z));

double result = Math.Sqrt(Math.Pow((x2 - x1),2)+Math.Pow((y2 - y1),2)+Math.Pow((z2 - z1),2));

double testVar = Math.Round(result,3); // округлит до 3 знаков после запятой

Console.WriteLine($"Расстояние между точками: {result:f2}"); 

*/


// Задача 23. Программа, которая принимает на вход число N и выдает
// таблицу кубов чисел от 1 до N.


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1; 
while (i <= num) 
{
    Console.WriteLine($"Куб от числа {i} = {Math.Pow(i,3)}");
    i++;
}

