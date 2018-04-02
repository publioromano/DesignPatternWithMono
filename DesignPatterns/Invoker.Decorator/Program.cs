using System;
using Decorator;

namespace Invoker.Decorator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ICafe cafe1 = new Cafe ();
			var cafeComLeite = new CafeComLeite (cafe1);

			ICafe cafe2 = new Cafe ();
			var cappuccino = new Cappuccino (cafe2);

			Console.WriteLine (cafeComLeite.GetDescricao());
			Console.WriteLine (cappuccino.GetDescricao());
		}
	}
}
