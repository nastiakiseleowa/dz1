Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;

Console.Write("Четные числа от 1 до N: ");

while (i < n)
{
    Console.Write(i);
    i = i + 2;
    if (i < n)
        Console.Write(", ");
    else
        Console.Write(".");
}