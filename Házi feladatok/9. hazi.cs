using System;

class Program{
    public static void Main(){
        /*
            A feladatokhoz, ha kell hozhatsz létre segéd változókat.
            Válaszokat szöveges formában írasd ki a console-ra és elé a feladatot, hogy mi volt a feladat.
            Szorgalmi feladatban lehet olyan, amit még nem vettünk, így az egy kis keresgéléssel járhat!
            Jó gyakorlást!

            1. feladat: Olvasd be és tárold el az adatokat a 9.1. hazi.txt állományból (Első sorban az adásba kerülés dátuma, majd a címe, évad 
                        száma x rész száma, terjedelem percben, legutoljára pedig, hogy látta-e a lista készítője) 
                        Így van eltárolva 5-ös tagolásban, mindegyik külön sorban.
                        Ha az évszám ismeretlen, akkor ott NI jelzés található. Utolsó adat értéke 0 vagy 1 lehet, 0-nem látta, 1-látta.
                        Írja ki, hány olyan epizód található a file-ban, aminek ismert az adásba kerülés dátuma.
                        Határozza meg, hogy a fájlban lévő epizódok hány százalékát látta már a listát rögzítő személy! A százalékértéket a minta
                        szerint, két tizedesjeggyel jelenítse meg a képernyőn!
                        Számítsa ki, hogy összesen mennyi időt töltött a személy az epizódok megnézésével! Az eredményt a minta szerint nap, óra,
                        perc formában adja meg!

            2. feladat: Készítse el az alábbi algoritmus alapján a hét napját meghatározó függvényt! A függvény neve Hetnapja legyen! A függvény 
                        az év, hónap és nap megadása után szöveges eredményként visszaadja, hogy az adott nap a hét melyik napja volt. (Az a és b
                        egész számok maradékos osztása esetén az a div b kifejezés adja meg a hányadost, az a mod b pedig a maradékot, például 17
                        div 7 = 2 és 17 mod 7 = 3.)

                        Függvény hetnapja(ev, ho, nap : Egész) : Szöveg
                            napok: Tömb(0..6: Szöveg)= (″v″, ″h″, ″k″, ″sze″, ″cs″, ″p″, ″szo″)
                            honapok: Tömb(0..11: Egész)= (0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4)
                            Ha ho < 3 akkor ev := ev -1
                                hetnapja := napok[(ev + ev div 4 – ev div 100 +
                                ev div 400 + honapok[ho-1] + nap) mod 7]
                        Függvény vége

            -----------------Szorgalmi----------------------
            1. feladat: Olvassa be a 9.2. hazi.txt állományt és tárolja el az adatokat. Írja ki a képernyőre az alábbi formátumban: A/B + C/D = E,
                        ha a sor végén + jel van, ha * vagy egyéb, akkor középen is az jelenjen meg és úgy végezze el a műveletet és jelenítse meg
                        az eredményt is.
            ------------------------------------------------ 
        */

        

    }
}