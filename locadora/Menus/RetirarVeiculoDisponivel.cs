using locadora.Modelos;

namespace locadora.Menus;

internal class RetirarVeiculoDisponivel
{
    public static void RetirarVeiculo(GerenciarLocadora locadora)
    {
        string placa = ObterDados();
        locadora.RemoverVeiculoDisponivel(placa);
    }
    private static string ObterDados()
    {
        Console.WriteLine("Digite a placa do veículo.");
        string placa = Console.ReadLine()!;
        return placa;
    }
}
