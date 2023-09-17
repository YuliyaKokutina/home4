/* 
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
int sum = 0;
int[] getRandomArray(int length, int min, int max)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int [] array = getRandomArray(4, 10, 99);
int getSum( int [] array)
{
for (int i = 0; i < array.Length; i++)
{
    if(i%2 !=0)
    {
        sum = sum + array[i];
    }
} return sum;}
int result = getSum(array);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(result);