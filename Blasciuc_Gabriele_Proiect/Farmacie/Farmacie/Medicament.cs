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
		public string natura { set; get; }
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

			natura = sir[2];
	
			cod = int.Parse(sir[3]);
		
			pret = float.Parse(sir[4]);
			
			stoc = int.Parse(sir[5]);
			
		}
	
		public Medicament(string _denumire, string _producator, string _natura,int _cod, float _pret, int _stoc)
		{
			denumire = _denumire;
			producator = _producator;
			cod = _cod;
			natura = _natura;
			pret = _pret;
			stoc = _stoc;
		}
		public Medicament(int nr)
		{
			Console.Write("Denumire produs: ");
			denumire = Console.ReadLine();
			Console.Write("Producator: ");
			producator = Console.ReadLine();
			Console.WriteLine("Format: ");
			natura = Console.ReadLine();
			Console.Write("Cod produs: ");
			cod = Int32.Parse(Console.ReadLine());
			Console.Write("Pret: ");
			pret = float.Parse(Console.ReadLine());
			Console.Write("Stoc: ");
			stoc = Int32.Parse(Console.ReadLine());
			
		}
		public string afisare()
		{
			return string.Format("{0} {1} {2} {3} {4} {5}",denumire,producator,natura,cod, pret,stoc);
		}
		public void scriere_in_fisier()
		{
			using (StreamWriter sr = new StreamWriter("C:\\Users\\gabri\\Desktop\\PIU_Lab\\Farmacie\\medicamente_out.txt", true))
			{
					sr.WriteLine(afisare());
			}
		}

		~Medicament()
		{
			
		}

	}
}