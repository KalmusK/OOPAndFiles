using System;
using System.Collections.Generic;
using System.IO;

namespace OOPAndFiles
{
	class Program
	{

		class Frozen
		{
			string anna;
			string elsa;
			string anakin;
			string kristoff;
			string sven;
			string olaf;

			public Frozen(string _anna, string _elsa, string _anakin, string _kristoff, string _sven, string _olaf)
			{
				anna = _anna;
				elsa = _elsa;
				anakin = _anakin;
				kristoff = _kristoff;
				sven = _sven;
				olaf = _olaf;
			}

			//getters for frozen

			public string Anna
			{
				get { return anna; }
			}

			public string Elsa
			{
				get { return elsa; }
			}

			public string Anakin
			{
				get { return anakin; }
			}

			public string Kristoff
			{
				get { return kristoff; }
			}

			public string Sven
			{
				get { return sven; }
			}

			public string Olaf
			{
				get { return olaf; }
			}


		}
		static void Main(string[] args)
		{
			List<Frozen> myFrozens = new List<Frozen>();
			string[] frozensFromFile = GetDataFromFile();

			foreach (string line in frozensFromFile)
			{
				string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
				Frozen newFrozen = new Frozen(tempArray[0], tempArray[1], tempArray[2], tempArray[3], tempArray[4], tempArray[5]);
				myFrozens.Add(newFrozen);		
			}

			foreach (Frozen frozenFromList in myFrozens)
			{
				Console.WriteLine($"Anna wants {frozenFromList.Anna}. Elsa wants {frozenFromList.Elsa}. Anakin wants {frozenFromList.Anakin}. Kristoff wants {frozenFromList.Kristoff}. Sven wants {frozenFromList.Sven}. Olaf wants {frozenFromList.Olaf}.");
			}

		}

		public static void DisplayElementsFromArray(string[] someArray)
		{
			foreach (string element in someArray)
			{
				Console.WriteLine($"String from array: {element}");
			}
		}
		public static string[] GetDataFromFile()
		{
			string filePath = @"C:\Users\...\samples\frozen.txt";
			string[] dataFromFile = File.ReadAllLines(filePath);

			return dataFromFile;
		}


	}




}
