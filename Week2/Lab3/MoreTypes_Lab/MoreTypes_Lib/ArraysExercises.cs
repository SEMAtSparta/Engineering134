using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace MoreTypes_Lib;

public class ArraysExercises
{
    // returns a 1D array containing the contents of a given List
    public static string[] Make1DArray(List<string> contents)
    {
        int length = contents.Count;
        string[] output = new string[length];

        for(int i = 0; i < length; i++)
        {
            output[i] = contents[i];
        }
        return output;
    }

    // returns a 3D array containing the contents of a given List
    public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
    {
        if(length1 + length2 + length3 != contents.Count)
        {
            throw new ArgumentException("Number of elements in list must match array size");
        }

        string[,,] output = new string[length1, length2, length3];
        int index = 0;
        for(int x = 0; x < length1; x++)
        {
            for (int y = 0; y < length2; y++)
            {
                for (int z = 0; z < length3; z++)
                {
                    output[x, y, z] = contents[index];
                    index
                }
            }
        }
        return output;
    }

    // returns a jagged array containing the contents of a given List
    public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
    {
        if((countRow1 + countRow2) != contents.Count){
            throw new ArgumentException("Number of elements in list must match array size");
        }
        string[][] output = new string[2][];
        output[0] = new string[countRow1];
        output[1] = new string[countRow2];

        int index = 0;
        foreach(string element in contents)
        {
            if(index < countRow1)
            {
                output[0][index] = element;
            }
            else
            {
                output[1][index - countRow1] = element;
            }
            index++;
        }
        return output;
    }
}
