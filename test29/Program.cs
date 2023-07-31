// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

FillArray(array);

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = rnd.Next(-99, 100);
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(" -> [{0}]", string.Join(", ", arr));
}