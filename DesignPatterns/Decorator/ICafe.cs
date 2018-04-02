using System;
using System.Collections.Generic;
namespace Decorator
{
	public interface ICafe
	{
		double Preco { get; }
		List<string> Ingredientes { get; }
	}
}

