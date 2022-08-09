while(true){
Console.Write("Введите число a ");
int numbera = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b ");
int numberb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c ");
int numberc = Convert.ToInt32(Console.ReadLine());

if (numbera > numberb)
{
    if (numbera > numberc)
        Console.WriteLine(numbera);
    else
        Console.WriteLine(numberc);
}
else if (numberb > numberc)
    Console.WriteLine(numberb);
else
    Console.WriteLine(numberc);
}