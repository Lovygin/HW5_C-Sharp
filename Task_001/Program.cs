//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
Random rnd = new Random();
int length = 0;
Console.WriteLine("Please, enter the length to array");
int [] array = new int[length = int.Parse(Console.ReadLine())];
int sumEvenNumbers = 0;
for (int i = 0; i < length; i++)
{
    array[i] = rnd.Next(100, 1000);//Заполняем каждый элемент массва случайным 3-х значным числом
    if(array[i] % 2 == 0) sumEvenNumbers++; Console.WriteLine(array[i]);

}
Console.WriteLine("Sum the even numbers to array = " + sumEvenNumbers);