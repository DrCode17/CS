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
        StreamReader olvas = new StreamReader(@"forrasok\10. input.txt");
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
//---------------------------Innen új, eddig az előzőből másoltam csak át-------------------------------------
        Console.WriteLine("2020. május informatika emelt érettségi\n3. feladat:");
        int min = 0, max = 0;

        for(int i = 0; i < adatok.Count();i++){
            if(adatok[i].homerseklet > adatok[max].homerseklet)
                max = i;
            if(adatok[i].homerseklet < adatok[min].homerseklet)
                min = i;
        }

        Console.WriteLine("Minimum: " + adatok[min].telepules + "\t" + adatok[min].ido + "\t" + adatok[min].homerseklet);
        Console.WriteLine("Maximum: " + adatok[max].telepules + "\t" + adatok[max].ido + "\t" + adatok[max].homerseklet);
        
        Console.WriteLine("4. feladat:");
        bool volt = false;
        
        for(int i = 0; i < adatok.Count();i++){
            if(adatok[i].szeliranyerosseg == "00000"){
                Console.WriteLine(adatok[i].telepules + "\t" + adatok[i].ido); volt = true;
            }
        }
        if(volt == false){
            Console.WriteLine("Nem volt szélcsend a mérések idején");
        }
    }
}