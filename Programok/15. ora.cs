using System;
using System.IO;

class Program{

    public static void Main(){
        List<int> godrok = new List<int>();
        StreamReader olvas = new StreamReader(@"forrasok/15. input.txt");

        while(!olvas.EndOfStream){
            godrok.Add(int.Parse(olvas.ReadLine()));
        }
        //4. feladat
        StreamWriter ki = new StreamWriter(@"kiirasok/15. output.txt");
        int godor = 0;
        for(int i = 0; i < godrok.Count()-1; i++){
            if(godrok[i] > 0){
                if(godrok[i-1] == 0 && godor > 0 ){
                    ki.WriteLine();
                }
                ki.Write(godrok[i] + " ");
                godor++;
            }
        }

        ki.Close();

        //5. feladat
        godor = 0;

        for(int i = 1; i < godrok.Count()-1; i++){
            if(godrok[i] > 0 && godrok[i-1] == 0){
                godor++;
            }
        }
        Console.WriteLine(godor);
    }
}