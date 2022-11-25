void FillArray(int[] collection) //void метод, который ничего не возвращает
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);

        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  //значение -1 будет показывать, что элемент не найден, если искомого значения не существует

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //"создай новый массив, в котором будет 10 элементов (по умолчанию будет заполнен 0)"


FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = Index0f(array, 444);
Console.WriteLine(pos);