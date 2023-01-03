using System.Text.Json.Serialization;

namespace SortingAlgorithms;

public class Program
{
    static void Main(string[] args)
    {
        int[] array = { 8, 2, 5, 1, 6 };


    }

    public static int[] BubbleSort(int[] array)
    {
        int[] output = array;

        for (int i = 1; i < array.Length; i++)
        {
            for(int j = 1; j < array.Length; j++)
            {
                if (output[j - 1] > output[j])
                {
                    int temp = output[j - 1];
                    output[j - 1] = output[j];
                    output[j] = temp;
                }
            }

            if (output[i - 1] > output[i])
            {
                int temp = output[i-1];
                output[i-1] = output[i];
                output[i] = temp;
            }
        }

        return output;
    }
}