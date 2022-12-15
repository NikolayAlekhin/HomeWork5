int dimension = GetNumber("Введите размер масива"); 
int[] masiv = InitArray(dimension);
PrintArray(masiv);
int max = 0;
int min=0;

//метод получения числа с консоли
int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }  
    }

return result;
}

//метод печати массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int[]  InitArray(int dimension)
{
     Random rnd= new Random();
    int[] masiv = new int[dimension];
    for (int i = 0; i < dimension; i++)
    {
        masiv[i]= rnd.Next(1,100);
    }
    return masiv;
}

for (int z = 0; z <  masiv.Length; z++)
 {
    if (masiv[z] > max)
        {
            max =masiv[z];
        }
    else
        {
            min =masiv[z];

        }
}

for (int x = 0; x <  masiv.Length; x++)
 {
    if (masiv[x] <min)
        {
            min =masiv[x];
        }
}
 Console.WriteLine($"Минимальное число {min} максимальное число {max}");
 Console.WriteLine ($"Разница между Max числом {max} и Min числом {min} ={max-min}");