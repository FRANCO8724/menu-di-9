using System;
using System.Collections.Generic;
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

            string[] arr = new string[100];

            //stuttura menù
            do
            {
                //stampa delle opzioni



                Console.Clear();
                Console.WriteLine("1 - Aggiunta di un nome: ");
                Console.WriteLine("2 - Cancellazione del singolo nome: ");
                Console.WriteLine("3 - Ordinamento dei nomi: ");
                Console.WriteLine("4 - Ricerca sequenziale: ");
                Console.WriteLine("5 - Visualizza nomi ripetuti con numero ripetizioni: ");
                Console.WriteLine("6 - Modifica di un nome: ");
                Console.WriteLine("7 - Visualizzazione di tutti i nomi presenti: ");
                Console.WriteLine("8 - Ricerca del nome più lungo e più corto: ");
                Console.WriteLine("9 - Cancellazione di tutte le occorrenze di un nome: ");
                Console.WriteLine("0 - uscita");
                //scelta dell'opzione
                Console.WriteLine("inserisci la scelta ");
                scelta = int.Parse(Console.ReadLine());


                //esecuzione dell'opzione
                switch (scelta)
                {
                    case 1:

                        Console.WriteLine("inserisci l'elemento ");
                        string ele = Console.ReadLine();

                        if (AddArray(arr,ref dim,ele) == true)
                        {
                            Console.WriteLine("elemnto inserito correttamente");
                        }
                        else
                        {
                            Console.WriteLine("array pieno");
                        }

                        break;

                        case 2:



                        break;

                    case 3:

                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine(arr[i]);
                        }

                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:

                        break;

                    case 7:

                        break;

                    case 8:

                        break;

                    case 9:

                        break;


                }
                Console.ReadLine();
            } while (scelta != 0);


        }
        public static bool AddArray(string[] a,ref int index, string e)
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

        public static bool Deeletelement(string[] a, ref int index, string e)
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

    }
}