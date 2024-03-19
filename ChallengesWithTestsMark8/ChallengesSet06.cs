using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if(string.Equals(words, null) || words.Contains(null)) 
            {
                return false;
            }

            if(ignoreCase == true) 
            { 
                word = word.ToLower();

                List<string> lc = words.Select(x => x.ToLower()).ToList();

                containsWord = lc.Contains(word);
            }

            if(ignoreCase == false) 
            { 
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; 
                }
            }

            return true; 
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (charFrequency.ContainsKey(c))
                {
                    charFrequency[c]++;
                }
                else
                {
                    charFrequency[c] = 1;
                }
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
               
                if (charFrequency[c] == 1)
                {
                    return i;
                }
            }
            return -1; 
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCount = 0;
            int currentCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }
            }
            maxCount = Math.Max(maxCount, currentCount);

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new List<double>();
            if(elements == null || n <= 0 || n > elements.Count) 
            { 
                return nthElement.ToArray();
            }
            for(var i = n - 1; i < elements.Count; i += n) 
            {
                nthElement.Add(elements[i]);
            }
            return nthElement.ToArray();
        }
    }
}
