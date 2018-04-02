using System;
using System.Collections.Generic;

namespace Decorator {
    public abstract class Decorator : ICafe {
        protected ICafe _cafe;

        public Decorator (ICafe cafe) {
            this._cafe = cafe;
        }

        public virtual double GetPreco { get { return this._cafe.GetPreco; } }
        public virtual List<string> GetIngredientes { get { return this._cafe.GetIngredientes; } }
        public abstract void AdicionarIngredientes();
        protected string GetIngredientesString () {
            var str = string.Join (",", this.GetIngredientes.ToArray ());
            return str;
        }

        public virtual string GetDescricao () {
            return string.Format ("[{0}: Preco={1}, Ingredientes={2}]", this.GetType().Name , GetPreco, GetIngredientesString ());
        }
    }
}