using System;

namespace Main4 
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double num;
			Console.WriteLine ("How old are you?");
			num = Convert.ToDouble (Console.ReadLine ());
		{
				if (num > 18.23d && num < 50)
					Console.WriteLine ("You are older than 18.23");
				else if (num < 10)
					Console.WriteLine ("Under 10");
				else
					Console.WriteLine ("Else");
				string name = num == 15 ? "First" : "Second";
				Console.WriteLine (name);
		}

			Console.ReadKey ();
		}
	}
}
