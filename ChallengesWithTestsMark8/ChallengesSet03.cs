using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null) 
            return false;

            return vals.Contains(false); 
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false;

            return numbers.Where(num => num % 2 != 0).Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
           if (password == null)
                return false;

           return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber);
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
            else 
            { 
                return dividend / divisor;  
            }


        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
           return Enumerable.Range(1, 99).Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++) 
            {
                words[i] = words[i]?.ToUpper();
            }
        }
    }
}
