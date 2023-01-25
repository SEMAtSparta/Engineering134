using System.Globalization;
using System.Xml;

namespace MergeSort;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static int[] MergeSort(int[] inputArray)
    {
        int[] output;
        if (inputArray.Length <= 1)
        {
            return inputArray;
        }
        else
        {
            Split(inputArray, out int[] arr1, out int[] arr2);
            output = Merge(MergeSort(arr1), MergeSort(arr2));
        }
        return output;
    }

    public static void Split(int[] inputArray, out int[] outputArray1, out int[] outputArray2)
    {
        int output1Length = inputArray.Length / 2;
        int output2Length = inputArray.Length - output1Length;

        outputArray1 = new int[output1Length];
        outputArray2 = new int[output2Length];

        Array.Copy(inputArray, outputArray1, output1Length);
        Array.Copy(inputArray, output1Length, outputArray2, 0, output2Length);
    }

    public static int[] Merge(int[] arr1, int[] arr2)
    {
        int totalLength = arr1.Length + arr2.Length;
        int[] outputArray = new int[totalLength];

        int arr1Index = 0;
        int arr2Index = 0;

        for(int i = 0; i < totalLength; i++)
        {
            if (arr1Index == arr1.Length)
            {
                outputArray[i] = arr2[arr2Index];
                arr2Index++;
            }
            else if(arr2Index == arr2.Length)
            {
                outputArray[i] = arr1[arr1Index];
                arr1Index++;
            }
            else
            {
                if (arr1[arr1Index] > arr2[arr2Index])
                {
                    outputArray[i] = arr2[arr2Index];
                    arr2Index++;
                }
                else
                {
                    outputArray[i] = arr1[arr1Index];
                    arr1Index++;
                }
            }
        }
        return outputArray;
    }
}