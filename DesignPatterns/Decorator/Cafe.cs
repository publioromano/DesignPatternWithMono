using System;
using System.Collections.Generic;

namespace Decorator
{
	public sealed class Cafe : ICafe
	{
		private double _preco;
		private List<string> _ingredientes;

		public Cafe ()
		{
			this._preco = 0.50;
			this._ingredientes = new List<string> { "café" };
		}

		public double Preco { get { return this._preco; } }
		public List<string> Ingredientes { get { return this._ingredientes; } }
	}
}

