using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
	class Nomenclator:Medicament
	{
		int nr_medicamente = 0;
		
		Medicament[] med = new Medicament[50];
		
		public bool isEmpty()
		{
			if (nr_medicamente == 0) return true;
			else return false;
		}
		public bool isFull()
		{
			if (nr_medicamente == 100) return true;
			else return false;
		}
		public string cauta_produs_denumire(string _nume)
		{
			for (int i = 0; i < nr_medicamente; i++)
			{
				if (String.Compare(_nume, med[i].denumire) == 0)
				{
					return med[i].afisare();
				}
			}
			return String.Format("Produsul nu exista in baza de date");
		}
		public string cauta_produs_cod(int _cod)
		{
			for (int i = 0; i < nr_medicamente; i++)
			{
				if (_cod == med[i].cod)
				{
					return med[i].afisare();
				}
			}
			return String.Format("Produsul nu exista in baza de date");
		}
		public void compara_produse()
		{

			char opt;
			do
			{
				if (isEmpty() || nr_medicamente == 1)
				{
					Console.WriteLine("Nu exista produse/Nr. insuficient(minim 2)");
					break;
				}
				Console.Clear();
				Console.WriteLine("1. Compara Pret\n2. Compara Stoc\n3. Iesire");
				Console.Write("Introduceti o optiune: ");
				opt = char.Parse(Console.ReadLine());
				switch (opt)
				{
					case '1':
						for (int i = 0; i < nr_medicamente; i++)
						{
							for (int j = i + 1; j < nr_medicamente; j++)
							{
								if (med[i].pret > med[j].pret)
								{
									Console.WriteLine("Produsul {0} este mai scump ca produsul {1}", med[i].denumire, med[j].denumire);
								}
								else Console.WriteLine("Produsul {1} este mai scump ca produsul {0}", med[i].denumire, med[j].denumire);
							}
						}
						Console.WriteLine("Press any key...");
						Console.ReadKey();
						break;
					case '2':
						for (int i = 0; i < nr_medicamente; i++)
						{
							for (int j = i + 1; j < nr_medicamente; j++)
							{
								if (med[i].stoc > med[j].stoc)
								{
									Console.WriteLine("Exista mai multe cantitati de {0} ca produsul {1}", med[i].denumire, med[j].denumire);
								}
								else Console.WriteLine("Exista mai multe cantitati de {1} ca produsul {0}", med[i].denumire, med[j].denumire);
							}
						}
						Console.WriteLine("Press any key...");
						Console.ReadKey();
						break;
					default:
						break;

				}
			} while (opt != '3');
		}
		public void adauga_produs_sir(string sir)
		{
			if (!isFull())
			{
				med[nr_medicamente] = new Medicament(sir);
				nr_medicamente++;
				Console.WriteLine("Produs adaugat cu succes!");
			}
			else Console.WriteLine("Baza de date este plina!");
		}
		public void adauga_produs()
		{
			int nr = 0;
			if (!isFull())
			{
				med[nr_medicamente] = new Medicament(nr);
				nr_medicamente++;
				Console.WriteLine("Produs adaugat cu succes!");
			}
			else Console.WriteLine("Baza de date este plina!");
		}
		public void adauga_produs_cmd(string[] c)
		{
			if (!isFull())
			{
				med[nr_medicamente] = new Medicament(c[0], c[1], c[2], int.Parse(c[3]), float.Parse(c[4]), int.Parse(c[5]));
				nr_medicamente++;
				Console.WriteLine("Produs adaugat cu succes!");
			}
			else Console.WriteLine("Baza de date este plina!");
		}

		public void sterge_produs(string _nume)
		{
			int k = -1, i;
			if (!isEmpty())
			{
				for (i = 0; i < nr_medicamente; i++)
				{
					if (String.Compare(_nume, med[i].denumire) == 0)
					{
						k = i;
					}
					if (k != -1)
					{
						for (i = k; i < nr_medicamente; i++)
						{
							med[i] = med[i + 1];
						}
						nr_medicamente--;
					}
				}
				Console.WriteLine("Produs eliminat cu succes!");
			}
			else Console.WriteLine("Nu exista produse!");
		}
		public int obtine_cod_produs(string _nume)
		{
			for (int i = 0; i < nr_medicamente; i++)
			{
				if (String.Compare(_nume, med[i].denumire) == 0)
				{
					return med[i].cod;
				}
			}
			return -1;
		}
		public string obtine_denumire_produs(int _cod)
		{
			for (int i = 0; i < nr_medicamente; i++)
			{
				if (_cod == med[i].cod)
				{
					return med[i].denumire;
				}
			}
			return String.Format("Produsul nu exista!");
		}
		public void afisare_medicamente()
		{
			if (isEmpty()) Console.WriteLine("Nu exista produse in baza de date!");
			//Console.WriteLine("DENUMIRE\tPRODUCATOR\tFORMAT\t\tCOD\tPRET\tCANTITATE");
			for (int i = 0; i < nr_medicamente; i++)
			{
				Console.WriteLine(med[i].afisare() + "\n");
			}
		}

		public void set_pret_produs(string _nume, int _pret)
		{
			for (int i = 0; i < nr_medicamente; i++)
			{
				if (String.Compare(_nume, med[i].denumire) == 0)
				{
					med[i].pret = _pret;
				}
			}
		}
		
		public void citire_din_fisier()
		{  
			using (StreamReader sr = new StreamReader("C:\\Users\\gabri\\Desktop\\PIU_Lab\\Farmacie\\Farmacie\\medicamente.txt"))
			{
				string linie;
				while ((linie = sr.ReadLine()) != string.Empty)
				{
					if (!isFull())
					{
						med[nr_medicamente] = new Medicament(linie);
						nr_medicamente++;
					}
					else Console.WriteLine("Baza de date este plina!");
				}
			}
		}
		public void scriere_in_fisier()
		{
			using (StreamWriter sr = new StreamWriter("C:\\Users\\gabri\\Desktop\\PIU_Lab\\Farmacie\\medicamente_out.txt", true))
			{
				for (int i = 0; i < nr_medicamente; i++)
				{
					sr.WriteLine(med[i].afisare());
				}
			}
		}
		public void modifica_produse()
		{
			char opt;
			int ok = 1, k = 0;
			do
			{
				Console.Clear();
				Console.Write("Introduceti numele produsului: ");
				string nume = Console.ReadLine();
				for (int i = 0; i < nr_medicamente; i++)
				{
					if (String.Compare(med[i].denumire, nume) != 0)
					{
						ok = 0;
					}
					else { ok = 1; k = i; break; }
				}
				if (isEmpty() || ok == 0)
				{
					Console.WriteLine("Nu exista produse!");
					break;
				}
				Console.Clear();
				Console.WriteLine("1. Modifica Nume\n2. Modifica Producator\n3. Modifica Format\n4. Modifica Cod\n5. Modifica Pret\n 6. Modifica Stoc\n7. Iesire");
				Console.Write("Introduceti o optiune: ");
				opt = char.Parse(Console.ReadLine());
				switch (opt)
				{
					case '1':
						Console.Write("Introduceti numele produsului: ");
						string _nume = Console.ReadLine();
						med[k].denumire = _nume;
						Console.WriteLine("Press any key...");
						Console.ReadKey();
						break;
					case '2':
						Console.Write("Introduceti numele producatorului: ");
						string _producator = Console.ReadLine();
						med[k].producator = _producator;
						Console.WriteLine("Press any key...");
						Console.ReadKey();
						break;
					case '3':
						Console.Write("Introduceti formatul produsului:");
			            med[k].natura = Console.ReadLine();
						Console.WriteLine("Press any key...");
						Console.ReadKey();
						break;
					case '4':
						Console.Write("Introduceti codul produsului: ");
						int _cod = int.Parse(Console.ReadLine());
						med[k].cod = _cod;
						Console.WriteLine("Press any key...");
						Console.ReadKey();
						break;
					case '5':
						Console.Write("Introduceti pretul produsului: ");
						float _pret = float.Parse(Console.ReadLine());
						med[k].pret = _pret;
						Console.WriteLine("Press any key...");
						Console.ReadKey();
						break;
					case '6':
						Console.Write("Introduceti nr. de produse: ");
						int _stoc = int.Parse(Console.ReadLine());
						med[k].stoc = _stoc;
						Console.WriteLine("Press any key...");
						Console.ReadKey();
						break;
					default:
						break;
				}
			} while (opt != '7');
		}

	}
}
