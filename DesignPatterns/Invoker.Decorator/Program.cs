using System;
using Decorator;

namespace Invoker.Decorator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ICafe cafe = new Cafe ();
			var cafeComLeite = new CafeComLeite (cafe);
			var cappuccino = new Cappuccino (cafe);

			Console.WriteLine (cafeComLeite.GetDescricao());
			Console.WriteLine (cappuccino.GetDescricao());
		}
	}
}
