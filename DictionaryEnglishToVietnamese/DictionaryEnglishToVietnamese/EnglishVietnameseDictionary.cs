using System;
using System.Collections;
using System.Collections.Generic;
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
    }
}
