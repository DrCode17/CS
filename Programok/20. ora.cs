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
            }
        }
        
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