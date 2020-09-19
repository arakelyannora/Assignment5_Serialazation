using System;
using System.IO;
using System.Text.Json;
namespace ConsoleApp1
{
    class Program
    {
        static void SaveObjectAsJson(object obj, string fileName)
        {
            string JsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(fileName,JsonString);
            Console.WriteLine("file is serialized as Json");
            Console.WriteLine();
        }
        static Iphone11 LoadFromJsonFile(string fileName)
        {
            string JsonString = File.ReadAllText(fileName);
            Iphone11 i = JsonSerializer.Deserialize<Iphone11>(JsonString);
            Console.WriteLine("Object is deserilized");
            Console.WriteLine();
            return i;
        }
        static void Main(string[] args)
        {
            Iphone11 i = new Iphone11();
            i.print();
            string JsonFileName = "IphoneAsJson.txt";
            SaveObjectAsJson(i,JsonFileName);

            Iphone11 i2 = LoadFromJsonFile(JsonFileName);
            i2.print();
            
            
        }
    }
}
