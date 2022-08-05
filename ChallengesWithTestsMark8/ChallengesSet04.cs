using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() { number1, number2, number3, number4 };
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 &&
            sideLength1 + sideLength3 > sideLength2 &&
            sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out _);
                return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;
            var count = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }
            return count >= majority;
        }

        public double AverageEvens(int[] numbers)
        {

            //return Queryable.Average(numbers.AsQueryable().Where(x => x % 2 == 0));
            //(x => x % 2 == 0)

            return numbers == null || numbers.Length == 0
                    ? 0 : numbers.Where(x => x % 2 == 0).Count() == 0
                    ? 0 : numbers.Where(x => x % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
            var fact = 1;

            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = number; i > 0; i--)
            {
                fact *= i; ;
            }
            return fact;
        }
    }
}