using System;

class Program
{

    static void Main()
    {
        // Первое ДЗ
        Console.Write("Enter array size: ");
        int ns = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter definition of array:");
        int[] arr = new int[ns];
        for (int i = 0; i < ns; ++i)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr[0], min = arr[0], sum = 0;
        for (int i = 0; i < ns; ++i)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
            sum += arr[i];


        }
        double arif = 1.0 * sum / arr.Length;
        Console.WriteLine($"MAX: {max}");
        Console.WriteLine($"MIN: {min}");
        Console.WriteLine($"SUM: {sum}");
        Console.WriteLine($"MIDDLE: {arif}");
        Console.Write("Singular number: ");
        for (int i = 0; i < ns; ++i)
            if (arr[i] % 2 != 0)
            {
                Console.Write($"{arr[i]} ");
            }

        // Второе ДЗ
        Console.Write("Enter array size: ");
        int nn = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter definition of array:");
        int[] m = new int[nn];
        int[] rez = new int[nn];
        for (int i = 0; i < nn; i++)
        {

            m[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < nn; ++i)
        {
            rez[i] = m[m.Length - i - 1];
        }
        for (int i = 0; i < nn; ++i)
        {
            Console.Write($"{rez[i]} ");
        }

        // Третье ДЗ
        Console.Write("Enter array size: ");
        int.TryParse(Console.ReadLine(), out int n);
        Console.Write("Enter definition of array: ");
        int[] arrr = new int[n];
        for (int i = 0; i < n; ++i)
        {
            arrr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Array: ");
        foreach (int i in arrr)
        {
            Console.Write($"{i} ");
        }
        Console.Write("\nEnter count: ");
        int count = int.Parse(Console.ReadLine());
        Console.Write("Enter index: ");
        int index = int.Parse(Console.ReadLine());


        int[] newArr = new int[count];
        int newArrSize = 0;
        for (int i = index; i < Math.Min(count, n); ++i)
        {
            newArr[newArrSize++] = arrr[i];
        }
        if (newArrSize < count)
        {
            int ostatok = count - newArrSize;
            for (int i = 0; i < ostatok; ++i)
            {
                newArr[newArrSize++] = 1;
            }
        }
        for (int i = 0; i < newArrSize; ++i)
        {
            Console.Write($"This is new array:{newArr[i]} ");
        }
    }

}