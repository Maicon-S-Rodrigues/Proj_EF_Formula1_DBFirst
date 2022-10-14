using Proj_EF_Formula1_DBFirst.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_EF_Formula1_DBFirst.View
{
    internal class CarView
    {
        public void Car()
        {
            MainMenuView mainMenuView = new MainMenuView();
            CarController carController = new CarController();
            int opc;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n Carros");
                    Console.WriteLine(" Escolha a Opção desejada:");
                    Console.WriteLine(" 1 - Cadastrar");
                    Console.WriteLine(" 2 - Ver Todos Carros Cadastrados");
                    Console.WriteLine(" 3 - Editar Dados de um Carro");
                    Console.WriteLine(" 0 - Voltar ao Menu Principal");
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            carController.InsertCar();
                            break;

                        case 2:
                            carController.SelectAll();
                            break;

                        case 3:
                            //string carId = carController.SelectOne();
                            //if (carId != null) UpdateCar(carId);
                            break;

                        case 0:
                            mainMenuView.Menu();
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
        //public void UpdateCar(string carId)
        //{
        //    TeamController teamController = new TeamController();

        //    Equipe activeTeam = teamController.GetTeam(teamName);
        //    int opc;
        //    do
        //    {
        //        try
        //        {
        //            Console.Clear();
        //            Console.WriteLine("\n " + activeTeam.ToString());
        //            Console.WriteLine(" Escolha a Opção desejada:");
        //            Console.WriteLine(" 1 - Alterar Nome");
        //            Console.WriteLine(" 2 - Deletar Equipe");
        //            Console.WriteLine(" 0 - Sair");
        //            opc = int.Parse(Console.ReadLine());

        //            switch (opc)
        //            {
        //                case 1:
        //                    Console.Clear();
        //                    teamController.UpdateTeamName(activeTeam);
        //                    break;

        //                case 2:
        //                    teamController.DeleteTeam(activeTeam);
        //                    break;

        //                case 0:
        //                    return;

        //                default:
        //                    Console.WriteLine("\n Escolha uma opção valida...");
        //                    UtilityController.Pause();
        //                    break;
        //            }

        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("\n\nErro: <<<" + e + ">>> \n\n");
        //            UtilityController.Pause();
        //            throw;
        //        }
        //    } while (true);
        //}
    }
}
