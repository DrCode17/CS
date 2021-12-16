using System;

class Program{
    public static void Main(){
        int a=2,b=5,c=4,d=3,e=3,f=2,g=1,h=1,i=5,j=3;
        a+=b;   a+=c;    a+=d;    a+=e;
        a+=f;   a+=g;    a+=h;    a+=i;    a+=j;
        double atlag = a/10.00;

        Console.WriteLine("Számok átlaga: " + atlag);

        //tömbökkel
        int[] jegyek = {2,5,4,3,3,2,1,1,5,3};
        atlag = 0; //mivel double, így olyan mintha 0.00-t írtam volna oda

        //foreach
        foreach(int jegy in jegyek){
            atlag += jegy;
        }
        
        Console.WriteLine("Jegyek átlaga: " + atlag/jegyek.Length);

        //tömb2
        Console.WriteLine("Adjon meg számokat enterrel:");
        int[] osztalyzatok = new int[5];
        atlag = 0;
        for(i=0;i<osztalyzatok.Length;i++){
            osztalyzatok[i] = int.Parse(Console.ReadLine());
            atlag += osztalyzatok[i];
        }
        Console.WriteLine("Osztalyzatok átlaga: " + atlag/osztalyzatok.Length);

        //hőmérséklet
        Console.WriteLine("Adjon meg hőmérséklet adatokat vesszővel a törtet és enterrel elválasztva az adatokat (pl.: 20,5)");
        double[] homerseklet = new double[10];
        atlag = 0;
        for (i = 0; i < homerseklet.Length; i++){
            homerseklet[i] = double.Parse(Console.ReadLine());
            atlag += homerseklet[i];
        }
        Console.WriteLine("Hőmérsékletek átlaga: " + atlag/homerseklet.Length);
    }
}