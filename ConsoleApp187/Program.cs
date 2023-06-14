using System;

public static class Program
{
    public static void Main()
    {
        Console.Write("Anzahl der zu sortierenden Zahlen: ");
        int count = int.Parse(Console.ReadLine());

        int[] array = new int[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Zahl {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Unsortiertes Array:");
        PrintBarChart(array);

        BubbleSort(array);

        Console.WriteLine("Sortiertes Array:");
        PrintBarChart(array);

        Console.ReadKey();
    }

    public static void BubbleSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Tausche die Elemente
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }

                // Aktualisiere die Visualisierung
                PrintBarChart(array);
            }
        }
    }

    public static void PrintBarChart(int[] array)
    {
        int maxBarLength = 50;
        int maxNum = GetMaxValue(array);
        double scale = maxBarLength / (double)maxNum;

        Console.Clear();
        foreach (int num in array)
        {
            int barLength = (int)(num * scale);
            string bar = new string('#', barLength);
            Console.WriteLine($"{num,4} | {bar}");
        }
        Console.WriteLine();
    }

    public static int GetMaxValue(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}
