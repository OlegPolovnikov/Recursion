//Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void OutputRange(int m, int n) 
{
if (n > m + 1)
{
    OutputRange(m, n - 1);
    Console.Write(n - 1 + " ");    
}
}
Console.WriteLine("Введите значение нижней границы m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение верхней границы n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Натуральные числа в промежутке от m до n: ");
OutputRange(m, n);


//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

int A(int n, int m) 
{
    if (n == 0) return m + 1;
    else if ((n != 0) && (m == 0)) return A(n - 1, 1);
    else return A(n - 1, A(n, m - 1));
}
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("A = " + A(n, m));


//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
//Использовать рекурсию, не использовать циклы.

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