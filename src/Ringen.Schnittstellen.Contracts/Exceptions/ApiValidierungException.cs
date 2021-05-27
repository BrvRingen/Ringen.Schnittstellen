using System;
using System.Collections.Generic;

namespace Ringen.Schnittstellen.Contracts.Exceptions
{
    public class ApiValidierungException: Exception
    {
        public List<KeyValuePair<string, string>> ValidierungsFehler { get; private set; }

        public ApiValidierungException(List<KeyValuePair<string, string>> validierungsFehler)
        {
            ValidierungsFehler = validierungsFehler;
        }
    }
}
