using System;
using System.Text;
using System.Linq;

namespace Lab_1_Part_3
{

    class Lab_3_5: ILab{
        private readonly string inputS = @"С той поры мне час от часу становилось лучше. Меня лечил полковой цирюльник, ибо в крепости другого лекаря не было, и, слава богу, не умничал.";
        public override void Do(){
            Console.WriteLine("Sourse data: ");
            Console.WriteLine(inputS);
            Console.WriteLine();

            var dic = inputS.Select(x => x).Where(x => char.IsLetter(x)).GroupBy(x => x).ToDictionary(k => k.Key, v => v.Count());

            

            foreach(var item in dic){
                Console.WriteLine($"Буква: \"{item.Key}\" встречается {item.Value} {GetGramm(item.Value)}");
            }

            Console.WriteLine();
        }

        private string GetGramm(int value){
            string s = "раз";
            string m = "раза";
            /*
            if a[i] mod 100 in [10..19] then writeln(' раз')
            else
            begin
                if a[i] mod 10 in [2..4] then writeln(' раза')
                else writeln(' раз')
            end;
            */  
            return value%100 >= 10 && value%100 <= 19?s:value % 10 >= 2 && value <= 4?m:s;
        }
        
        public override string Description(){
            return @"3.5. Строка, содержащая произвольный русский текст, состоит не более чем из 200 символов. Написать, какие буквы и сколько раз встречаются в этом тексте. 
Ответ должен приводиться в грамматически правильной форме: например: а – 25 - раз, к – 3 раза и т. д.";
        }

    }


}