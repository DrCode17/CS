//2021 május
using System;
using System.IO;

class Program{

    public static void Main(){
        List<int> godrok = new List<int>();
        StreamReader olvas = new StreamReader(@"forrasok/14. input.txt");

        Console.WriteLine("1. feladat:");
        while(!olvas.EndOfStream){
            godrok.Add(int.Parse(olvas.ReadLine()));
        }

        Console.WriteLine("A file adatainak száma: " + godrok.Count() + "\n");

        //2. feladat:

        Console.Write("2. feladat\nAdjon meg egy távolságot: ");
        int tavolsag = int.Parse(Console.ReadLine());

        Console.WriteLine("Ezen a helyen a felszín " + godrok[tavolsag - 1] + " méter mélyen van\n");
        
        //3. feladat
        Console.WriteLine("3. feladat");
        double szabad = 0;

        foreach(var item in godrok){
            if(item == 0){
                szabad ++;
            }
        }
        double erintetlen = Math.Round(szabad * 100 / godrok.Count(), 2);
        Console.WriteLine("Az érintetlen területek aránya: " + erintetlen + "%.\n");
    }
}

