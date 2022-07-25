using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return vals.Length % 2 == 0;//
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return number % 2 == 0;//
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;    
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max(); 
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;

            //var list = new List<int>() {str1.Length, str2.Length};
            //return list.Min
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            foreach(var item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            return numbers == null || numbers.Length == 0 ? 0 : numbers.Where(x => x % 2 == 0).Sum();

        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers != null && numbers.Count != 0 && numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number <= 0 ? 0 : number / 2; 
        }
    }
}
