using System;

namespace MyFirstConsoleApp
{
    class Program
    {

        /* 
         
            Tema 1 
         
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        */

        /* 
             Tema 2:
        */

        static void Main(string[] args)
        {

            Console.WriteLine("------------ Exercitiul 1 --------------\n");

            int a = 3;
            int b = (a = 2) * a;
            int c = b * (b = 5);
            Console.WriteLine("a=" + a + ", b=" + b + ", c=" + c);
            // a = 3, b = 4 , c = 4 * 5 = 20 

            
            Console.WriteLine("\n------------ Exercitiul 2 --------------\n");

            double d = 2.95;
            int i = 4;
            Console.WriteLine(++d > i ? d : i);

            // afiseaza valoarea variabilei i. Afiseaza 4 

            Console.WriteLine("\n------------ Exercitiul 3 --------------\n");

            a = 3;
            if (++a < 4)
                if (a++ < 4)
                    Console.WriteLine(a);
                else
                    Console.WriteLine(a);

            // nu va afisa nimic. Verifica daca 4<4

            Console.WriteLine("\n------------ Exercitiul 4 --------------\n");

            int suma = 0;
            for ( i = 1; i < 10; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("Suma este: " +suma);

           
            Console.WriteLine("\n------------ Exercitiul 5 --------------\n");

            int n = 2,fact = 1;
            for(i=1;i<=n;i++)
            {
                fact *= i;
            }

            Console.WriteLine("Rezultatul pentru " +  n + "! este " + fact);
 


            Console.WriteLine("\n------------ Exercitiul 6 --------------\n");

            int q = 0, w = 7, l = -2;
            int min = q;
            if (min > w) 
                min = w;
            if (min > l)
                min = l;

            Console.WriteLine("Min este: " + min);

            Console.WriteLine("\n------------ Exercitiul 7 --------------\n");

            int nr = 4;
            Console.WriteLine(nr%2==0 ? "Numarul este par." : "Numarul este impar.");

            Console.WriteLine("\n------------ Exercitiul 8 --------------\n");

            int day = 1;
            switch(day)
            {
                case 1:
                    Console.WriteLine("Este luni. :((");
                    break;
                case 2:
                    Console.WriteLine("Este marti. :(");
                    break;

                case 3:
                    Console.WriteLine("Este miercuri. :)");
                    break;

                case 4:
                    Console.WriteLine("Este joi. :D");
                    break;
                case 5:
                    Console.WriteLine("Este vineri. Ieeiii");
                    break;
                case 6:
                    Console.WriteLine("Este sambata. Ieeiii ");
                    break;
                case 7:
                    Console.WriteLine("Este duminica. Ieeiii");
                    break;
            }


            Console.WriteLine("\n------------  --------------\n");

            int nrSeconds = 33503;

            Console.WriteLine("Pentru " + nrSeconds + " avem " + nrSeconds / 3600 + " ore " + (nrSeconds% 3600)/60 + " minute " + (nrSeconds % 3600) % 60 + " secunde.");


        }





    }
}
