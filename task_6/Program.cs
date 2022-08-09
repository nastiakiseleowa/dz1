Console.Write("Введите число a ");
int numbera = Convert.ToInt32(Console.ReadLine());

if (Convert.ToBoolean(numbera % 2)) // число нечетное
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("да"); // число четное
}


/*
Console.Write ("Введите число a ");
int numbera = Convert.ToInt32(Console.ReadLine());
int a = numbera / 2;
int b = (numbera + 1) / 2;

if (a==b)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");
*/
