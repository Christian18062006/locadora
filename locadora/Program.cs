using locadora.Menus;
using locadora.Modelos;
namespace locadora;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Bem-vindo a locadora alugue rápido!");
        Console.WriteLine("Aluguel de veículos com estilo!");
        GerenciarLocadora locadora = new GerenciarLocadora("Alugue rápido.");
        while (true)
        {
            Console.WriteLine("Escolha a sua opção!");
            Console.WriteLine("\n 1: Adicionar veículos  disponíveis. \n 2: Adicionar veículos alugados. \n 3: listar veículos disponíveis. \n 4: listar veículos alugados. \n 5: Devover veículo. \n 6: Retirar veículo dos veículos disponíveis para alocação. Digite -1 para sair.");
            int opcao = int.Parse(Console.ReadLine()!);
switch (opcao)
            {
                case 1:
                    {
                        AdicionarVeiculo.Adicionar(locadora);
                        break;
                    }
                    case 2:
                    {
                        AdicionarVeiculoAlugado.Adicionar(locadora);
                        break;
                    }
                case 3:
                    {
                        ListarVeiculosDisponiveis.ListarVeiculos(locadora);
                        break;
                    }
                    case 4:
                    {
                        ListarVeiculosAlugados.ListarVeiculos(locadora);
                        break;
                    }
                    case 5:
                    {
                        DevolverVeiculo.Devolver(locadora);
                        break;
                    }
                    case 6:
                    {
                        RetirarVeiculoDisponivel.RetirarVeiculo(locadora);
                        break;
                    }
                case -1:
                    {
                        FecharSystem.Fechar(locadora);
                        return;
                                            }
                default:
                    {
                        Console.WriteLine("Opção incorreta.");
                        break;
                    }
            }
        }
    }
}
