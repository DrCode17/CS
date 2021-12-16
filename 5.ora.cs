using System;

class Program{
    public static void Main(){
        //árak:               250     290       300      310        320
        //így a minimum összeg: 250
        string[] termekek = {"víz","zöld tea","kávé","forró csoki","cola"};
        Console.WriteLine("Dobja be a pénzt: ");
        int bedobott_penz = 0;
        do{
            bedobott_penz = int.Parse(Console.ReadLine());
        }while(bedobott_penz < 250);

        if(bedobott_penz < 290){
            Console.WriteLine(termekek[0]);
        }else if(bedobott_penz<300){
            Console.WriteLine(termekek[0] + "," + termekek[1]);
        }else if(bedobott_penz<310){
            Console.WriteLine(termekek[0] + "," + termekek[1] + "," + termekek[2]);            
        }else if(bedobott_penz<320){
            Console.WriteLine(termekek[0] + "," + termekek[1] + "," + termekek[2] + "," + termekek[3]);            
        }else{
            Console.WriteLine(termekek[0] + "," + termekek[1] + "," + termekek[2] + "," + termekek[3] + "," + termekek[4]);
        }
        Console.WriteLine("Adja meg mit szeretne inni:");
        string bekert_ital = "";
        do{
            bekert_ital = Console.ReadLine();
        }while(bekert_ital != "cola" && bekert_ital != "víz" && bekert_ital != "zöld tea" && bekert_ital != "forró csoki" && bekert_ital != "kávé");

        if(bekert_ital == "víz"){
            Console.WriteLine("Készül!");
            Console.WriteLine("Visszajáró: " + (bedobott_penz-250));
        }else if(bekert_ital == "zöld tea"){
            Console.WriteLine("Készül!");
            Console.WriteLine("Visszajáró: " + (bedobott_penz-290));
        }else if(bekert_ital == "kávé"){
            Console.WriteLine("Készül!");
            Console.WriteLine("Visszajáró: " + (bedobott_penz-300));
        }else if(bekert_ital == "zöld tea"){
            Console.WriteLine("forró csoki");
            Console.WriteLine("Visszajáró: " + (bedobott_penz-310));
        }else{
            Console.WriteLine("Készül!");
            Console.WriteLine("Visszajáró: " + (bedobott_penz-320));
        }
    }
}