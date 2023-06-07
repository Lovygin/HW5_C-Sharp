//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.


Console.Clear();
Random rnd = new Random();
int length = 0;
Console.WriteLine("Please, enter the length to array");
int [] array = new int[length = int.Parse(Console.ReadLine())];
int sumNumbersOnOddPosition = 0;
for (int i = 0; i < length; i++)
{
    array[i] = rnd.Next(17, 10000);
    if(i % 2 == 1) 
    {   
        sumNumbersOnOddPosition += array[i]; 
        Console.WriteLine(array[i]);
    }
}
Console.WriteLine("Sum of numbers on the odd position = " + sumNumbersOnOddPosition);