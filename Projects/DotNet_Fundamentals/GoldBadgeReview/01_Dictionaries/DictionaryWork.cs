using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Dictionaries
{
    public class DictionaryWork
    {
        List<string> _list = new List<string>();

        Dictionary<int, string> _dictionary = new Dictionary<int, string>();

        public DictionaryWork()
        {
            _dictionary.Add(1, "First Value");

            _list.Add("First string");
            string zeroIndex = _list[0];
        }

    }
}
