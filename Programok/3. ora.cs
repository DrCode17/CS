using System;

namespace ciklusok
{
    class Program{
        public static void Main(){

            //do while
            //hátul tesztelő ciklus, egyszer mindenképp lefut
            int i = 1;
            do{
                i++;
                Console.WriteLine(i);
            }while(i!=7);           
            Console.WriteLine("Ciklus vége:" + i);

            //ellenőrzött bekérés
		    string beker = "";
            i = 0; 
		    Console.WriteLine("Ird be, hogy \"alma\":");
		    do{
			    if(i>0){
				    Console.WriteLine("Próbáld újra!");
			    }
			    beker = Console.ReadLine();
                i++;
		    }while(beker != "alma" );
		    Console.WriteLine("A szo: " + beker);

            //Feladat
            i = 0; //nem szükséges
            int j = 0; //Csak azért kell, hogy tudjuk, nem elsőre fut le a ciklus a kiírással
            beker = "";
            Console.WriteLine("3-as szorzótábla:");
            do{
                i = 0;
                if(j > 0){
                    Console.WriteLine("Újra próbálom.");
                }
                do{
                    i += 3;
                    Console.WriteLine(i);
                }while(i != 30);
                j++;
                Console.WriteLine("Jól írtam ki? (igen=y, nem=n)");
                beker = Console.ReadLine();
            }while(beker != "y");

        }
    }
}