using System;
using System.Text;
using System.Linq;

namespace Lab_1_Part_3
{
    class Lab_3_4: ILab{
        private const string inputS = @"Я слыхал о тамошних метелях и знал, что целые обозы бывали ими занесены. Савельич, согласно со мнением ямщика, советовал воротиться. Но ветер показался мне не силен; я понадеялся добраться заблаговременно до следующей станции и велел ехать скорее.";
        public override void Do(){
            Console.WriteLine("Sourse data: ");
            Console.WriteLine(inputS);
            Console.WriteLine();

            var words = inputS.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
        }
        
        public override string Description(){
            return @"3.4. Составить программу, которая будет вводить строку в переменную String. Определить, сколько раз в строке встречается заданное слово.";
        }
    }
}