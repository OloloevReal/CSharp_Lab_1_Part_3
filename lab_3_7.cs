using System;
using System.Text;
using System.Linq;

namespace Lab_1_Part_3
{
    class Lab_3_7: ILab{
        private readonly string inputS = @"Посланы    были к ним лазутчики.  Юлай,    крещеный калмык, сделал  коменданту важное донесение.";
        public override void Do(){
            Console.WriteLine("Sourse data: ");
            Console.WriteLine(inputS);
            Console.WriteLine();

            /* var splitted = inputS.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            System.Text.StringBuilder StrB = new StringBuilder();
            foreach(var s in splitted){
                StrB.Append($"{s} ");
            }
            StrB.Remove(StrB.Length - 1, 1);
            Console.WriteLine(StrB); */

            char[] ch = inputS.ToCharArray();
            char[] outChar = new char[ch.Length];

            int id = 0;
            bool skip = false;
            for(int i = 0; i < ch.Length; i++){
                if (ch[i] == ' '){
                    if (!skip){
                        skip = !skip;
                        outChar[id++] = ' ';
                    }
                }else{
                    skip = false;
                    outChar[id++] = ch[i];
                }
            }
            
            Console.WriteLine("Result: ");
            Console.WriteLine(new string(outChar,0, id));
            Console.WriteLine();            
        }
        
        public override string Description(){
            return @"3.7. Составить программу, которая будет вводить строку в переменную String. Удалить из нее все лишние пробелы, оставив между словами не более одного.
Результат поместить в новую строку.";
        }
    }
}