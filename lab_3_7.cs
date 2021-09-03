using System;
using System.Text;
using System.Linq;

namespace Lab_1_Part_3
{
    class Lab_3_7: ILab{
        private readonly string inputS = @"";
        public override void Do(){
            Console.WriteLine("Sourse data: ");
            Console.WriteLine(inputS);
            Console.WriteLine();

            Console.WriteLine();            
        }
        
        public override string Description(){
            return @"3.7. Составить программу, которая будет вводить строку в переменную String. Удалить из нее все лишние пробелы, оставив между словами не более одного.
Результат поместить в новую строку.";
        }
    }
}