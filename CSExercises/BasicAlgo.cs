using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class BasicAlgo
    {
        public int SumOfTwo(int x, int y)
        {
            //Write a C# Sharp program to compute the sum of the two given integer values.
            //If the two values are the same, then return triple their sum.
            return x == y ? (x * y) : x + y;
        }

        public int AbsoluteDifference(int input)
        {
            //get the absolute difference between n and 51.
            //If n is greater than 51 return triple the absolute difference.
            const int x = 51;
            return input > x ? (input - x) * 3 : x - input;

        }

        public string LastCharAdd(string input)
        {
            //Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.
            if (input.Length > 1)
            {
                var lastChar = input.Substring(input.Length - 1);
                return lastChar + input + lastChar;

            }

            throw new ArgumentException("Input must be larger than 1");
        }

        public bool AreInRange(int x, int y)
        {
            var range = new List<int>();
            range.Add(40);
            range.Add(50);
            
            var numbers = new List<int>();
            numbers.Add(x);
            numbers.Add(y);

            foreach(var currentRange in range)
            {
                if (numbers[0] >= currentRange)
                {
                    if (Math.Abs(numbers[0] - numbers[1]) < 10)
                    { return true; }
                }
            }

            return false;

        }

        public string CreateStringLikeaababcabcd(string input)
        {
            //Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd"

            var finalString = string.Empty;
            for (int i = 0; i <= input.Length - 1; i++)
            {
                finalString += input.Substring(0, i + 1);

            }
            return finalString;
        }

        public int SumOfTwoQ40(int x, int y)
        {
            //q40 Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30.
            return x + y >= 10 && x + y <= 20 ? 30 : x + y;
        }

        public bool IsRightMostSameQ50(List<int> numberList)
        {
            //Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit.
            if (numberList == null)
            {
                throw new ArgumentNullException();
            }


            List<int> remainderList = new();

            foreach(int number in numberList)
            {
                int remainder = number % 10;
                remainderList.Add(remainder);

                if(remainderList.Count > 0 && remainderList[0] != remainder )
                {
                    return false;
                }                
            }
            return true;
        }

        public string CreateANewStringQ60(string s1, string s2)
        {
            return $"{s1}{s2}{s2}{s1}";
        }

        public string CreateNewStringWOFirstAndLastQ70(string inputString)
        {
            //Write a C# Sharp program to create a new string without the first and last character of a given string of any length
            if (inputString.Length < 3)
            {
                throw new Exception("String must be longer than atleast 3 characters");
            }
            return inputString.Substring(1, inputString.Length - 2);
        }

        public string IsStringStartsWithAbcOrXyzQ80(string inputString)
        {
            //Write a C# Sharp program to check if a given string begins with 'abc' or 'xyz'.
            //If the string begins with 'abc' or 'xyz' return 'abc' or 'xyz' otherwise return the empty string
            var matchList = new List<string> { "abc", "xyz" };
            if(inputString.Length < 3)
            {
                return string.Empty;
            }

            var firstLetters = inputString.Substring(0, 3);

            if (matchList.Contains(firstLetters.ToLower())){
                return firstLetters;
            }
            return string.Empty;
        }

        public bool IsTwoArraysHaveSameFirstOrLastQ90(List<int> array1, List<int> array2)
        {
            //Write a C# Sharp program to check two given arrays of integers of length 1
            //or more and return true if they have the same first element or they have the same last element.
            bool startElements = array1[0] == array2[0];
            bool lastElements = array1.LastOrDefault() == array2.LastOrDefault();
            return startElements || lastElements;
        }

        public bool IsArrayHas10Or20TwiceQ100(List<int> inputList)
        {
           var digitList = new List<int> { 10, 20 };

            foreach(int digit in digitList)
            {
                var returned = inputList.FindAll((x) => { return x == digit; });
                if(returned.Count() > 1) return true;
            }

            return false;
           
        }

        public int SumIfNot17Q110(List<int> numberList)
        {
            //Write a C# Sharp program to compute the difference
            //between the largest and smallest values in a given array of integers and length one or more.
            var arraywo17 = numberList.FindAll((x) => { return x != 17; });
            return arraywo17.Sum();
        }

        public bool CheckIf5NextToEachOther120(List<int> inputArray)
        {
            //Write a C# Sharp program to check a given array of integers and return true
            //if the given array contains two 5's next to each other, or two  5 separated by one element. 
            if (inputArray.Count == 0) return false;

            int firstIndex = inputArray.FindIndex((x) => x == 5);
            int secondIndex = inputArray.FindIndex(firstIndex + 1, (x) => x == 5);
            return  2 > secondIndex - firstIndex ? true : false;
        }

        public List<int> ShiftAllZerosToLeftQ130(List<int> inputArray)
        {
            //Write a C# Sharp program to create a new array
            //from a given array of integers shifting all zeros to left direction
            var arrayWithoutZeros = inputArray.FindAll((x) => x != 0);
            var arrayWithZeros = inputArray.FindAll((x) => x == 0);
            var outputList = new List<int>();
            outputList.AddRange(arrayWithZeros);
            outputList.AddRange(arrayWithoutZeros);
            return outputList;

        }

        public List<int> CreateNewOddArrayQ140(List<int> inputArray, int length)
        {
            //Write a C# Sharp program to create a new array of given
            //length using the odd numbers from a given array of positive integers
            var output = inputArray.Where((x) =>
             {
                 return x % 2 != 0;
             }).ToList();

            return output.Take(length).ToList();
        }

        public List<int> CreateListExceptEndWith7Q150(List<int> InputArray)
        {
            //Write a C# Sharp program to create a new list from a given list of integers removing those values end with 7.
            if (InputArray == null) throw new ArgumentNullException();
           return InputArray.Where((x) =>
            {
               return  x != 7 && x % 10 != 7;
            }).ToList();
        }

    }
}
