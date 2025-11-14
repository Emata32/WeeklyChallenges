using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }
            return sum % 2 != 0;

            //return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 !=0;
        } 
           

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            bool isUppercase = password.Any(char.IsUpper);
            bool isLowercase = password.Any(char.IsLower);
            bool isNumber = password.Any(char.IsDigit);
            
            return isUppercase && isLowercase && isNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {    // for future refence 
            
             //int[] numbers = new int[50];
             //int index = 0; 
             
            var odds = new List<int>();
             
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                   //numbers[index] = i;
                   //index++;
                   
                   odds.Add(i);
                }
            }
            //return numbers;
            return odds.ToArray();
            
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
            
        }
    }
}
