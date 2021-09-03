using System;
using System.Text;
using System.Linq;

namespace Lab_1_Part_3
{
    class Lab_3_2: ILab{
        private const string inputS = "Только Лизавета Ивановна успела снять капот и шляпу, как уже графиня послала за нею и велела опять подавать карету. Они пошли садиться.";
        public override void Do(){
            var g = inputS.GroupBy(c => c).ToDictionary(c => c.Key , v => v.Count());
            Console.WriteLine();

            System.Console.WriteLine("Unique characters:");
            foreach(var v in g){
                Console.Write($"{v.Key} ");
            }
            Console.WriteLine();
        }
        
        public override string Description(){
            return @"3.2. Составить программу, которая будет вводить строку в переменную String. Подсчитать, сколько различных символов встречается вней. Вывести их на экран.";
        }
    }
}