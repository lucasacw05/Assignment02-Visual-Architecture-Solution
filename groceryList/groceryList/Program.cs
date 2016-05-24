using System;
using System.Collections.Generic;

namespace groceryList
{
	class MainClass
	{
		public static void Main (string[] args)
		{

		

			//Console.WriteLine (done[0]);

			List<String> [] needHave= new List<String> [5];

			//This is the Need List
			needHave[0]=new List<string>();
			needHave[0].Add("Eggs");
			needHave[0].Add("Bacon");
			needHave[0].Add("Bread");
			needHave[0].Add("Chips");



			//This is the Have list
			needHave[1]=new List<string>();
			needHave[1].Add("Salad");
			needHave[1].Add("Cheese");
			needHave[1].Add("Water");
			needHave[1].Add("Fruits");

			Console.WriteLine (needHave[0][0]);

		}
	}
}
