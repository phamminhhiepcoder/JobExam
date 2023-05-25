using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEnglishToVietnamese
{
    class DictionaryEntry
    {
        public string Word { get; set; }
        public List<EntryDefinition> Definitions { get; set; }

        public DictionaryEntry(string word)
        {
            Word = word;
            Definitions = new List<EntryDefinition>();
        }
    }

}
