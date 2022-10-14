using Proj_EF_Formula1_DBFirst.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_EF_Formula1_DBFirst
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            MainMenuView main = new MainMenuView();
            main.Menu();
        }
    }
}
