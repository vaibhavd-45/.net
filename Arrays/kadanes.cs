using System;

public class KadaneAlgorithm
{
    public static int MaxSubArraySum(int[] arr)
    {
        int maxSoFar = arr[0];
        int maxEndingHere = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        return maxSoFar;
    }

    public static void Main()
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine("Maximum Subarray Sum: " + MaxSubArraySum(arr));
    }
}
