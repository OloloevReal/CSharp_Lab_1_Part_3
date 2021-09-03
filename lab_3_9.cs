using System;
using System.Text;
using System.Linq;

namespace Lab_1_Part_3
{
    class Lab_3_9: ILab{
        private readonly string inputS = @"";
        public override void Do(){
            Console.WriteLine("Sourse data: ");
            Console.WriteLine(inputS);
            Console.WriteLine();

            Console.WriteLine();            
        }
        
        public override string Description(){
            return @"3.9. Составить программу, которая будет вводить строку в переменную String. Найти слово, встречающееся в каждом предложении,или сообщить, что такого слова нет.";
        }
    }
}