using System;

class Program{
    public static void Main(){
        //switch case megmutatása
        Console.WriteLine("Adja meg a jegy típusát(1,2,3): ");
        int jegytipus = int.Parse(Console.ReadLine());
        int érme = 0;
        
        switch(jegytipus){
            case 1:
                Console.WriteLine("Dobja be a pénzt!");
                érme = int.Parse(Console.ReadLine());   
                Console.WriteLine("Napi jegy kinyomtatva, visszajáró: " + (érme - 500));
                break;
            case 2:
                Console.WriteLine("Dobja be a pénzt!");
                érme = int.Parse(Console.ReadLine());   
                Console.WriteLine("Heti jegy kinyomtatva, visszajáró: " + (érme - 2500));
                break;
            case 3:
                Console.WriteLine("Dobja be a pénzt!");
                érme = int.Parse(Console.ReadLine());   
                Console.WriteLine("Havi jegy kinyomtatva, visszajáró: " + (érme - 7500));
                break;
            default:
                Console.WriteLine("Nincs ilyen");
                break;
        }

        //árak:               250     290       300      310        320
        //így a minimum összeg: 250
        string[] termekek = {"víz","zöld tea","kávé","forró csoki","cola"};
        Console.WriteLine("Dobja be a pénzt: ");
        int bedobott_penz = 0;

        do{
            bedobott_penz += int.Parse(Console.ReadLine()); //mint a valóságban, úgy itt is, ha 20Ft-ot dobsz be majd egy 100-ast, akkor az 120(összeadódik) és nem 100
        }while(bedobott_penz < 250);//amíg kisebb összeget dob be mint a legolcsóbb ital, addig dobálja a pénzt.

        //átírható switch case szerkezetre(másik irányba nem működik a relációs jel!!)
        switch(bedobott_penz){
            case <290://víz
                Console.WriteLine( string.Join(", ", termekek, 0, 1));
                break;
            case <300:  //víz, zöld tea
                Console.WriteLine( string.Join(", ", termekek, 0, 2));
                break;
            case <310://víz, zöld tea, kávé
                Console.WriteLine( string.Join(", ", termekek, 0, 3));   
                break;     
            case <320://víz, zöld tea, kávé, forró csoki
                Console.WriteLine( string.Join(", ", termekek, 0, 4));
                break;
            default://mindegyik
                Console.WriteLine( string.Join(", ", termekek)); // kiírja a tömb elemeit vesszővel elválasztva
                break;
        }

        Console.WriteLine("Adja meg mit szeretne inni:");
        string bekert_ital = "";

        do{
            bekert_ital = Console.ReadLine();
            //
        }while(bekert_ital != termekek[0] && bekert_ital != termekek[1] && bekert_ital != termekek[2] && bekert_ital != termekek[3] && bekert_ital != termekek[4]);

        //tömb elemeire nem írható át a switch case, csak ha kézzel begépeled a tömb elemeit
        switch(bekert_ital){
            case "víz":
                Console.WriteLine("Készül!");
                Console.WriteLine("Visszajáró: " + (bedobott_penz-250));
                break;
            case "zöld tea":
                Console.WriteLine("Készül!");
                Console.WriteLine("Visszajáró: " + (bedobott_penz-290));
                break;
            case "kávé":
                Console.WriteLine("Készül!");
                Console.WriteLine("Visszajáró: " + (bedobott_penz-300));
                break;
            case "forró csoki":
                Console.WriteLine("forró csoki");
                Console.WriteLine("Visszajáró: " + (bedobott_penz-310));
                break;
            default:
                Console.WriteLine("Készül!");
                Console.WriteLine("Visszajáró: " + (bedobott_penz-320));
                break;
        }

        Console.WriteLine("A " + bekert_ital + "-od készen van");
    }
}