using System;

namespace valtozok
{
	class Program
	{
		//Globális változó deklarálása(nem csak a main függvényen belül érhető el)
		public static void Main(string[] args)
		{
			//Ismétlés
			Console.WriteLine("Itt egy mondat van.");
			Console.WriteLine("Itt egy mondat van.");
			Console.WriteLine("Itt egy mondat van.");
			Console.WriteLine("Itt egy mondat van.");

			string szoveg = "Itt egy mondat van";
			Console.WriteLine(szoveg);
			Console.WriteLine(szoveg);
			Console.WriteLine(szoveg);
			Console.WriteLine(szoveg);

			//betűk
			//char
			char a = 'a';
			char b = 'z';
			Console.WriteLine(a + b);       //ASCII kódját adja össze a számoknak
			
			//string konverzió
			Console.WriteLine(a.ToString() + b.ToString());
			
			//számok
			//int
			
			int i = 1;
			Console.WriteLine("int: " + int.MinValue + "->" + int.MaxValue);
			Console.WriteLine(i);//1

			i = i+1;
			Console.WriteLine(i);//2
			
			i++;
			Console.WriteLine(i);//3
			
			i +=2;
			Console.WriteLine(i);//5

			i = 5/2;
			Console.WriteLine(i);//2

			double d = 5/2;
			Console.WriteLine("d: " + d);//0

			//double: -1,7976931348623157E+308 -> 1,7976931348623157E+308
			Console.WriteLine("Double:\t" + Double.MinValue + " -> " + Double.MaxValue);
			
			d = 5/i;
			Console.WriteLine(d);

			//double konverzió
			d = 5/(double)i;
			Console.WriteLine(d);

			Console.WriteLine(d.ToString() + i.ToString());
			Console.WriteLine(d + "/" + i +"=" + d);

			string alma = "alma";
			string banan = "banan";
			Console.WriteLine( alma + " " + banan);
			Console.WriteLine( alma + "\t" + banan );
			Console.WriteLine( alma + "\n" + banan );
		}
	}
}