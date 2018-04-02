using System;
using System.Collections.Generic;

namespace Decorator {
    public class Cappuccino : Decorator {
        public Cappuccino (ICafe cafe) : base (cafe) { 
            AdicionarIngredientes();
        }

        public override double GetPreco { get { return this._cafe.GetPreco * 3; } }

        public override void AdicionarIngredientes()
        {
            GetIngredientes.Add("espuma de leite fervida");
            GetIngredientes.Add("leite");
            GetIngredientes.Add("canela");            
        }
    }
}