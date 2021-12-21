using System;
using System.IO;

class Program{
    struct Egyadat{
        public string telepules;
        public string ido;
        public string szeliranyerosseg;
        public int homerseklet;
    }
    public static void Main(){
        StreamReader olvas = new StreamReader(@"forrasok\9. input.txt");
        string[] sor = new string[4];
        List<Egyadat> adatok = new List<Egyadat>();
        Egyadat adat = new Egyadat();
        sor[0] = olvas.ReadLine();

        do{
            sor = sor[0].Split(" ");
            adat.telepules = sor[0];
            adat.ido = sor[1];
            adat.szeliranyerosseg = sor[2];
            adat.homerseklet = int.Parse(sor[3]);
            adatok.Add(adat);

            sor[0] = olvas.ReadLine();
        }while(sor[0] != null);
        
        Console.Write("2020. május informatika emelt érettségi\n1. feladat: Adja meg egy város kódját: ");
        string bekertvaroskod = Console.ReadLine();
        string utolsoadat = "";

        for(int i = 0; i < adatok.Count(); i++){
            if(adatok[i].telepules == bekertvaroskod){
                utolsoadat = adatok[i].ido;
            }
        }
        string ora = utolsoadat[0].ToString();
        ora += utolsoadat[1].ToString();
        
        string perc = utolsoadat[2].ToString();
        perc += utolsoadat[3].ToString();

        Console.WriteLine(ora + ":" + perc);
    }
}