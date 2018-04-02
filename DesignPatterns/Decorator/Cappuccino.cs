using System;
using System.Collections.Generic;

namespace Decorator
{
	public class Cappuccino : Decorator
	{
		public Cappuccino (ICafe cafe) : base (cafe)
		{
		}

		public override double Preco { get { return this._cafe.Preco * 3; } }

		public override List<string> Ingredientes 
		{ 
			get 
			{
				var ingredientes = new List<string> ();
				ingredientes.AddRange(this._cafe.Ingredientes);
				ingredientes.Add ("espuma de leite fervida");
				return ingredientes;
			}
		}

		public override string GetDescricao ()
		{
			return string.Format ("[Cappuccino: Preco={0}, Ingredientes={1}]", Preco, GetIngredientes());
		}
	}
}

