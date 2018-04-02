using System;
using System.Collections.Generic;

namespace Decorator
{
	public class CafeComLeite : Decorator
	{
		public CafeComLeite (ICafe cafe) : base (cafe)
		{
		}

		public override double Preco { get { return this._cafe.Preco + 0.30; } }

		public override List<string> Ingredientes 
		{ 
			get 
			{
				var ingredientes = new List<string> ();
				ingredientes.AddRange(this._cafe.Ingredientes);
				ingredientes.Add ("leite");
				return ingredientes;
			}
		}

		public override string GetDescricao ()
		{
			return string.Format ("[CafeComLeite: Preco={0}, Ingredientes={1}]", Preco, GetIngredientes());
		}
	}
}
				