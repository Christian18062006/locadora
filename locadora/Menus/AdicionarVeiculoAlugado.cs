using locadora.Modelos;

namespace locadora.Menus;

internal class AdicionarVeiculoAlugado
{

    public static void Adicionar(GerenciarLocadora locadora)
    {
        Console.WriteLine("Digite a placa do veículo que deseja alugar.");
        string placa = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(placa))
        {
            Console.WriteLine("Placa inválida.");
            return;
        }
        locadora.AdicionarVeiculosAlugados(placa);
    }
}
