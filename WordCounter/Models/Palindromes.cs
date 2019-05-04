using System;
using System.Collections.Generic;

namespace Palindromes
{
    public class Palindrome
    {
        private string _phrase;
        private bool _isPalindrome;
        private int _id;
        public static List<Palindrome> _instances = new List<Palindrome> {};

        public Palindrome(string phrase, bool IsPalindrome)
        {
            _phrase = phrase;
            _isPalindrome = IsPalindrome;
            _instances.Add(this);
            _id = _instances.Count;
        }
        public string GetPhrase()
        {
            return _phrase;
        }
        public void SetPhrase(string phrase)
        {
            _phrase = phrase;
        }
        public int GetId()
        {
            return _id;
        }
        public bool GetIsPalindrome()
        {
            return _isPalindrome;
        }
        public static void Clear()
        {
            _instances.Clear();
        }
        public bool IsPalindromeTest()
        {
            string phrase = GetPhrase();
            if (phrase.Length == 1)
            {
                return true;
            }
            // Need to declare string variable here, even though we're doing a new string later
            string reversedPhraseStr;
            char[] reversedPhrase = phrase.ToCharArray();
            Array.Reverse(reversedPhrase);
            reversedPhraseStr = new string(reversedPhrase);
            bool test = phrase.Equals(reversedPhraseStr, StringComparison.OrdinalIgnoreCase);
            if (test) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}