//BLASCIUC GABRIELE-ANDREA, gr.3124a
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
    class Program
    {
        static void Main(string[] args)
        {
            Nomenclator nom = new Nomenclator();
            string optiune, raspuns;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\tGESTIUNE - FARMACIE\t\t");
                Console.WriteLine("1. Adaugare medicamente(tastatura)\n2. Adaugare medicament(primit ca sir)\n3. Afisare medicamente\n4. Comparare produse\n5. Eliminare medicament\n6. Info Farmacie\n7. Iesire");
                Console.Write("Introduceti o optiune: ");
                optiune = Console.ReadLine();
                int opte = Int32.Parse(optiune);
                switch (opte)
                {
                    case 1:
                        while (true)
                        {
                            Console.Write("Doriti sa adaugati un produs?(DA/NU)");
                            raspuns = Console.ReadLine();
                            if (raspuns.ToUpper() == "DA") nom.adauga_produs();
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case 2:
                        nom.adauga_produs_sir("Ibuprofen,Bayer,Comprimate,18756,11.50,69");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case 4:
                        nom.compara_produse();
                        Console.WriteLine("\nPress any key...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Denumire\tProducator\tFormat\t\tCod\tPret\tStoc\n");
                        nom.afisare_medicamente();
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("Introduceti denumirea prodosului ce doriti sa eliminati: ");
                        string med = Console.ReadLine();
                        nom.sterge_produs(med);
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("Farmacia Stefan Cel Mare - Suceava(SV)");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case 7:
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            } while (true);
        }
    }
}

