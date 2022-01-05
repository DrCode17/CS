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
//---------------------------Innen új, eddig az előzőből másoltam csak át-------------------------------------

        /*6. feladat:
        Határozza meg, melyik személy volt az, aki az autó egy elvitele alatt a leghosszabb
        távolságot tette meg! A személy azonosítóját és a megtett kilométert a minta szerint írja a
        képernyőre! (Több legnagyobb érték esetén bármelyiket kiírhatja.)
        */

        int[] szemelyek = new int[100];
        int sorszam = 0;
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