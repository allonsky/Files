using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"C:\Users\Саша\Desktop\new_file.txt", "text");
            File.AppendAllText(@"C:\Users\Саша\Desktop\new_file.txt", "текст метода");
            File.Delete(@"C:\Users\Саша\Desktop\new_file.txt");
            FileStream File1 = new FileStream(@"C:\Users\Саша\Desktop\new_file.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(File1);
            writer.Write("Вопрос");
            writer.Close();
            FileStream File2 = new FileStream(@"C:\Users\Саша\Desktop\new_file.txt", FileMode.Open);
            StreamReader reader = new StreamReader(File2);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            Console.ReadKey();

        }
    }
}
