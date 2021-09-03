using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Lab_1_Part_3
{
    class Lab_3_6: ILab{
        private readonly string inputS = @"собака";

        private char[,] items = {{'а', 'с', 'о'}, {'а', 'я', 'б'}, {'у', 'к', 'ц'}};
        public override void Do(){
            Console.WriteLine("Sourse data: ");
            Utils.PrintArray(items);
            Console.WriteLine($"Word: {inputS}");
            Console.WriteLine();

            var list = items.Cast<char>().ToList();

            bool CheckChars(){
                if(inputS.Length > list.Count()) return false;

                foreach(var w in inputS){
                    if(!list.Remove(w))return false;
                }
                return true;
            }

            Console.Write($"Слово \"{inputS}\" составить ");
            if(CheckChars()){
                Console.WriteLine("возможно!");
            }else{
                Console.WriteLine("не получиться!");
            }
            
            Console.WriteLine();            
        }
        
        public override string Description(){
            return @"3.6. Двумерный массив n x m содержит некоторые буквы русского алфавита, расположенные в произвольном порядке. 
Написать программу, проверяющую, можно ли из этих букв составить данное слово S. Каждая буква массива используется не более - одного раза.";
        }
    }
}