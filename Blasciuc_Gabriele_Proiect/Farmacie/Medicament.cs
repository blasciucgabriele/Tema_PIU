//BLASCIUC GABRIELE-ANDREA, gr.3124a
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
	public class Medicament
	{
		public string denumire { set; get; }
		public string producator { set; get; }
		public int cod { set; get; }
		public int stoc { set; get; }
		public float pret { set; get; }
		public Natura natura { set; get; }
		public Eliberare mod_eliberare { get; set; }

		public DateTime dataActualizare = new DateTime();

	

		public Medicament()
		{
			denumire = null;
			producator = null;
			cod = 0;
			pret = 0;
			stoc = 0;
		}
		public Medicament(string info)
		{
			string[] sir = info.Split(',');
			denumire = sir[0];

			producator = sir[1];

			natura = (Natura)Enum.Parse(typeof(Natura), sir[2]);

			cod = int.Parse(sir[3]);
		
			pret = float.Parse(sir[4]);
			
			stoc = int.Parse(sir[5]);

			mod_eliberare = (Eliberare)Enum.Parse(typeof(Eliberare), sir[6]);
			
		}
	
		public Medicament(string _denumire, string _producator, string _natura,int _cod, float _pret, int _stoc, string _el)
		{
			denumire = _denumire;
			producator = _producator;
			cod = _cod;
			natura = (Natura)Enum.Parse(typeof(Natura), _natura);
			pret = _pret;
			stoc = _stoc;
			mod_eliberare = (Eliberare)Enum.Parse(typeof(Eliberare), _el);
		}
		public Medicament(int nr)
		{
			Console.Write("Denumire produs: ");
			denumire = Console.ReadLine();
			Console.Write("Producator: ");
			producator = Console.ReadLine();
			Console.Write("Cod produs: ");
			cod = Int32.Parse(Console.ReadLine());
			Console.Write("Pret: ");
			pret = float.Parse(Console.ReadLine());
			Console.Write("Stoc: ");
			stoc = Int32.Parse(Console.ReadLine());
			
		}
		public string afisare()
		{
			return string.Format("{0,-5}{1,-10}{2,-15}{3,-10}{4,-10}{5,-10}{6,-10}", denumire,producator,natura,cod, pret,stoc,mod_eliberare);
		}
		public void Add_Medicament()
		{
			try
			{
				using (StreamWriter swFisierText = new StreamWriter("C:\\Users\\gabri\\Desktop\\PIU\\Farmacie\\medicamente.txt", true))
				{

					swFisierText.WriteLine(String.Format("{0,-15}{1,-15}{2,-20}{3,-15}{4,-12}{5,-10}{6,-10}\n", denumire, producator, Convert.ToString(natura),cod, pret, stoc, mod_eliberare.ToString()));
				}
			}
			catch (IOException eIO)

			{
				throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
			}
			catch (Exception eGen)
			{
				throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
			}
		}
		~Medicament()
		{
			
		}

	}
}