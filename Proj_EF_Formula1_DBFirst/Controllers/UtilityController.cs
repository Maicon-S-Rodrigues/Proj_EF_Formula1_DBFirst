using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_EF_Formula1_DBFirst.Controllers
{
    static public class UtilityController
    {
        static public void Pause()
        {
            Console.WriteLine("\n Aperte [-- ENTER --] para Continuar...");
            Console.ReadKey();
        }
    }
}
