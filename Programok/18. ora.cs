using System;
using System.IO;

class Program{
    struct egydiak{
        public int nap;
        public int honap;
        public string nev;
        public string hianyzasok;
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
    }
}