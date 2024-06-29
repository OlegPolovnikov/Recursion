
int[] RandomArray (int n)
{
    int[] array = new int[n];
     Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100);
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();

}

void PrintArrayInverse (int[] array, int n)
{
    if (n > 0)
    {
        Console.Write(array[n - 1] + " ");
        PrintArrayInverse(array, n - 1);
    }
}

Console.WriteLine("Введите размер одномерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomArray(n);
Console.Write("Создан произвольный массив из " + n + " элементов: ");
PrintArray(myArray);
Console.Write("Выведены элементы массива из " + n + " элементов, начиная с конца: ");
PrintArrayInverse(myArray, n);
 



