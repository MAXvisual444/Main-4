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
				
			if (num > 18.23d)
			Console.WriteLine ("You are older than 18.23");	
			}

			Console.ReadKey ();
		}
	}
}
