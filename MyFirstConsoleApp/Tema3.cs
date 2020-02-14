using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp
{
    class Tema3
    {
        public void ex1()
        {

            Console.WriteLine("------------ The exercise 1 --------------\n");

            double[] vectorDouble = { 1.1, 1.2, 1.3 };

            Console.Write("1. Valori vector: ");

            for (int i=0;i<vectorDouble.Length;i++)
            {

                Console.Write(vectorDouble[i]  + " ");
            }

        }

        public void ex2()
        {
            Console.WriteLine("\n\n------------ The exercise 2 --------------\n");

            int[] vectorValues = { 9, 10 , 2 , 0 , 10 , 99 , 234 , 2003, 8000, -2 };

            int min = vectorValues[0];
            int max = vectorValues[0];

            for (int i = 0; i < vectorValues.Length; i++)
            {
                if (min > vectorValues[i])
                {
                    min = vectorValues[i];
                }
                if(max< vectorValues[i])
                {
                    max = vectorValues[i];
                }
            }

            Console.Write("2. Min: " + min + " / Max : " + max);

        }

        public void ex3()
        {
            Console.WriteLine("\n\n------------ The exercise 3 --------------\n");

            int[] vector = { 22, 55, 99, -33, 5, 10, 9 };

            NegativeArray position = new NegativeArray(vector);
           

        }
        public void ex4()
        {
            Console.WriteLine("\n\n------------ The exercise 4 --------------\n");
            string word = "Petrisor";
            StringToArray wordToCharArray = new StringToArray(word);

        }
        public void ex5()
        {
            Console.WriteLine("\n\n------------ The exercise 5 --------------\n");

            string stringChar = "Transformati un sir de caractere astfel: fiecare litera de pe pozitie para sa fie uppercase.";
            char[] arrayChar = stringChar.ToCharArray();
            for(int i=0;i< arrayChar.Length;i++)
            {
                if(i%2==0)
                {
                    arrayChar[i] =  Char.ToUpper(arrayChar[i]);
                }
                Console.Write(arrayChar[i]);
            }

        }
        
        public void ex6()
        {
            Console.WriteLine("\n\n------------ The exercise 6 --------------\n");

            int[] vectorValuesInt = { 1, 3, 5, 7, 9, 11, 13, 15 };
            double numberDouble = 3.33;
            double[] newVectorWithDoubleValues = new double[vectorValuesInt.Length];

            for(int i = 0; i< vectorValuesInt.Length;i++)
            {
                newVectorWithDoubleValues[i] = vectorValuesInt[i] + numberDouble;
                Console.Write(newVectorWithDoubleValues[i] + " ");

            }
        }

        public void optional()
        {

            Console.WriteLine("\n\n------------ The optional exercise  --------------\n");

            String prop = "Acesta este un exercitiu mai interesant";
            string[] words = prop.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.WriteLine("\nLength array: " + words.Length);


        }


        class NegativeArray
        {
            public NegativeArray(int[] vector)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    if (vector[i] < 0)
                    {
                        Console.Write("3. Position for negative number: " + i);
                    }
                }
            }

        }


        class StringToArray
        {
            public StringToArray(string word)
            { 
                char[] charArr = word.ToCharArray();
                for(int i=0;i < charArr.Length;i++)
                {
                    Console.Write(charArr[i] + " ");
                }
            }

        }

    }
}
