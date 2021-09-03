using System;
using System.Text;
using System.Linq;

namespace Lab_1_Part_3
{
    class Lab_3_6: ILab{
        private readonly string inputS = @"";
        public override void Do(){
            Console.WriteLine("Sourse data: ");
            Console.WriteLine(inputS);
            Console.WriteLine();

            Console.WriteLine();            
        }
        
        public override string Description(){
            return @"3.6. Двумерный массив n x m содержит некоторые буквы русского алфавита, расположенные в произвольном порядке. 
Написать программу, проверяющую, можно ли из этих букв составить данное слово S. Каждая буква массива используется не более - одного раза.";
        }
    }
}