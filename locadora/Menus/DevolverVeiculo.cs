using locadora.Modelos;

namespace locadora.Menus;

internal class DevolverVeiculo
{
    public static void Devolver( GerenciarLocadora locadora)
    {
        string placa = ObterDados();
        locadora.RemoverVeiculosAlugados(placa);
    }
    private static string ObterDados()
    {
        Console.WriteLine("Digite a placa do veículo.");
        string placa=Console.ReadLine()!;
        return placa;
    }
}
