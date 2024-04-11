using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace File_In_C_Sharp
{
    public class Character
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Hp { get; set; }
        public string Damage { get; set; }
        public Character() { }
    }
    public class RootObject
    {
        [JsonProperty("Players")]
        public List<Character> Players { get; set; }
        [JsonProperty("Enemies")]
        public List<Character> Enemies { get; set; }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            string file_Path = "C:/Users/May1/Downloads/GreenAcademy/GreenAcademyProject/File_In_C_Sharp/Test.json";

            string  read_Json = File.ReadAllText(file_Path);

            RootObject root = JsonConvert.DeserializeObject<RootObject>(read_Json);

            foreach (var player in root.Players)
            {
                Console.WriteLine($"Name: {player.Name}, HP: {player.Hp}, Class: {player.Class}, Damage: {player.Damage}");
            }
            foreach (var enemy in root.Enemies)
            {
                Console.WriteLine($"Name: {enemy.Name}, HP: {enemy.Hp}, Class: {enemy.Class}, Damage: {enemy.Damage}");
            }
        }
    }
}
