using System;
using System.IO;

class Program{
    struct egydiak{
        public int nap;
        public int honap;
        public string nev;
        public string hianyzasok;
    }
        public static string hetnapja(int honap, int nap){
        string[] napnev = {"vasarnap", "hetfo", "kedd", "szerda", "csutortok", "pentek", "szombat"};
        int[] napszam = {0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 335};
        int napsorszam = (napszam[honap-1] + nap) % 7;
        string hetnapja = napnev[napsorszam];

        return hetnapja;
    } 
    public static void Main(){
        StreamReader olvas = new StreamReader(@"forrasok/18. input.txt");
        int nap = 0;
        int honap = 0;
        List<egydiak> diakok = new List<egydiak>();
        egydiak sor = new egydiak();

        while(!olvas.EndOfStream){
            string[] seged = (olvas.ReadLine()).Split(" ");
            if(seged[0] == "#"){
                nap = int.Parse(seged[2]);
                honap = int.Parse(seged[1]);
            }else{
                sor.honap = honap;
                sor.nap = nap;
                sor.nev = seged[0] + " " + seged[1];
                sor.hianyzasok = seged[2];

                diakok.Add(sor);
            }
        }
        Console.Write("5. feladat\nA hónap sorszáma=");
        int honapsorszam = int.Parse(Console.ReadLine());
        Console.Write("A nap sorszáma=");
        int napsorszam = int.Parse(Console.ReadLine());
        Console.WriteLine("Azon a napon " + hetnapja(honapsorszam, napsorszam) + " volt.");

        Console.Write("6. feladat\nA nap neve=");
        string napnev = Console.ReadLine();
        Console.Write("Az óra sorzáma=");
        int orasorszam = int.Parse(Console.ReadLine());
        int hianyzasok = 0;

        foreach(var item in diakok){
            if(hetnapja(item.honap, item.nap) == napnev){
                if(item.hianyzasok[orasorszam-1] == 'X' || item.hianyzasok[orasorszam-1] == 'I'){
                    hianyzasok++;
                } 
            }
        }
        Console.WriteLine("Ekkor összesen " + hianyzasok + " óra hiányzás történt");
    }
}