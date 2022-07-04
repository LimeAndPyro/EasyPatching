using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discreet.SDK.Patching
{
    class Initpatches
    {
        public static void Start()
        {
            PlayerPatches.Patch();
            Console.WriteLine("Patched");
        }
    }
}
