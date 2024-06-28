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