int num = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерировано случайное число {num}");


int x1 = (int)Math.Pow(10, 3 - 3);
int x3 = (int)Math.Pow(10, 3 - 1);

int result = num/100;  //количество сотен
int result1 = num % 10; //количество единиц
Console.WriteLine($"{result}{result1}");