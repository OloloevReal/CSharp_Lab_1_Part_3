using System;
using System.Text;
using System.Linq;

namespace Lab_1_Part_3
{
    class Lab_3_8: ILab{
        private readonly string inputS = @"";
        public override void Do(){
            Console.WriteLine("Sourse data: ");
            Console.WriteLine(inputS);
            Console.WriteLine();

            Console.WriteLine();            
        }
        
        public override string Description(){
            return @"3.8. Составить программу, которая будет вводить строку в пере менную String. Напечатать в алфавитном порядке все слова из данной строки, имеющие заданную длину n.";
        }
    }
}