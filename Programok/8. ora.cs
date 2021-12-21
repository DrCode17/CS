using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


class Program
{
    static int fizet(int tav)
    {
        int fizetes;
        if (tav < 3) fizetes = 500;
        else
        {
            if (tav < 6) fizetes = 700;
            else
            {
                fizetes = 900;
            }
        }
        return fizetes;
    }
    static void Main(string[] args)
    {
        /*
        int[] nap = new int[60]{1,1,1,1,1,1,1,1,1,1,1,3,3,3,3,3,3,3,3,3,3,3,3,3,3,4,4,4,4,4,4,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,7,7,7,7,7,7,7,7,7};
        int[] fuvar = new int[60]{1,2,3,4,5,6,7,8,9,10,11,1,2,4,5,6,7,8,9,10,11,12,13,14,15,4,1,2,3,5,6,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,21,17,18,19,1,2,8,3,4,5,6,7,20};
        int[] hossz = new int[60]{10,3,3,1,9,5,2,9,8,5,6,7,7,2,4,6,3,5,8,1,4,2,3,5,2,28,11,2,3,7,11,2,5,2,6,2,3,2,6,2,2,4,2,2,4,4,5,2,7,2,3,5,12,25,6,6,6,9,6,7};
        */

        List<int> nap = new List<int>();
        List<int> fuvar = new List<int>();
        List<int> hossz = new List<int>();
        List<int> fizetes = new List<int>();

        StreamReader olvas = new StreamReader(@"forrasok\8. input.txt");
        string sor = olvas.ReadLine();

        StreamWriter ki = new StreamWriter(@"kiirasok\8. output.txt");

        do{
            nap.Add(int.Parse(sor));
            fuvar.Add(int.Parse(olvas.ReadLine()));
            hossz.Add(int.Parse(olvas.ReadLine()));

            fizetes.Add(fizet(hossz.Last()));

            ki.WriteLine(nap.Last() + ".nap\t" + fuvar.Last() + ".fuvar\t" + hossz.Last() + " km\t" + fizetes.Last() + "Ft");

            sor = olvas.ReadLine();
        }while(sor != null);

        ki.Close();
    }
}