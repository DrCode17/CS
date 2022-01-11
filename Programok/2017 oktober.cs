//2017 oktober
using System;
using System.IO;

class Program{
    struct egydiak{
        public int nap;
        public int honap;
        public string nev;
        public string hianyzasok;
    }

    struct diakhianyzas{
        public string nev;
        public int hianyzas;
    }

    public static string hetnapja(int honap, int nap){
        string[] napnev = {"vasarnap", "hetfo", "kedd", "szerda", "csutortok", "pentek", "szombat"};
        int[] napszam = {0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 335};
        int napsorszam = (napszam[honap-1] + nap) % 7;
        string hetnapja = napnev[napsorszam];

        return hetnapja;
    } 
    public static int hianyzottorak(string hianyzasok){
        int hianyzott = 0;
        for(int i=0; i < 7;i++){
            if(hianyzasok[i] == 'X' || hianyzasok[i] == 'I'){
                hianyzott++;
            }
        }
        return hianyzott;
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
                //Console.WriteLine(sor.honap + "\t" + sor.nap + "\t" + sor.nev + "\t" + sor.hianyzasok);
            }
        }
        
        Console.WriteLine("2. feladat\nA naplóban " + diakok.Count() + " bejegyzés van");

        int igazolt = 0, igazolatlan = 0;

        foreach(var item in diakok){
            for(int i = 0; i < 7; i++){
                if(item.hianyzasok[i] == 'X'){
                    igazolt++;
                }else if(item.hianyzasok[i] == 'I'){
                    igazolatlan++;
                }
            }
        }
        Console.WriteLine("3. feladat\nAz igazolt hiányzások száma " + igazolt + ", az igazolatlanoké " + igazolatlan + " óra.");
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

        Console.Write("7. feladat\nA legtöbbet hiányzó tanulók: ");
        List<diakhianyzas> osztaly = new List<diakhianyzas>();
        diakhianyzas egysor = new diakhianyzas();
        bool van = false;

        for(int i = 0; i < diakok.Count(); i++){
            van = false;
            if(osztaly.Count() == 0){
                egysor.nev = diakok[i].nev;
                egysor.hianyzas = hianyzottorak(diakok[i].hianyzasok);
                osztaly.Add(egysor);
            }else{
                for(int j = 0; j < osztaly.Count(); j++){
                    if(osztaly[j].nev == diakok[i].nev){
                        egysor.nev = diakok[i].nev;
                        egysor.hianyzas = hianyzottorak(diakok[i].hianyzasok) + osztaly[j].hianyzas;
                        osztaly[j] = egysor;
                        van = true;
                        break;
                    }
                }
                if(!van){
                    egysor.nev = diakok[i].nev;
                    egysor.hianyzas = hianyzottorak(diakok[i].hianyzasok);
                    osztaly.Add(egysor);
                }
            }
        }
        int max = 0;
        for(int i = 1; i < osztaly.Count(); i++){
            if(osztaly[i].hianyzas > osztaly[max].hianyzas){
                max = i;
            }
        }
        for(int i = 0; i < osztaly.Count(); i++){
            if(osztaly[i].hianyzas == osztaly[max].hianyzas){
                Console.Write(osztaly[i].nev + " ");
            }
        }
    }
}