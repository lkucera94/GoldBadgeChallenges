using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Dictionaries
{
    public class DictionaryChallenge
    {
        private Dictionary<int, List<int>> _dictionary = new Dictionary<int, List<int>>();

        public Dictionary<int, List<int>> GetDictionary()
        {
            return _dictionary;
        }

        public int GetSum(int key)
        {
            int total = 0;
            List<int> values = _dictionary[key];
            foreach (int value in values)
            {
                total += value;
            }
            return total;
        }

        public int GetTotalSum()
        {
            int total = 0;
            foreach(KeyValuePair<int, List<int>> pair in _dictionary)
            {
                int pairSum = GetSum(pair.Key);
                total += pairSum;
            }
            return total;
        }
    }
}
