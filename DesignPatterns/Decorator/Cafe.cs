using System;
using System.Collections.Generic;

namespace Decorator {
    public sealed class Cafe : ICafe {
        public Cafe () {
        }

        public double GetPreco { get { return 1.20; } }
        public List<string> GetIngredientes { get { return new List<string> { "café" }; } }
    }
}