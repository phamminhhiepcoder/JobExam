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
    class EnglishVietnameseDictionary
    {
        private Hashtable hashTable;
        private BinarySearchTree bst;

        public EnglishVietnameseDictionary()
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

        public static EnglishVietnameseDictionary ConvertToDictionary(DataTable dataTable)
        {
            EnglishVietnameseDictionary evd = new EnglishVietnameseDictionary();

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

        public static DataTable ConvertToDataTable(EnglishVietnameseDictionary evd)
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

        public void LookupEntry(string word)
        {
            if (hashTable.ContainsKey(word))
            {
                DictionaryEntry entry = (DictionaryEntry)hashTable[word];
                Console.WriteLine("Từ: " + entry.Word);
                Console.WriteLine("Nghĩa:");
                for (int i = 0; i < entry.Definitions.Count; i++)
                {
                    EntryDefinition definition = entry.Definitions[i];
                    Console.WriteLine((i + 1) + ". Loại từ: " + definition.PartOfSpeech);
                    Console.WriteLine("   Định nghĩa: " + definition.Definition);
                    Console.WriteLine("   Ví dụ: " + definition.Example);
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ trong từ điển.");
            }
        }

        public void SaveDictionary(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                foreach (DictionaryEntry entry in hashTable.Values)
                {
                    writer.WriteLine(entry.Word);
                    writer.WriteLine(entry.Definitions.Count);
                    foreach (EntryDefinition definition in entry.Definitions)
                    {
                        writer.WriteLine(definition.PartOfSpeech);
                        writer.WriteLine(definition.Definition);
                        writer.WriteLine(definition.Example);
                    }
                }
            }

            Console.WriteLine("Đã lưu từ điển vào file.");
        }

        public void LoadDictionary(string fileName)
        {
            hashTable.Clear();
            bst.Clear();

            using (StreamReader reader = new StreamReader(fileName, Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    string word = reader.ReadLine();
                    int definitionCount = int.Parse(reader.ReadLine());
                    DictionaryEntry entry = new DictionaryEntry(word);
                    for (int i = 0; i < definitionCount; i++)
                    {
                        string partOfSpeech = reader.ReadLine();
                        string definition = reader.ReadLine();
                        string example = reader.ReadLine();
                        EntryDefinition entryDefinition = new EntryDefinition
                        {
                            PartOfSpeech = partOfSpeech,
                            Definition = definition,
                            Example = example
                        };
                        entry.Definitions.Add(entryDefinition);
                    }
                    hashTable.Add(word, entry);
                    bst.Insert(word);
                }
            }

            Console.WriteLine("Đã tải từ điển từ file.");
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
