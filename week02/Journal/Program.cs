using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Journal j = new Journal();
        PromptGenerator p = new PromptGenerator();
        int c = 0;
        while(c != 5)
        {
            Console.WriteLine("1.Write 2.Display 3.Load 4.Save 5.Quit");
            Console.Write("Choice: ");
            c = int.Parse(Console.ReadLine());
            
            if(c==1)
            {
                string pr = p.GetRandom();
                Console.WriteLine(pr);
                Console.Write("> ");
                string ans = Console.ReadLine();
                j.Add(new Entry{_date=DateTime.Now.ToShortDateString(), _prompt=pr, _text=ans});
            }
            if(c==2) j.Display();
            if(c==3){ Console.Write("File: "); j.Load(Console.ReadLine()); }
            if(c==4){ Console.Write("File: "); j.Save(Console.ReadLine()); }
        }
    }
}