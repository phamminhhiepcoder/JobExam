using DictionaryEnglishToVietnamese;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        EnglishVietnameseDictionary dictionary = new EnglishVietnameseDictionary();

        while (true)
        {
            Console.WriteLine("======= TỪ ĐIỂN ANH-VIỆT =======");
            Console.WriteLine("1. Thêm mục từ mới");
            Console.WriteLine("2. Loại bỏ mục từ");
            Console.WriteLine("3. Tra cứu mục từ");
            Console.WriteLine("4. Lưu từ điển vào file");
            Console.WriteLine("5. Tải từ điển từ file");
            Console.WriteLine("6. Kết thúc chương trình");
            Console.WriteLine("================================");
            Console.Write("Vui lòng chọn chức năng (1-6): ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Nhập từ mới: ");
                    string newWord = Console.ReadLine();
                    Console.Write("Nhập loại từ (danh từ, động từ, tính từ): ");
                    string partOfSpeech = Console.ReadLine();
                    Console.Write("Nhập định nghĩa: ");
                    string definition = Console.ReadLine();
                    Console.Write("Nhập ví dụ: ");
                    string example = Console.ReadLine();
                    dictionary.AddEntry(newWord, partOfSpeech, definition, example);
                    Console.WriteLine();
                    break;
                case "2":
                    Console.Write("Nhập từ cần loại bỏ: ");
                    string wordToRemove = Console.ReadLine();
                    dictionary.RemoveEntry(wordToRemove);
                    Console.WriteLine();
                    break;
                case "3":
                    Console.Write("Nhập từ cần tra cứu: ");
                    string wordToLookup = Console.ReadLine();
                    dictionary.LookupEntry(wordToLookup);
                    Console.WriteLine();
                    break;
                case "4":
                    string saveFileName = "C:\\Users\\Administrator\\Desktop\\C# Projects\\DictionaryEnglishToVietnamese\\DictionaryEnglishToVietnamese\\test.txt";
                    dictionary.SaveDictionary(saveFileName);
                    Console.WriteLine();
                    break;
                case "5":
                    string loadFileName = "C:\\Users\\Administrator\\Desktop\\C# Projects\\DictionaryEnglishToVietnamese\\DictionaryEnglishToVietnamese\\test.txt";
                    dictionary.LoadDictionary(loadFileName);
                    Console.WriteLine();
                    break;
                case "6":
                    Console.WriteLine("Kết thúc chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
