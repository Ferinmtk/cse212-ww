using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create a new array of size 'length' to hold the result.
        double[] result = new double[length];

        // Step 2: Loop from i = 0 up to (but not including) 'length'.
        for (int i = 0; i < length; i++)
        {
            // Step 3: For each i, calculate number * (i + 1).
            result[i] = number * (i + 1);
        }

        // Step 4: Return the populated array.
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount is 3, 
    /// the result should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Determine the size of the original list.
        int n = data.Count;

        // Step 2: Use GetRange to get the last 'amount' elements.
        List<int> tail = data.GetRange(n - amount, amount);

        // Step 3: Remove the last 'amount' elements from the original list.
        data.RemoveRange(n - amount, amount);

        // Step 4: Insert the extracted elements at the start (index 0).
        data.InsertRange(0, tail);
    }
}
