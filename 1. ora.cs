/*
	Short keys:
	alt + le/fel nyíl			sorok mozgatása
	alt + shift + le/fel nyíl	sorok duplikálása
	ctrl + f5					run
	alt + f5					debug
	f7							Check syntax
	crtl + c					másol
	ctrl + v					beilleszt
	ctrl + z					visszavon
	ctrl + y					visszavonja a visszavonást
	ctrl + s					ment
	Ha kijelölsz egy több soros kódrészletet és tabulátornyit akarod mozgatni:
	tab							jobbra tol egy tabulátornyit
	shift + tab					balra tol egy tabulátornyit

	C#: Modern, fejlett, magas szintű progrmozási nyelv egy csomó előre megírt függvénnyel. Microsoft fejlesztette (van hozzá 
		dokumentáció, referenciák a neten) a .NET keretrendszerrel Egyszerű szintaktika, Objektum Orientált, alapja a C++ és a 
		java, szóval ha az megy, akkor ez sem lesz nehéz és fordítva is igaz. Erősen tipusos, dinamikus és statikus elemei is vannak.   

	Visual Studio Code egy egyszerű fejlesztő környezet, alapból kb egy szövegszerkesztőhöz lehet hasonlítani, és kell nekünk majd a
		GitLab letöltése, hogy a githubbal össze lehessen kötni. Kell egy kiegészítő, hogy C# kódot tudjunk írni benne és futtatni 
		(CS-Script). Így már többet tud, mint egy szövegszerkesztő
		Van egy csomó kiegészítő hozzá, így lehet a kódot is színesebbé tenni pl.: "Prettier - Code formatter"

	Visual Studio 2022 rövid ismertetése(komplexebb, kiegészítőket lehet letölteni, intelligensebb, 
		Asztali alkalmazást is lehet benne csinálni, webes alkalmazás írására is alkalmas, mindegy melyiket használjuk,
		mert most nem kell nekünk olyan, amit a code nem tud)

	Run in terminal kell majd nekünk, ha bekérünk adatokat

	Az órai anyagokat hol találják majd meg (Légyszi csinálj egy github fiókot, és oda minden óra végén tedd fel, hogy meddig jutottatok)
*/
using System;

class Program{
    public static void Main(){
        Console.Write("Hello Word!");                               //Simán egymás mellé tudsz kiírni 
        Console.WriteLine("Ez a legjobb nap, hogy elkezdd tanulni a C#-ot.");

        Console.WriteLine("Új sor\nA kiirast " + "igy is " + "ossze tudod fuzni.");
        //\n sortörés; \t tabulátor

		/*
         Ez egy több soros komment
         Nagyon hasznos ha például egy kódrészt egy ideig
         nem szeretnénk futtatni, de később még szükségünk lehet rá.
         Így nem veszik el de nem is fut le.
		 
		 Vagy ha a késöbbiekben többen akartok dolgozni egy
		 projecten és így röviden el tudjátok magyarázni, hogy mit csinál
		 vagy milyen adatokat ad át, mit vár stb..
        */

        Console.WriteLine("Nyomj le egy gombot és a program futása leáll.");
		//Egyenlőre nem szükséges, Visual Studio 2022/2019-ben kell, mert ott terminál ablakot nyit meg!!
		Console.ReadKey(true); //ha terminálablakban futtatjuk, akkor megvárja, amíg leütünk egy gombot és csak utána zárja be magát
    }
}