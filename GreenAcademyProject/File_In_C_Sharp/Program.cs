using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace File_In_C_Sharp
{
    public class SinhVien
    {
        public string Full_Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public SinhVien() { }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            string file_Path = "C:/Users/MAY01/Downloads/GreenAcademy/GreenAcademyProject/File_In_C_Sharp/Test.json";
            //string text = "Hello World";
            //File.WriteAllText(file_Path, text);
            //Console.WriteLine(File.ReadAllText(file_Path));
            var opt = new JsonSerializerOptions()
            { WriteIndented = true };
            string read_File = File.ReadAllText(file_Path);
            SinhVien sv = JsonSerializer.Deserialize<SinhVien>(read_File);
            Console.WriteLine("Full Name: " + sv.Full_Name);
            Console.WriteLine("Age: " + sv.Age);
            Console.WriteLine("Email: " + sv.Email);
            
        }
    }
}
