using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionearray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dichiarazione dell'array
            //numero elementi utilizzati
            int j = 0;
            int scelta = 0;

            Console.WriteLine("inserisci numero di elementi ");
            int ele = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci inizio ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci fine ");
            int y = int.Parse(Console.ReadLine());
            int[] arr = new int[ele];

            //stuttura menù
            do
            {
                //stampa delle opzioni



                Console.Clear();
                Console.WriteLine("1 - Stampa array");
                Console.WriteLine("2 - Troncamento array");
                Console.WriteLine("3 - Inserimento elemento nell'array");
                Console.WriteLine("1 - Stampa array");
                Console.WriteLine("2 - Troncamento array");
                Console.WriteLine("3 - Inserimento elemento nell'array");
                Console.WriteLine("1 - Stampa array");
                Console.WriteLine("2 - Troncamento array");
                Console.WriteLine("3 - Inserimento elemento nell'array");
                Console.WriteLine("0 - uscita");
                //scelta dell'opzione
                Console.WriteLine("inserisci la scelta ");
                scelta = int.Parse(Console.ReadLine());


                //esecuzione dell'opzione
                switch (scelta)
                {
                    case 1:

                        AddArray(arr, ele, x, y, j);

                        for (int i = 0; i < ele; i++)
                        {
                            Console.WriteLine(arr[i]);
                        }

                        break;

                    case 2:

                        Console.WriteLine("inserisci numero di elementi dell'array ");
                        int num = int.Parse(Console.ReadLine());

                        var array2 = arr;
                        Array.Resize<int>(ref arr, num);

                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine("inserisci numero nell'array ");
                            int a = int.Parse(Console.ReadLine());
                            arr[i] = a;
                        }

                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine(arr[i]);
                        }

                        break;

                    case 3:

                        Console.WriteLine("inserisci elemento dell'array ");
                        int v = int.Parse(Console.ReadLine());


                        Console.WriteLine("inserisci la posizione ");
                        int l = int.Parse(Console.ReadLine());

                        if (l < ele)
                        {
                            Enterarray(arr, v, l);
                        }
                        else
                        {
                            Console.WriteLine(" La posizione del numero è più grande della grandezza dell'array ");
                        }
                        break;

                }
                Console.ReadLine();
            } while (scelta != 0);


        }
        public static void AddArray(int[] f, int o, int a, int b, int l)
        {
            Random random = new Random();

            for (int i = 0; i < o; i++)
            {
                int num1 = random.Next(a, b);

                if (l < o)
                {
                    f[l] = num1;
                    l = l + 1;
                }
            }



        }

        static void Troncamento(int[] a, int p)
        {
            int[] tronc = new int[p];

            for (int i = 0; i < p; i++)
            {
                tronc[i] = a[i];
            }

        }

        static void Enterarray(int[] a, int s, int m)
        {


            a[m] = s;


        }

    }
}