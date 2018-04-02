using System;
using System.Collections.Generic;
namespace Decorator {
    public interface ICafe {
        double GetPreco { get; }
        List<string> GetIngredientes { get; }
    }
}