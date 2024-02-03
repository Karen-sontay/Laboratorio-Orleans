using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Mundo
{
    public interface IHelloGrain : IGrainWithStringKey
    {
        ValueTask<string> SayHello(string greeting);
    }
}
