//а входе 5 чисел
//надо попарно проверить и написать 
//что число 3 является квадратом 1
//или наоборот

//массив
//через фор
//2 вложенных цикла
//int[] array = {182, 18, 3, 4, 57, 6, 57, 18, 19};

//int n = array.Length;
//int find = 18;
//int index = 0;

//while (index < n)
//{

  //  if(array[index] == find)
    //{
      //  Console.WriteLine(index);
        ///break;

//  index++;

//задача с массивом

int size = 6;
int[] array = new int[size];

for (int i = 0; i < size; i++)  //заполняем массив
{
    Console.WriteLine($"Введите {1+i} число");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < size; i++)
{
    for(int j = 0; j<size; j++)
    {
        if(array[i] == array[j] * array [j]) Console.WriteLine($"Число {i+1} является квадратом числа {j+1}");
    }
}


// пользователь задает с клавиатуры 6 целых чисел. Надо проверить присутствуют ли там квадраты чисел друг друга.
//То есть каждое число надо попарно проверять с остальными.

int size = 6;
int[] numbs = new int[size];
for (int i=0; i<size; i++)
{
    Console.WriteLine($"Введите {1+i} число:");
    numbs[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i=0; i<size; i++)
{
    for (int j=0; j<size; j++)
    {
        if(numbs[i]==numbs[j]*numbs[j]) Console.WriteLine($"Число {i+1} является квадратом числа {j+1}");
    }

}


//Console.WriteLine("Введите первое число");
///int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите второе число");
//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите третье число");
//int num3 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите четвертое число");
//int num4 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите пятое число");
//int num5 = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i<= num; i++) Console.Write($"{i} ");
//