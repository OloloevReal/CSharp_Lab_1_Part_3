using System;
using System.Text;
using System.Linq;

namespace Lab_1_Part_3
{
    class Lab_3_4: ILab{
        private readonly string inputS = @"Слова Марьи Ивановны открыли мне глаза и объяснили мне многое. Я понял упорное злоречие, которым Швабрин ее преследовал. Вероятно, замечал он нашу взаимную склонность и старался отвлечь нас друг от друга.";
        private readonly string templateS = "мне".ToLower();
        public override void Do(){
            Console.WriteLine("Sourse data: ");
            Console.WriteLine(inputS);
            Console.WriteLine();

            var words = inputS.Split(new[] { ',', ' ', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int cnt = 0;
            foreach(var w in words){
                if (w.ToLower() == templateS) cnt++;
            }

            Console.WriteLine($"\"{templateS}\" occurs in the sentence: {cnt}");
            Console.WriteLine();
            
        }
        
        public override string Description(){
            return @"3.4. Составить программу, которая будет вводить строку в переменную String. Определить, сколько раз в строке встречается заданное слово.";
        }
    }
}