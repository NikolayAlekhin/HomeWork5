/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/



int dimension = GetNumber("Введите размер масива"); 
int[] masiv = InitArray(dimension);
PrintArray(masiv);
int count = 0;

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
        masiv[i]= rnd.Next(100,999);
    }
    return masiv;
}

for (int z = 0; z < masiv.Length; z++)
{
if (masiv[z] % 2 == 0)
count++;
}
Console.WriteLine($"всего {masiv.Length} чисел, {count} из них чётные");
