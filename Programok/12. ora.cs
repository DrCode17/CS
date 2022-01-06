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
        StreamReader olvas = new StreamReader(@"forrasok\12. input.txt");
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
    }
}