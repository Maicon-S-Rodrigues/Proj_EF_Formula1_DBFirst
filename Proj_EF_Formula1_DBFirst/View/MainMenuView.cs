using Proj_EF_Formula1_DBFirst.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proj_EF_Formula1_DBFirst.View
{
    public class MainMenuView
    {
        public void Menu()
        {
            CarView carView = new CarView();
            PilotView pilotView = new PilotView();
            EventView eventView = new EventView();
            TeamView teamView = new TeamView();
            int opc;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n FI2022");
                    Console.WriteLine(" Escolha a Opção desejada:");
                    Console.WriteLine(" 1 - Equipes");
                    Console.WriteLine(" 2 - Carros");
                    Console.WriteLine(" 3 - Pilotos");
                    Console.WriteLine(" 4 - Eventos");
                    Console.WriteLine(" 0 - Sair");
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            teamView.Team();
                            break;

                        case 2:
                            carView.Car();
                            break;

                        case 3:
                            //pilotView.Pilot();
                            break;

                        case 4:
                            //eventView.Event();
                            break;

                        case 0:
                            Console.WriteLine("\n Encerrando...");
                            Thread.Sleep(200);
                            Console.Write(" .");
                            Thread.Sleep(200);
                            Console.Write(" .");
                            Thread.Sleep(200);
                            Console.Write(" .");
                            Thread.Sleep(200);

                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("\n Escolha uma opção valida...");
                            UtilityController.Pause();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\nErro: <<<" + e + ">>> \n\n");
                    UtilityController.Pause();
                    throw;
                }
            } while (true);
        }
    }
}
