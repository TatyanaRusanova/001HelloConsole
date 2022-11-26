//Напишите программу, которая будет принимать на вход два числа и 
//выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

int num3 = num1 % num2;

if(num2 % num1 == 0) Console.WriteLine($"{num1} кратно {num2}");
else Console.WriteLine($"Введенные числа не кратные! Остаток от деления {num3}.");


