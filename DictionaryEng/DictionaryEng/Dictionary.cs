using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEnglishToVietnamese
{
    class Dictionary
    {
        private Hashtable hashTable;
        private BinarySearchTree bst;
    
        public Dictionary()
        {
            hashTable = new Hashtable();
            bst = new BinarySearchTree();
        }

        public void AddEntry(string word, string partOfSpeech, string definition, string example)
        {
            if (hashTable.ContainsKey(word))
            {
                DictionaryEntry entry = (DictionaryEntry)hashTable[word];
                EntryDefinition entryDefinition = new EntryDefinition
                {
                    PartOfSpeech = partOfSpeech,
                    Definition = definition,
                    Example = example
                };
                entry.Definitions.Add(entryDefinition);
            }
            else
            {
                DictionaryEntry entry = new DictionaryEntry(word);
                EntryDefinition entryDefinition = new EntryDefinition
                {
                    PartOfSpeech = partOfSpeech,
                    Definition = definition,
                    Example = example
                };
                entry.Definitions.Add(entryDefinition);

                hashTable.Add(word, entry);
                bst.Insert(word);
            }

            Console.WriteLine("Đã thêm mục từ vào từ điển.");
        }

        public static Dictionary ConvertToDictionary(DataTable dataTable)
        {
            Dictionary evd = new Dictionary();

            foreach (DataRow row in dataTable.Rows)
            {
                string word = row["Word"].ToString();
                string partOfSpeech = row["PartOfSpeech"].ToString();
                string meaning = row["Meaning"].ToString();
                string example = row["Example"].ToString();

                evd.AddEntry(word, partOfSpeech, meaning, example);
            }

            return evd;
        }

        public static DataTable ConvertToDataTable(Dictionary evd)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Word");
            dataTable.Columns.Add("PartOfSpeech");
            dataTable.Columns.Add("Meaning");
            dataTable.Columns.Add("Example");

            foreach (DictionaryEntry entry in evd.GetEntries())
            {
                foreach (EntryDefinition definition in entry.Definitions)
                {
                    dataTable.Rows.Add(entry.Word, definition.PartOfSpeech, definition.Definition, definition.Example);
                }
            }

            return dataTable;
        }

        public void RemoveEntry(string word)
        {
            if (hashTable.ContainsKey(word))
            {
                hashTable.Remove(word);
                bst.Delete(word);
                Console.WriteLine("Đã loại bỏ mục từ khỏi từ điển.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ trong từ điển.");
            }
        }
        public IEnumerable<DictionaryEntry> GetEntries()
        {
            foreach (DictionaryEntry entry in hashTable.Values)
            {
                yield return entry;
            }
        }

        public DataTable ConvertToDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Word");
            dataTable.Columns.Add("PartOfSpeech");
            dataTable.Columns.Add("Meaning");
            dataTable.Columns.Add("Example");

            foreach (DictionaryEntry entry in hashTable.Values)
            {
                foreach (EntryDefinition definition in entry.Definitions)
                {
                    dataTable.Rows.Add(entry.Word, definition.PartOfSpeech, definition.Definition, definition.Example);
                }
            }

            return dataTable;
        }
    }
}
