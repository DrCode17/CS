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

         //4. feladat: Adja meg, hogy hány autó nem volt bent a hónap végén a parkolóban!
        //Mivel 300-309-ig vannak a rendszámok így elég egy 10 elemű tömb.
        int[] kint = new int[10];
        int sorszam = 0;

        for(int i = 0; i < adatok.Count(); i++){
            sorszam = Convert.ToInt32(adatok[i].rsz.Substring(3, 3)) % 10;
            if(adatok[i].be == true){
                kint[sorszam]-- ;
            }else{
                kint[sorszam]++ ;
            }
        }

        int kintlevo_autok = 0;
        foreach(var i in kint){
            if(i == 1){
                kintlevo_autok++;
            }
        }

        Console.WriteLine("Kint levő autók: " + kintlevo_autok );

        /*5. feladat:
        Készítsen statisztikát, és írja ki a képernyőre mind a 10 autó esetén az ebben a hónapban
        megtett távolságot kilométerben! A hónap végén még kint lévő autók esetén az utolsó
        rögzített kilométerállással számoljon! A kiírásban az autók sorrendje tetszőleges lehet.
        */
        int[] elso = new int[10];
        int[] utolso = new int[10];

        foreach(var item in adatok){
            sorszam = Convert.ToInt32(item.rsz.Substring(3, 3)) % 10;
            utolso[sorszam] = item.km;
        }

        for(int i = adatok.Count()-1; i != 0; i--){
            sorszam = Convert.ToInt32(adatok[i].rsz.Substring(3, 3)) % 10;
            elso[sorszam] = adatok[i].km;
        }

        for(int i = 0; i < 10; i++){
            Console.WriteLine("CEG30" + i + " " + (utolso[i] - elso[i]) + " km");
        }
        /*6. feladat:
        Határozza meg, melyik személy volt az, aki az autó egy elvitele alatt a leghosszabb
        távolságot tette meg! A személy azonosítóját és a megtett kilométert a minta szerint írja a
        képernyőre! (Több legnagyobb érték esetén bármelyiket kiírhatja.)
        */

        int[] szemelyek = new int[100];
        sorszam = 0;
        int legnagyobbkm = -1;
        int legnagyobbid = -1;

        for(int i = 0; i < adatok.Count(); i++){

            if(adatok[i].be == true){
                for(int j = i - 1; j > -1 ; j--){
                    if(adatok[i].szazon == adatok[j].szazon){

                        sorszam = Convert.ToInt32(adatok[i].szazon) % 100;
                        
                        if((adatok[i].km - adatok[j].km) > szemelyek[sorszam]){
                            szemelyek[sorszam] = adatok[i].km - adatok[j].km;
                        }

                        if((adatok[i].km - adatok[j].km) > legnagyobbkm){
                            legnagyobbkm = adatok[i].km - adatok[j].km;
                            legnagyobbid = adatok[i].szazon;
                        }

                        break;
                    }
                }
            }
        }
        Console.WriteLine("Leghosszabb út: " + legnagyobbkm + " km, személy: " + legnagyobbid);

        /*7. feladat:
        Az autók esetén egy havi menetlevelet kell készíteni! Kérjen be a felhasználótól egy
        rendszámot! Készítsen egy X_menetlevel.txt állományt, amelybe elkészíti az adott
        rendszámú autó menetlevelét! (Az X helyére az autó rendszáma kerüljön!) A fájlba
        soronként tabulátorral elválasztva a személy azonosítóját, a kivitel időpontját (nap.
        óra:perc), a kilométerszámláló állását, a visszahozatal időpontját (nap. óra:perc), és
        a kilométerszámláló állását írja a minta szerint! (A tabulátor karakter ASCII-kódja: 9.)
        */

        Console.Write("Adjon meg egy rendszámot: ");
        string bekert_rendszam = Console.ReadLine();
        string filename = "13. output(" + bekert_rendszam + "_menetlevel).txt";
        StreamWriter ki = new StreamWriter(@"kiirasok/" + filename);

        foreach(var item in adatok){
            if(item.rsz == bekert_rendszam){
                if(item.be == false){
                    ki.Write(item.szazon + "\t" + item.nap + ".\t" + item.ido + "\t" + item.km + " km");
                }else{
                    ki.WriteLine("\t" + item.nap + ".\t" + item.ido + "\t" + item.km + " km");
                }
            }
        }

        ki.Close();
        Console.WriteLine("Menetlevél kész.");
    }
}