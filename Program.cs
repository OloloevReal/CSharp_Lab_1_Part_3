using System;
using System.Collections.Generic;

namespace Lab_1_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ILab> Labs = new List<ILab>();
            Labs.Add(new Lab_3_1());
            Labs.Add(new Lab_3_2());
            // Labs.Add(new Lab_3_3());
            // Labs.Add(new Lab_3_4());
            // Labs.Add(new Lab_3_5());

            foreach(ILab l in Labs){
                Console.WriteLine(l.Description());
                l.Do();
            }
        }
    }
}
