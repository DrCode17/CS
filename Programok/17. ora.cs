using System;
using System.IO;

class Program{
    public static void Main(){
        int[,] tmb = new int[5,5];
        int[] seged = new int[5];
        int sorsz = 1;

        for(int i = 0; i<5; i++){
            for(int j = 0; j<5; j++){
                //tmb[i,j] = (i+1) * (j+1); 
                tmb[i,j] = sorsz * 5;
                seged[j] = tmb[i,j];
                sorsz++;
            }
            
            Console.WriteLine(string.Join("\t", seged));
        }

        Console.Write("Also határ:");
        int alsohatar = int.Parse(Console.ReadLine());
        Console.Write("Felső határ:");
        int felsohatar = int.Parse(Console.ReadLine());

        Random random = new Random();
        int randomszam = random.Next(alsohatar, felsohatar);
        Console.WriteLine(randomszam);
    }
}