using Proj_EF_Formula1_DBFirst.View;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_EF_Formula1_DBFirst.Controllers
{
    internal class TeamController
    {
        public void InsertTeam()
        {
            FIA2022Context context = new FIA2022Context();
            Equipe f1 = new Equipe();

            Console.Write("\n Informe o Nome da Equipe que deseja Cadastrar: ");
            f1.nome = Console.ReadLine();
            if (context.Equipe.FirstOrDefault(f => f.nome == f1.nome) == null)
            {

                using (context)
                {
                    context.Equipe.Add(f1);
                    context.SaveChanges();
                }
                Console.Write("\nEquipe Cadastrada com Sucesso!");
                UtilityController.Pause();
            }
            else
            {
                Console.WriteLine("Esta Equipe já está cadastrada!");
                UtilityController.Pause();
                return;
            }
        }
        public void UpdateTeamName(Equipe activeTeam)
        {
            using (var context = new FIA2022Context())
            {
                Console.Write("\n Informe o novo Nome a ser Gravado: ");
                activeTeam.nome = Console.ReadLine();
                context.Entry(activeTeam).State = EntityState.Modified;
                context.SaveChanges();
                Console.WriteLine("\n Nome Aleterado!");
                UtilityController.Pause();
            }
        }
        public void DeleteTeam(Equipe activeTeam)
        {
            TeamView teamView = new TeamView();
            bool flag = false;
            string confirm;

            using (var context = new FIA2022Context())
            {
                do
                {
                    Console.WriteLine("\n Você tem certeza de que deseja Excluir a Equipe " + activeTeam.ToString());
                    Console.WriteLine("\n Pressione [-- S --]-> Sim");
                    Console.WriteLine(" Pressione [-- N --]-> Não");
                    confirm = Console.ReadLine().ToUpper();

                    switch (confirm)
                    {
                        case "S":
                            context.Entry(activeTeam).State = EntityState.Deleted;
                            context.Equipe.Remove(activeTeam);
                            context.SaveChanges();
                            Console.Clear();
                            Console.WriteLine("\n Equipe Excluída!");
                            UtilityController.Pause();
                            flag = true;
                            teamView.Team();
                            break;

                        case "N":
                            flag = true;
                            break;

                        default:
                            Console.WriteLine("\n Opção Inválida!");
                            break;
                    }
                } while (flag == false);
            }
        }
        public void SelectAll()
        {
            using (var context = new FIA2022Context())
            {
                Console.Clear();
                if (context.Equipe.ToList().Count == 0) Console.WriteLine("\n\nNão há Equipes Cadastradas!\n");

                else context.Equipe.ToList().ForEach(x => Console.WriteLine(x));
                UtilityController.Pause();
            }
        }
        public string SelectOne()
        {
            using (var context = new FIA2022Context())
            {
                Console.Clear();
                Console.WriteLine("\n Qual o Nome da Equipe que deseja Editar?");
                string searchName = Console.ReadLine();
                if (new FIA2022Context().Equipe.FirstOrDefault(search => search.nome == searchName) == null)//procura pelo nome
                {
                    Console.Write("\n Não foi encontrado Nenhuma Equipe com este Nome...");
                    UtilityController.Pause();
                    return null;
                }
                return searchName;
            }
        }
        public Equipe GetTeam(string teamName)
        {
            using (var context = new FIA2022Context())
            {
                Equipe activeTeam = context.Equipe.First(search => search.nome == teamName);
                return activeTeam;
            }
        } 
    }
}
