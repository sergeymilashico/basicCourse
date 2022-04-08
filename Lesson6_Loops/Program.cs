/*talk about using section */
using System.Linq;

//namespace . For logical separation of classes
namespace Lesson6_Loops
{
    class Program
    {
        //Program to show logical operations, primitive data types
        static void Main(string[] args)
        {
            int[] intValues = { 1, 5, 78, 6, 9, 7, 2 };
            //Array.IndexOf(intValues, 5);
            //replace
            intValues[1] = 99;

            //intvalues became { 1, 99, 78, 6, 9, 7, 2 }
            int sum = 0;

            //loop and finding sum
            for (int i = 0; i < intValues.Length; i++)
            {
                sum = sum + intValues[i];
            }
            Console.WriteLine($"Sum of numbers provided : {sum}");

            //you can just simply do Array.Sort(intValues)
            //but we learning loops

            int[] sorted = BubbleSortArray(intValues);
            int[] sortedWithFlag = BubbleSortArrayWithFlag(intValues);

            Console.Write($"Sorted array : ");
            foreach (int number in sorted)
            {
                Console.Write($"\t {number}");
            }
            Console.WriteLine();

            int luckyValue = 7;
            //dont hardcode parameters
            int indexOfElement = FindInArray(sorted, luckyValue);
            //check for -1. If not - element found. Write index. Remember - everything starting from 0!
            if (indexOfElement != -1)
            {
                Console.Write($"Array has element {luckyValue} at position {indexOfElement} ");
            }
            else
            {
                Console.Write($"Array does not have element {luckyValue}");
            }

            //string interpolation
            //who has maximum salry in department
            Console.WriteLine($"LINQ. Maximum element in array : {intValues.Max()}");

            //lets get average body temerature in the hospital )
            Console.WriteLine($"LINQ. Average value of element in array : {intValues.Average()}");

            //how much times it takes to finish project if complete all tasks
            Console.WriteLine($"SUM. Sum of elements in array : {intValues.Sum()}");

            int[] intValuesNew = { 1, 5, 78, 6, 9, 7, 2 };
            Array.Sort(intValuesNew);
        }

        private static int[]? EnterArray()
        {
            Console.WriteLine("Please enter comma separated int values : ");
            string valuesString = Console.ReadLine();
            //check if string has value
            if (!string.IsNullOrEmpty(valuesString))
            {
                //method to split array by elements
                string[] stringValues = valuesString.Split(',');
                int[] intValues = new int[stringValues.Length];
                for (int i = 0; i < stringValues.Length; i++)
                {
                    //Do converting to integer to use later for sort and find
                    intValues[i] = Convert.ToInt32(stringValues[i]);
                }
                return intValues;
            }

            else return null;
        }

        //separate method for sorting
        //using PascalCase
        //https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/capitalization-conventions


        private static int[] BubbleSortArray(int[] numbers)
        {

            //int[] intValues = { 1, 99, 78, 6, 9, 7, 2 };
            //Math.pow((7-1), 2) = 36
            //iteration 1 : 1, 99, 78, 6, 9, 7, 2
            //iteration 2 : 1, 99, 78, 6, 9, 7, 2
            //iteration 3 : 1, 78, 99, 6, 9, 7, 2
            //iteration 4 : 1, 78, 6, 99, 9, 7, 2
            //iteration 5 : 1, 78, 6, 9, 99, 7, 2
            //iteration 6 : 1, 78, 6, 9, 7, 2, 99

            //sorted iter 36 : 1, 2, 6, 7, 9, 78, 99

            //Then start another outer circle

            int iteration = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                //intArray.Length - 2
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    iteration++;
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            Console.WriteLine($"BubbleSortArray. Total number of iterations = {iteration}");
            return numbers;
        }

        private static int[] BubbleSortArrayWithFlag(int[] numbers)
        {

            //int[] intValues = { 1, 99, 78, 6, 9, 7, 2 };
            //Math.pow((7-1), 2) = 36
            //But in case array is sorted we have just (N-1) = 6 iterations 
            //iteration 1 : 1, 2, 6, 7, 9, 78, 99
            //iteration 2 : 1, 2, 6, 7, 9, 78, 99
            //iteration 3 : 1, 2, 6, 7, 9, 78, 99
            //iteration 4 : 1, 2, 6, 7, 9, 78, 99
            //iteration 5 : 1, 2, 6, 7, 9, 78, 99
            //iteration 6 : 1, 2, 6, 7, 9, 78, 99
            //flag = false . So array is sorted . Leaving

            bool flag = true;
            int temp;

            int iteration = 0;

            //sorting an array  
            for (int i = 1; i <= numbers.Length - 1 && flag; i++)
            {
                //flag = false by default so we exit loop if no changes done
                flag = false;
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    iteration++;
                    if (numbers[j + 1] < numbers[j])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            Console.WriteLine($"BubbleSortArrayWithFlag. Total number of iterations = {iteration}");
            return numbers;
        }

        //find element in array
        private static int FindInArray(int[] numbers, int elem)
        {
            int index = -1;
            //use var here
            var numbersIndex = 0;


            while (true)
            {
                //return index of elem if found
                if (numbers[numbersIndex] == elem) return numbersIndex;
                //continue till last element of numbers
                //if this is last one we need to break
                //but also check if last element is not the right one
                if (numbersIndex == numbers.Length - 1 && numbers[numbersIndex] != elem)
                {
                    numbersIndex = -1;
                    break;
                };
                numbersIndex++;
            }

            index = numbersIndex;
            return index;
        }
    }
}
