using System;
using System.Text;
using System.Globalization;

namespace Lab_1_Part_3
{
    class Lab_3_1: ILab{
        public override void Do(){
            string inputS = "тестовое сообщение.привет. Как дела.";
            StringBuilder SBuild = new StringBuilder(inputS);         
            Console.WriteLine(SBuild[0] = Char.ToUpper(SBuild[0]));

            Console.WriteLine(SBuild.ToString());
        }

        public override string Description(){
            return @"3.1. Текстовые сообщения часто печатаются строчными буквами,но многие сотовые телефоны имеют встроенные средства преобразования строчной буквы в прописную после символа пунктуации, как точка или знак вопроса. Составить программу, которая будет вводить сообщение в переменную String (на одной строке), а затем обрабаты вать его с получением новой строки с - прописными буквами в соответствующих местахс прописными буквами в соответствующих местах.";
        }
    }
}