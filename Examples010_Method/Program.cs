int[] array = {182, 18, 3, 4, 57, 6, 57, 18, 19};

int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
  
  
    index++;
}