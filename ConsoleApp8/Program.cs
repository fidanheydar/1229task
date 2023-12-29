using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            GetSquare(ref number);
            Console.WriteLine(number);

            int[] arr = new int[] { 1, 2, 3,};
            GetSquareArr(ref arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            string name = "   Fidan   Heydarova  ";
            DeleteSpace(ref name);
            Console.WriteLine(name);

            int[] nums = new int[] { 1,2,3,};
            InsertElement(ref nums, 6);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }





        static void GetSquare(ref int number)

        {
            number = number * number;
        }

        static void GetSquareArr(ref int[] numArr)
        {
            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = numArr[i] * numArr[i];
            }
        }

        static void DeleteSpace(ref string text)
        {
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    newText += text[i];
                }
            }
            text = newText;
        }

        static void InsertElement(ref int[] numArr, int element)
        {
            int[] newArr = new int[numArr.Length + 1];
            for (int i = 0; i < numArr.Length; i++)
            {
                newArr[i] = numArr[i];
            }
            newArr[newArr.Length - 1] = element;
            numArr = newArr;
        }

    }
}
