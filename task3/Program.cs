/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */
var rand = new Random();
int i =0;

double [] getRandomArray(int length, double min, double max)
{
    double [] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(rand.NextDouble()+rand.Next(-20, 20), 2);
    } return array;
}
double [] array = getRandomArray(4,0 , 0);
System.Console.WriteLine(string.Join("; ", array));
double min = array[i];
double max = array[i];
for (i = 0; i < array.Length; i++)
{
    if(array[i]<min)
    {
        min=array[i];
    }

    if(array[i]>max)
    {
        max=array[i];
    }
}
double residual = Math.Round(max - min, 2);
/* string min2 = Convert.ToString(min);
string max2 = Convert.ToString(max);
string residual2 = Convert.ToString(residual); */
System.Console.WriteLine($"Минимальное значение = {min} , максимальное значение  = {max} ");
System.Console.WriteLine($"Разница между минимальным и максимальным значением {residual}");