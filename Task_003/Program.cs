//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

/*Console.Clear();
Random rnd = new Random();
int length = 0;
Console.WriteLine("Please, enter the length to array");
double [] array = new double[length = int.Parse(Console.ReadLine())];
double min = array[0];
double max = array[0];
for (int i = 0; i < length; i++)
{
    array[i] = rnd.Next(17, 10000);
    Console.WriteLine(array[i]);
}
for (int i = 0; i < length; i++)
{
    if(array[i] < min) min = array[i];
    else if(array[i] > max) max = array[i]; 
}
double result = max - min;
Console.WriteLine("Difference between max value and min value = " + result);*/




Console.Clear();

Random rnd = new Random();
double minValue = 17.00;//Обозначаю диапазон рандомных чисел для массива дробных значений
double maxValue = 9999.00;//Обозначаю диапазон рандомных чисел для массива дробных значений

int length = 0;
Console.WriteLine("Please, enter the length to array");
double [] array = new double[length = int.Parse(Console.ReadLine())];

double min = array[0];
double max = array[0];
for (int i = 0; i < length; i++)// Можно не создавать 2 цикла, проверить максимум и минимум на моменте заполнения массива
{
    array[i] = minValue + (maxValue - minValue) * rnd.NextDouble();//Задаем рандомные дробные числа для array[i];
    if(array[i] < min) min = array[i];
    else if(array[i] > max) max = array[i]; 
    Console.WriteLine(Math.Round(array[i], 2));
    
}    
double result = max - min;
Console.WriteLine("Difference between max value and min value = " + Math.Round(result, 2));//округляем число до 2-х знаков полсе запятой