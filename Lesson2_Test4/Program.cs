//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет
Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 - (num1 * num1) == 0) Console.WriteLine($"{num2} является квадратом {num1}");
else if (num1 - (num2 * num2) == 0) Console.WriteLine($"{num1} является квадратом {num2}");
else Console.WriteLine($"Числа не являются квадратом друг друга");

///////////////////////////////////////////////////

Console.WriteLine("Введите первое целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int square1 = a * a;
int square2 = b * b;
if (square1 == b) Console.WriteLine("Первое число a является квадратом второго числа b");
else if (square2 == a) Console.WriteLine("Второе число b является квадратом первого числа a");
else Console.WriteLine("Числа не являются квадратом друг друга");

