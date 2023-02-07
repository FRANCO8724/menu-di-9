using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;
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
            int scelta = 0;
            int dim = 0;
            int dim1 = 0;
            int dim3 = 0;
            int cont = 0;
            int lung = 0;

            string[] arr = new string[100];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = "";
            }

            //stuttura menù
            do
            {
                //stampa delle opzioni

                Console.Clear();
                Console.WriteLine("23 - Gestione array di nomi di animali");
                Console.WriteLine(" ");
                Console.WriteLine("          1 - Aggiunta di un nome: ");
                Console.WriteLine("          2 - Cancellazione del singolo nome: ");
                Console.WriteLine("          3 - Ordinamento dei nomi: ");
                Console.WriteLine("          4 - Ricerca sequenziale: ");
                Console.WriteLine("          5 - Visualizza nomi ripetuti con numero ripetizioni: ");
                Console.WriteLine("          6 - Modifica di un nome: ");
                Console.WriteLine("          7 - Visualizzazione di tutti i nomi presenti: ");
                Console.WriteLine("          8 - Ricerca del nome più lungo e più corto: ");
                Console.WriteLine("          9 - Cancellazione di tutte le occorrenze di un nome: ");
                Console.WriteLine(" ");
                Console.WriteLine("0 - uscita");
                Console.WriteLine(" ");
                //scelta dell'opzione
                Console.WriteLine("inserisci la scelta ");
                scelta = int.Parse(Console.ReadLine());


                //esecuzione dell'opzione
                switch (scelta)
                {
                    case 1:

                        Console.WriteLine("inserisci l'elemento ");
                        string ele = Console.ReadLine();


                        if (AddArray(arr, ref dim, ele) == true)
                        {
                            Console.WriteLine("elemnto inserito correttamente");
                        }
                        else
                        {
                            Console.WriteLine("array pieno");
                        }

                        break;

                    case 2:

                        Console.WriteLine("inserisci l'elemento da rimuovere ");
                        string rim = Console.ReadLine();

                        Deletelement(arr, ref dim1, rim);


                        break;

                    case 3:

                        BubbleSort(lung, arr);
                        Console.WriteLine(" ");
                        Console.WriteLine("Elementi ordinati ");

                        break;

                    case 4:

                        Console.WriteLine("inserisci l'elemento da cercare ");
                        string rim2 = Console.ReadLine();

                        if (Research(arr, rim2) == true)
                        {
                            Console.WriteLine("L'elemento è presente nell'array ");
                        }
                        else
                        {
                            Console.WriteLine("L'elemento non è presente nell'array ");
                        }

                        break;

                    case 5:

                        Console.WriteLine(Repeat(lung, arr));

                        break;


                    case 6:

                        Console.WriteLine("inserisci l'elemento ");
                        string elem = Console.ReadLine();

                        Console.WriteLine("inserisci la posizione ");
                        int pos = int.Parse(Console.ReadLine());

                        if (AddArray(arr, elem, pos) == true)
                        {
                            Console.WriteLine("elemnto inserito correttamente");
                        }
                        else
                        {
                            Console.WriteLine("array pieno");
                        }
                        break;

                        break;

                    case 7:

                        Stamp(arr);

                        break;

                    case 8:

                        Console.WriteLine(Lunghezza(arr,lung));
                        break;

                    case 9:

                        Console.WriteLine("inserisci l'elemento da eliminare ");
                        string el = Console.ReadLine();

                        Remdopp(arr, el);

                        break;


                }
                Console.ReadLine();
            } while (scelta != 0);


        }

        //funzione 1
        public static bool AddArray(string[] a, ref int index, string e)
        {


            //controllare se abbiamo raggiunto la dimensione massima
            bool inserito = true;

            if (index < a.Length)
            {
                //aggiungere l'elemento
                a[index] = e;
                //incrementare l'indice
                index++;
            }
            else
            {
                inserito = false;
            }

            return inserito;

        }

        //funzione 2
        public static void Deletelement(string[] a, ref int index, string e)
        {

            for (int i = 0; i < a.Length; i++)
            {

                if (a[i].ToLower() == e.ToLower())
                {
                    for (int j = i; j >= i && j < 99; j++)
                    {
                        a[j] = a[j + 1];
                    }
                    break;
                }

            }

        }

        //funzione 3
        static void BubbleSort(int lun, string[] arr)
        {
            int x, y;
            string temp;
            for (x = 0; x < lun - 1; x++)
            {
                for (y = 0; y < lun - 1; y++)
                {
                    int comp = string.Compare(arr[y], arr[y + 1]);
                    if (comp == 1)
                    {
                        temp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = temp;
                    }
                }
            }
        }                               //bubblesort 




        // funzione 4

        public static bool Research(string[] a, string e)
        {

            bool elemento = false;

            for (int i = 0; i < a.Length; i++)
            {

                if (a[i].ToLower() == e.ToLower())
                {
                    elemento = true;
                }
            }

            return elemento;

        }

        //funzione 5

        public static string Repeat(int lun,string[] arr)
        {
            int[] occorrenze = new int[lun];
            string[] uni = new string[lun];
            string outp = "";
            for (int i = 0; i < lun; i++)
            {
                uni[i] = arr[i];
            }
            int x, y;
            string temp;
            for (x = 0; x < lun - 1; x++)
            {
                for (y = 0; y < lun - 1; y++)
                {
                    int comp = string.Compare(uni[y], uni[y + 1]);
                    if (comp == 1)
                    {
                        temp = uni[y];
                        uni[y] = uni[y + 1];
                        uni[y + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < lun; i++)
            {
                if (uni[i] != "")
                {
                    occorrenze[i] = 1;
                    for (int j = i + 1; j < lun; j++)
                    {
                        if (uni[i] == uni[j])
                        {
                            uni[j] = "";
                            occorrenze[i]++;
                        }
                    }
                    if (occorrenze[i] > 1)
                    {
                        outp += ($"{uni[i]}: {occorrenze[i]}");
                    }
                }
            }
            return outp;
        }

        //funzione 6

        static bool AddArray(string[] a, string e, int t)
        {
            //controllare se abbiamo raggiunto la dimensione massima
            bool inserito = true;
            if (t < a.Length)
            {
                int o = t - 1;
                //aggiungere l'elemento
                a[o] = e;

            }
            else
            {
                inserito = false;
            }

            return inserito;
        }

        //funzione 7
        public static void Stamp(string[] a)
        {


            for (int i = 0; i < 99; i++)
            {
                if (a[i] == "")
                {
                    break;
                }

                else
                {
                    Console.WriteLine(a[i]);
                }

            }

        }

        //funzione 8

        public static string Lunghezza(string[] arr, int lun)
        {
            string lungo = arr[0], corto = arr[0];
            string outp = "";
            for (int i = 1; i < lun; i++)
            {

                if (arr[i].Length > lungo.Length)
                {
                    lungo = arr[i];
                }
                if (arr[i].Length < corto.Length)
                {
                    corto = arr[i];
                }
            }
            outp += ($"il nome più lungo è: {lungo}\nil nome più corto è: {corto}");
            return outp;
        }

        //funzione 9

        public static void Remdopp(string[] a, string e)
        {

            for (int g = 0; g < a.Length; g++)
            {

                if (a[g].ToLower() == e.ToLower())
                {
                    for (int j = g; j < 99; j++)
                    {
                        a[j] = a[j + 1];
                    }

                }

            }

        }

    }

}
