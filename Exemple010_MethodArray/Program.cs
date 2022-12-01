int[] array = { 12, 18, 3, 4, 5, 6, 7, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // прерывает, когда нашел первый элемент
    }
    index++;
}