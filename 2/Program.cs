/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/



int dimension = GetNumber("Введите размер масива"); 
int[] masiv = InitArray(dimension);
PrintArray(masiv);
int sum=0;

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
        masiv[i]= rnd.Next(1,10);
    }
    return masiv;
}

for (int z = 1; z <  masiv.Length; z+=2)
 {   
    sum = sum +  masiv[z];
 }
    Console.WriteLine($"всего { masiv.Length} чисел, сумма элементов на нечётных позициях = {sum}");
