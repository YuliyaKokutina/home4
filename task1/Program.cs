/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных 
чисел в массиве.
[345, 897, 568, 234] -> 2 */

int result = 0;
int[] getRandomArray(int length, int min, int max)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int [] array = getRandomArray(10, 100, 999);
int sum(int [] array)
{for (int j = 0; j < array.Length; j++)
{
    if(array[j]%2 ==0)
{
    result ++;
}
} return result;
}
int count = sum(array);
System.Console.WriteLine(string.Join(", " , array));
System.Console.WriteLine(count);