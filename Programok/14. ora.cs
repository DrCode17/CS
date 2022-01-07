using System;
using System.IO;

class Program{

    public static void Main(){
        List<int> godrok = new List<int>();
        StreamReader olvas = new StreamReader(@"forrasok/14. input.txt");

        while(!olvas.EndOfStream){
            godrok.Add(int.Parse(olvas.ReadLine()));
        }

        Console.WriteLine(godrok.Count());

        //2. feladat:

        Console.Write("Adjon meg egy távolságot: ");
        int tavolsag = int.Parse(Console.ReadLine());

        Console.WriteLine(godrok[tavolsag - 1]);
        
        //3. feladat
        double szabad = 0;

        foreach(var item in godrok){
            if(item == 0){
                szabad ++;
            }
        }
        double erintetlen = Math.Round(szabad * 100 / godrok.Count(), 2);
        Console.WriteLine(erintetlen + "%");
    }
}