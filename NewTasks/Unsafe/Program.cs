using System;

class Program
{
    unsafe static void Main(string[] args) 
    {
        int* arr = stackalloc int[10];
        Console.WriteLine("Enter arrays elements");
        for (int i = 0; i < 10; ++i)
        {
            Console.Write($"{i+1}) ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int maxId = 0;

        for (int i = 1; i < 10; ++i)
        {
            if (arr[i] > arr[maxId])
            {
                maxId = i;
            }
        }

        Console.WriteLine($"Maximum element: {arr[maxId]}\nIndex: {maxId}");

    }
}