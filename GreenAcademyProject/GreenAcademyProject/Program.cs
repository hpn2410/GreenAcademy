using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenAcademyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Charactor> charList = new List<Charactor>();
            Random range = new Random();
            for(int i = 0; i<10; i++)
            {
                Charactor charactor = new Charactor(range);
                charList.Add(charactor);
            }
            CheckCharactorType(charList);
        }

        private static void CheckCharactorType(List<Charactor> charList)
        {
            foreach (Charactor checkList in charList)
            {
                if (checkList.AttackRange < 10)
                {
                    checkList.Type = "You are a Warrior";
                    Console.WriteLine("{0}, Health: {1}, Defense: {2}, Damage: {3}, AttackRange: {4}"
                        , checkList.Type, checkList.Health, checkList.Defense, checkList.Damage, checkList.AttackRange);
                }
                else if (checkList.AttackRange > 10 && checkList.AttackRange < 20)
                {
                    checkList.Type = "You are a Mage";
                    Console.WriteLine("{0}, Health: {1}, Defense: {2}, Damage: {3}, AttackRange: {4}"
                        , checkList.Type, checkList.Health, checkList.Defense, checkList.Damage, checkList.AttackRange);
                }
                else
                {
                    checkList.Type = "You are a Scout";
                    Console.WriteLine("{0}, Health: {1}, Defense: {2}, Damage: {3}, AttackRange: {4}"
                        , checkList.Type, checkList.Health, checkList.Defense, checkList.Damage, checkList.AttackRange);
                }
            }
        }
    }

    public class Charactor
    {
        public string Name { get; set; }
        public float Health { get; set; }
        public float Defense { get; set; }
        public float Damage { get; set; }
        public string Type { get; set; }
        public float AttackRange { get; set; }
        public Charactor(Random range)
        {
            Type = "";
            Health = (float)range.NextDouble() * 30;
            Defense = (float)range.NextDouble() * 30;
            Damage = (float)range.NextDouble() * 30;
            AttackRange = (float)range.NextDouble() * 30;
        }
    }
}
