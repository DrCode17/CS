using System;

class Program{
    public static void Main(){
        //árak:               250     290       300      310        320
        //így a minimum összeg: 250
        string[] termekek = {"víz","zöld tea","kávé","forró csoki","cola"};
        Console.WriteLine("Dobja be a pénzt: ");
        int bedobott_penz = 0;

        do{
            bedobott_penz += int.Parse(Console.ReadLine()); //mint a valóságban, úgy itt is, ha 20Ft-ot dobsz be majd egy 100-ast, akkor az 120(összeadódik) és nem 100
        }while(bedobott_penz < 250);//amíg kisebb összeget dob be mint a legolcsóbb ital, addig dobálja a pénzt.

        if(bedobott_penz < 290){//víz
            Console.WriteLine( string.Join(", ", termekek, 0, 1));
        }else if(bedobott_penz<300){//víz, zöld tea
            Console.WriteLine( string.Join(", ", termekek, 0, 2));
        }else if(bedobott_penz<310){//víz, zöld tea, kávé
            Console.WriteLine( string.Join(", ", termekek, 0, 3));        
        }else if(bedobott_penz<320){//víz, zöld tea, kávé, forró csoki
            Console.WriteLine( string.Join(", ", termekek, 0, 4));
        }else{
            Console.WriteLine( string.Join(", ", termekek)); // kiírja a tömb elemeit vesszővel elválasztva
        }

        Console.WriteLine("Adja meg mit szeretne inni:");
        string bekert_ital = "";

        do{
            bekert_ital = Console.ReadLine();
            //
        }while(bekert_ital != termekek[0] && bekert_ital != termekek[1] && bekert_ital != termekek[2] && bekert_ital != termekek[3] && bekert_ital != termekek[4]);

        if(bekert_ital == termekek[0]){
            Console.WriteLine("Készül!");
            Console.WriteLine("Visszajáró: " + (bedobott_penz-250));
        }else if(bekert_ital == termekek[1]){
            Console.WriteLine("Készül!");
            Console.WriteLine("Visszajáró: " + (bedobott_penz-290));
        }else if(bekert_ital == termekek[2]){
            Console.WriteLine("Készül!");
            Console.WriteLine("Visszajáró: " + (bedobott_penz-300));
        }else if(bekert_ital == termekek[3]){
            Console.WriteLine("forró csoki");
            Console.WriteLine("Visszajáró: " + (bedobott_penz-310));
        }else{
            Console.WriteLine("Készül!");
            Console.WriteLine("Visszajáró: " + (bedobott_penz-320));
        }

        Console.WriteLine("A " + bekert_ital + "-od készen van");
    }
}