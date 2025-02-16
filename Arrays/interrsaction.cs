using System;
using System.Collections.Generic;

public class ArrayOperations
{
    public static void FindIntersection(int[] arr1, int[] arr2)
    {
        HashSet<int> set1 = new HashSet<int>(arr1);
        HashSet<int> intersection = new HashSet<int>();

        foreach (int num in arr2)
        {
            if (set1.Contains(num))
            {
                intersection.Add(num);
            }
        }

        Console.WriteLine("Intersection: ");
        foreach (int num in intersection)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public static void FindUnion(int[] arr1, int[] arr2)
    {
        HashSet<int> union = new HashSet<int>(arr1);

        foreach (int num in arr2)
        {
            union.Add(num);
        }

        Console.WriteLine("Union: ");
        foreach (int num in union)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        int[] arr1 = { 1, 2, 2, 1 };
        int[] arr2 = { 2, 3, 3, 4 };
        
        FindIntersection(arr1, arr2);
        FindUnion(arr1, arr2);
    }
}
