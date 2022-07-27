Console.Write("Введите длину массива, size = ");
int size = Convert.ToInt32(Console.ReadLine());
string [] mass = new string[size];
for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива {i}: ");
        mass[i]  = Console.ReadLine();
    }

newArr(mass);

void newArr (string [] mass)
{
        Console.Write("Массив - [");
        for (int i = 0; i < mass.Length - 1; i++)
        {
            Console.Write($"{mass[i]}, ");
        }
        Console.Write($"{mass[mass.Length - 1]}");
        Console.Write("]");
}
Console.WriteLine();

searchSymbols(mass);

void searchSymbols (string [] mass)
{
    Console.Write("Массив после преобразования - [");
    for (int i = 0; i < mass.Count(); i++)
    {
        if (mass[i].Length <= 3)
        {
        Console.Write($"{mass[i]}, ");  
        }
    }
    Console.Write("]");
}
Console.WriteLine();