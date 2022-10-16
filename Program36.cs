// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int size;
Console.Write("Введите размер массива (N): ");
size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int count = 0;
Console.Write("[ ");
ArrayRandomNumbers(numbers);
Console.Write("]");

for (int i = 1; i < size; i+=2)
{
    count += numbers[i];
}
Console.WriteLine($" -> {count} ");

void ArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,10);
        Console.Write(array[i] + "; ");
    }
}