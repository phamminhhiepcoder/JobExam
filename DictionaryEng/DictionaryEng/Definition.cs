using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEng
{
    public class Definition
    {
        public string Type { get; set; }
        public string Meaning { get; set; }
        public string Example { get; set; }

        public Definition(string type, string meaning, string example)
        {
            Type = type;
            Meaning = meaning;
            Example = example;
        }
    }
}
