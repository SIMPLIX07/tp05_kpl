using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul5_103022300113
{
    class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine("Halo user " + user);
        }
    }
}
