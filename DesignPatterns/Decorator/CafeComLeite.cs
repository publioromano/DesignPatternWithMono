using System;
using System.Collections.Generic;

namespace Decorator {
    public class CafeComLeite : Decorator {
        public CafeComLeite (ICafe cafe) : base (cafe) { 
            AdicionarIngredientes();
        }

        public override double GetPreco { get { return this._cafe.GetPreco + 0.30; } }
        public override void AdicionarIngredientes()
        {
            GetIngredientes.Add("leite");
        }
    }
}