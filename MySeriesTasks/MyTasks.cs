using System;
using System.Linq;
using System.Security.Cryptography;

namespace MySeriesTasks
{
    public class MyTasks
    {
        public int Series16(int k, int[] arr)
        {
            int arrayLength = arr.Length;
            Array.Sort(arr, 0, arrayLength - 2);
            return (arr[arrayLength - 2] > k ? arrayLength - 1 : 0);
        }

        static void Series18(int n, int[] arr)
        {
            int k = 0;
            for(int i = k; i < n; i++)
            {
                int curElement = arr[i];
                Console.WriteLine(curElement);
                for (int j = i; j < n; j++)
                {
                    if (j == n - 1)
                    {
                        return;
                    }
                    if (arr[j] != curElement)
                    {
                        i = j - 1;
                        break;
                    }
                }
            }
        }

        static void Series20(int n, int[] arr)
        {
            int amountOfNums = 0;
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(arr[i] < arr[i + 1] ? arr[i] : (int?)null);
                amountOfNums++;
            }
            Console.WriteLine(amountOfNums);
        }

        public int Series22(int n, double[] arr)
        {
            for(int i = 1; i < n; i++)
            {
                if(arr[i] > arr[i - 1])
                    return i+1;
            }
            return 0;
        }

        public int Series24(int n, int[] arr)
        {
            int sum = 0;
            int zeroCounter = 0;
            for(int i = n-1; i>=0; i--)
            {
                if(zeroCounter == 2)
                    return sum;
                if (arr[i] == 0)
                    zeroCounter++;
                else
                    sum += arr[i];
            }
            return 0;
        }

        static void Series26(int k, int n, double[] arr)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(arr[i], k));
            }
        }
        
        static void Series28(int n, double[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(arr[i], n-i));
            }
        }

        static void Series30(int n, int k, int[][] arr)
        {
            for(int i = 0; i < k; i++)
            {
                Console.WriteLine(arr[i].Sum());
            }
        }

        static void Series32(int n, int k, int[][] arr)
        {
            for(int i = 0; i < k; i++)
            {
                Console.WriteLine(Array.IndexOf(arr, 2) + 1);
            }
        }

        static void Series34(int n, int k, int[][] arr)
        {
            for(int i = 0; i < k; i++)
            {
                Console.WriteLine(Array.IndexOf(arr[i], 2) == -1 ? 0 : arr[i].Sum());
            }
        }

        static bool isSorted(int[] arr)
        {
            int[] arrOrig = arr;
            int[] arrSorted = { };
            Array.Sort(arrSorted, 0, arrSorted.Length - 2);
            return (arrOrig == arrSorted);
        } 

        static bool isReversed(int[] arr)
        {
            int[] arrOrig = arr;
            int[] arrReversed = { };
            Array.Sort(arrReversed, 0, arrReversed.Length - 2);
            Array.Reverse(arrReversed, 0, arrReversed.Length - 2);
            return (arrOrig == arrReversed);
        }

        static void Series36(int k, int[][] arr)
        {
            int numOfSortedArrays = 0;
            for(int i = 0; i < k; i++)
            {
                if (isSorted(arr[i]))
                    numOfSortedArrays++;
            }
            Console.WriteLine(numOfSortedArrays);
        }

        static void Series38(int k, int[][] arr)
        {
            for(int i = 0; i < k; i++)
            {
                Console.WriteLine(isSorted(arr[i]) ? 1 : isReversed(arr[i]) ? -1 : 0);
            }
        }



        //ДАЖЕ НЕ СПРАШИВАЙ Я ВСЁ РАВНО НЕ СМОГУ ОТВЕТИТЬ
        static bool doubleIsTooth(double[] arr, int i)
        {
            if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                return true;
            if (arr[i] < arr[i + 1] && arr[i] < arr[i - 1])
                return true;
            return false;
        }

        static int doubleIsSawtoothed(double[] arr)
        {
            for(int i = 1; i < arr.Length-2; i++)
            {
                if (!doubleIsTooth(arr, i))
                    return i + 1;
            }
            return 0;
        }

        static bool intIsTooth(int[] arr, int i)
        {
            if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                return true;
            if (arr[i] < arr[i + 1] && arr[i] < arr[i - 1])
                return true;
            return false;
        }
       
        static int intIsSawtoothed(int[] arr)
        {
            for (int i = 1; i < arr.Length - 2; i++)
            {
                if (!intIsTooth(arr, i))
                    return i + 1;
            }
            return 0;
        }

        static void Series23(int n, double[] arr)
        {
            Console.WriteLine(doubleIsSawtoothed(arr));
        }

        static void Series40(int k, int[][] arr)
        {
            for(int i = 0; i < k; i++)
            {
                Console.WriteLine(intIsSawtoothed(arr[i]) == 0 ? arr[i].Length : intIsSawtoothed(arr[i]));
            }
        }
    }
}