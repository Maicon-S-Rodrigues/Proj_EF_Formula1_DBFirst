using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_EF_Formula1_DBFirst.Controllers
{
    internal class CarController
    {
        public void InsertCar()
        {
            using (var context = new FIA2022Context())
            {
                try
                {
                    Carro car = new Carro();
                    string equipe = SelectEquipe();
                    if (equipe == null) return;

                    car.id_equipe = int.Parse(equipe);

                    Console.Write("\n Informe o Modelo do Carro que deseja Cadastrar: ");
                    car.modelo = Console.ReadLine();

                    Console.Write("\n Informe o Ano do Modelo do Carro que deseja Cadastrar: ");
                    car.ano = int.Parse(Console.ReadLine());

                    Console.Write("\n Informe a Unidade do Carro que deseja Cadastrar: ");
                    car.unidade = int.Parse(Console.ReadLine());

                    if (context.Carro.FirstOrDefault(find => find.modelo == car.modelo && find.ano == car.ano && find.unidade == car.unidade && find.Equipe.id == car.id_equipe) == null)
                    {
                        context.Carro.Add(car);
                        context.SaveChanges();
                        Console.Write("\n Novo Carro Cadastrado com Sucesso!");
                        UtilityController.Pause();
                    }
                    else
                    {
                        Console.WriteLine("\n Este Carro já está cadastrado!");
                        UtilityController.Pause();
                        return;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\n Erro: <<<" + e + ">>> \n\n");
                    UtilityController.Pause();
                    throw;
                }
            }
        }
        public string SelectEquipe() //procura pelo nome e devolve o ID da equipe encontrada
        {
            Equipe equipeId = new Equipe();
            using (var context = new FIA2022Context())
            {
                Console.Clear();
                if (context.Equipe.ToList().Count == 0)
                {
                    Console.WriteLine("\n\nNão há Equipes Cadastradas!\n");
                    return null;
                }

                else
                {
                    context.Equipe.ToList().ForEach(x => Console.WriteLine(x));
                    Console.Write("\n Digite o Nome da Equipe que deseja Cadastrar este Carro: ");
                    string searchName = Console.ReadLine();
                    if (context.Equipe.FirstOrDefault(search => search.nome == searchName) == null)
                    {
                        Console.Write("\n Não foi encontrado Nenhuma Equipe com este Nome...");
                        UtilityController.Pause();
                        return null;
                    }
                    else
                    {
                        equipeId = context.Equipe.First(search => search.nome == searchName);
                        return equipeId.id.ToString();
                    }
                }
            }
        }
        public void SelectAll()
        {
            using (var context = new FIA2022Context())
            {
                Console.Clear();
                if (context.Carro.ToList().Count == 0)
                {
                    Console.WriteLine("\n\nNão há Carros Cadastrados!\n");
                    UtilityController.Pause();
                    return;
                }
                else
                {
                    context.Carro.ToList().ForEach(x => Console.WriteLine(x));
                    UtilityController.Pause();
                }
            }
        }
    }
}
