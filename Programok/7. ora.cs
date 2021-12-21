using System;
using System.IO;

class Program{
    public static void Main(){
        List<string> napok = new List<string>();
        
        napok.Add("hétfő");
        napok.Add("kedd");
        napok.Add("szerda");
        napok.Add("csütörtök");
        napok.Add("péntek");
        napok.Add("szombat");
        napok.Add("vasárnap");
        
        foreach(string nap in napok){
            Console.WriteLine(nap);
        }
        
        Console.WriteLine(napok.Count());
        napok.Remove("hétfő");
        
        Console.WriteLine(napok.Count());
        Console.WriteLine(napok[0]);
        napok.RemoveAt(0);
        
        Console.WriteLine(napok.Count());
        Console.WriteLine(String.Join(", ", napok));

        //------------------------------------------------------------------------------------------------//
        
        StreamReader olvas = new StreamReader(@"forrasok\7.input.txt");
        /*
        Ha a teljes elérési utat adjuk meg neki:
        StreamReader olvas = new StreamReader(@"C:\Users\felhasznalonev\Documents\GitHub\csharp\gyakorlas\7.input.txt");
        Itt a string elé kell egy @ jel
        */
        string sor = olvas.ReadLine();
        List<int> megtettkmek = new List<int>();
        
        while(sor != null){
            megtettkmek.Add(int.Parse(sor));
            sor = olvas.ReadLine();
        }
        Console.WriteLine(megtettkmek.Count());

        Console.WriteLine(megtettkmek.Sum());
        Console.WriteLine(megtettkmek.Average());

        StreamWriter ki = new StreamWriter(@"kiirasok\7.output.txt");
        ki.WriteLine(megtettkmek.Sum());
        ki.WriteLine(megtettkmek.Average());
        ki.Close();
    }
}