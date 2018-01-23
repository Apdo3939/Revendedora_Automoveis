using System;

namespace Revendedora_Automoveis.Classes
{
    class ModelException : Exception
    {
        public ModelException(string msg) : base(msg)
        {
            Console.WriteLine();
        }
    }
}
