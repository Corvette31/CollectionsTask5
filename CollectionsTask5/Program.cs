using System;
using System.Collections.Generic;

namespace CollectionsTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 5;
            string[] array1 = CreateArray(arraySize);
            arraySize = 3;
            string[] array2 = CreateArray(arraySize);

            Show(array1);
            Console.Write(" + ");
            Show(array2);

            var mergeList = MergeArraysInCollection(array1, array2);
            Console.Write(" => ");
            Show(mergeList);
        }

        static string[] CreateArray(int arraySize)
        {
            Random random = new Random();
            int maxValue = 10;
            string[] array = new string[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = Convert.ToString(random.Next(maxValue));
            }

            return array;
        }

        static void Show(string[] array)
        {
            Console.Write('{');

            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    Console.Write($"\"{array[i]}\", ");
                }
                else
                {
                    Console.Write($"\"{array[i]}\"}}");
                }
            }
        }

        static void Show(List<string> mergeList)
        {
            Console.Write('{');
            int index = 1;

            foreach (var number in mergeList)
            {
                if (index != mergeList.Count)
                {
                    Console.Write($"\"{number}\", ");
                }
                else
                {
                    Console.Write($"\"{number}\"}}");
                }
                index++;
            }
        }

        static List<string> MergeArraysInCollection(string[] array1, string[] array2)
        {
            List<string> mergeList = new List<string>();
            ArrayToCollection(array1, mergeList);
            ArrayToCollection(array2, mergeList);

            return mergeList;
        }

        static void AddInCollection(string value, List<string> mergeList)
        {
            if (mergeList.Contains(value) == false)
            {
                mergeList.Add(value);
            }
        }

        static void ArrayToCollection(string[] array, List<string> mergeList)
        {
            for (int i = 0; i < array.Length; i++)
            {
                AddInCollection(array[i], mergeList);
            }
        }
    }
}
