using System;
using System.IO;

class Program{
    struct Autok
    {
        public byte nap;
        public string ido;
        public string rsz;
        public int szazon;
        public int km;
        public bool be;
    }
    public static void Main(){
        //2019 május
        //Olvassa be és tárolja el az Autok.txt fájl tartalmát!
        StreamReader olvas = new StreamReader(@"forrasok\11. input.txt");
        string[] sor = new string[4];
        List<Autok> adatok = new List<Autok>();
        Autok adat = new Autok();
        sor[0] = olvas.ReadLine();

        do{
            sor = sor[0].Split(" ");
            adat.nap = byte.Parse(sor[0]);
            adat.ido = sor[1];
            adat.rsz = sor[2];
            adat.szazon = int.Parse(sor[3]);
            adat.km = int.Parse(sor[4]);

            if(sor[5] == "0"){
                adat.be = false;
            }else{
                adat.be = true;
            }

            adatok.Add(adat);

            sor[0] = olvas.ReadLine();
        }while(sor[0] != null);

        //2. feladat:Adja meg, hogy melyik autót vitték el utoljára a parkolóból!

        int last = 0;
        
        for(int i = 0; i < adatok.Count()-1; i++){
           if(adatok[i].be == false){
                last = i; 
            }
        }

        Console.WriteLine(adatok[last].nap + ". napon, rendszáma: " + adatok[last].rsz );

        //3. feladat:Kérjen be egy napot és írja ki a képernyőre a minta szerint, hogy mely autókat vitték ki és hozták vissza az adott napon!
        Console.Write("Adjon meg egy napot: ");
        int bekert_nap = int.Parse(Console.ReadLine());
        for(int i = 0; i < adatok.Count(); i++){
            if(adatok[i].nap == bekert_nap){
                Console.Write(adatok[i].ido + " " + adatok[i].rsz + " " + adatok[i].szazon + " ");
                if(adatok[i].be == true){
                    Console.WriteLine("be");
                }else{
                    Console.WriteLine("ki");
                }
            }
        }
    }
}