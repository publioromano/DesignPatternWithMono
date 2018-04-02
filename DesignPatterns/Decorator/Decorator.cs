using System;
using System.Collections.Generic;

namespace Decorator
{
	public abstract class Decorator : ICafe
	{
		protected ICafe _cafe;
		
		public Decorator (ICafe cafe)
		{
			this._cafe = cafe;
		}

		public virtual double Preco { get { return this._cafe.Preco;} }
		public virtual List<string> Ingredientes { get { return this._cafe.Ingredientes; } }
		public abstract string GetDescricao ();
		protected string GetIngredientes()
		{
			var str = string.Join (",", this.Ingredientes.ToArray ());
			return str;
		}
	}
}