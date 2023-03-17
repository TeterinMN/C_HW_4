Console.Clear();
Console.WriteLine("Введите два числа: ");
int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);
int result = x;


for (int i = 1; i < y; i++)
{
    result = result * x;
}
 Console.WriteLine(result);