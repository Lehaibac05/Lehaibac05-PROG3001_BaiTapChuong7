using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Dictionary<string, int> studentGrades = new Dictionary<string, int>();
            studentGrades["A"] = 8;
            studentGrades["B"] = 10;
            studentGrades["C"] = 7;
            studentGrades["D"] = 8;

            string keyToCheck = "A";
            if (studentGrades.ContainsKey(keyToCheck))
            {
                Console.WriteLine($"Khóa '{keyToCheck}' tồn tại trong từ điển.");
            }
            else
            {
                Console.WriteLine($"Khóa '{keyToCheck}' không tồn tại trong từ điển.");
            }

            int grade;
            if (studentGrades.TryGetValue("A", out grade))
            {
                Console.WriteLine($"Giá trị liên kết với khóa 'A' là {grade}.");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy giá trị liên kết với khóa 'A'.");
            }

           
            foreach (KeyValuePair<string, int> kvp in studentGrades)
            {
                Console.WriteLine($"Khóa: {kvp.Key}, Giá trị: {kvp.Value}");
            }
        }
    }
}
