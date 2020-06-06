using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StringDataAPI
{
    public class StringData
    {
        private string _rawInputString = string.Empty;

        public bool IsPalindrome { get; set; }

        public CharacterCount[] SortedCharacterCount { get; set; }

        public DateTime TimeStamp { get; set; }

        public StringData(string inputString)
        {
            _rawInputString = inputString;
            IsPalindrome = CalculateIsPalindrome();
            TimeStamp = DateTime.Now;
            CalculateCharacterCountFromInput();
        }

        private void CalculateCharacterCountFromInput()
        {
            if(!string.IsNullOrEmpty(_rawInputString))
            {
                var listOfCharactersQuery =  _rawInputString.GroupBy(c => c).Select(c => new CharacterCount{character = c.Key, count = c.Count()});
                SortedCharacterCount = listOfCharactersQuery.OrderBy(c => c.character).ToArray();
            }
        }

        private bool CalculateIsPalindrome()
        {
            return _rawInputString.SequenceEqual(_rawInputString.Reverse());
        }
    }
}
