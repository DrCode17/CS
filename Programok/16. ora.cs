using System;
using System.IO;

class Program{

    public static void Main(){
        List<int> godrok = new List<int>();
        StreamReader olvas = new StreamReader(@"forrasok/16. input.txt");

        while(!olvas.EndOfStream){
            godrok.Add(int.Parse(olvas.ReadLine()));
        }

        //6. feladat
        Console.Write("Adjon meg egy távolságot:");
        int tavolsag = int.Parse(Console.ReadLine());

        int kezdopont = 0;
        int vegpont = 0;

        for(int i = tavolsag ; i > 0; i--){
            if(godrok[i] == 0){
                kezdopont = i + 2;
                break;
            }
        }

        for(int i=tavolsag; i < godrok.Count() - 1; i++){
            if(godrok[i] == 0){
                vegpont = i;
                break;
            }
        }

        Console.WriteLine("a) " + kezdopont + "-" + vegpont );

        bool no = true;
        bool folyamatosan_melyul = true;
        for(int i = kezdopont-1; i < vegpont; i++ ){
            if(godrok[i] <= godrok[i+1]){
                if(no == false){
                    Console.WriteLine("b) Nem mélyül folyamatosan.");
                    folyamatosan_melyul = false;
                    break;
                }
            }else{
                no = false;
            }
        }

        if(folyamatosan_melyul == true){
            Console.WriteLine("b) Folyamatosan mélyül");
        }

        int legmelyebb = 0;

        for(int i = kezdopont-1; i < vegpont; i++){
            if(godrok[i] > legmelyebb){
                legmelyebb = godrok[i];
            }
        }

        Console.WriteLine("c) " + legmelyebb + " m");

        int terfogat = 0;

        for(int i = kezdopont-1; i < vegpont; i++){
            terfogat += godrok[i];
        }
        terfogat *=10;

        Console.WriteLine("d) " + terfogat + " m^3");

        terfogat = 0;
        for(int i = kezdopont-1; i < vegpont; i++){
            terfogat += godrok[i]-1;
        }
        terfogat *=10;

        Console.WriteLine("e) " + terfogat + " m^3");
    }
}