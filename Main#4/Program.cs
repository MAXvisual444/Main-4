using System;

namespace Main4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num, num_1;
	
			Console.WriteLine ("Enter first num: ");
			num = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("\nEnter second num: ");
			num_1 = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("The result is: " + (num + num_1). ToString ());
			Console.ReadKey ();
		}
	}
}
