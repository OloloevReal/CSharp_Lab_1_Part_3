using System;
using System.Text;
using System.Linq;

namespace Lab_1_Part_3
{
    class Lab_3_3: ILab{
        private readonly string inputS = @"Я слыхал о тамошних метелях и знал, что целые обозы бывали ими занесены. Савельич, согласно со мнением ямщика, советовал воротиться. Но ветер показался мне не силен; я понадеялся добраться заблаговременно до следующей станции и велел ехать скорее.";
        public override void Do(){
            Console.WriteLine("Sourse data: ");
            Console.WriteLine(inputS);
            Console.WriteLine();
            
            var words = inputS.Split(new[] { ',', ' ', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Result: ");
            int cnt = 0;
            foreach(var w in words){
                if (w.Length <= 1)continue;
                if(w[0] == w[w.Length - 1]){
                    Console.WriteLine($"- {w}");
                    cnt++;
                }
            }
            Console.WriteLine("Found words: {0}", cnt);

            
        }
        
        public override string Description(){
            return @"3.3. Составить программу, которая будет вводить строку в переменную String. Найти в ней те слова, которые начинаются и оканчиваются одной и той же буквой.";
        }
    }
}