using locadora.Modelos;

namespace locadora.Menus;

internal class AdicionarVeiculo
{
    public static void Adicionar(GerenciarLocadora locadora)
    {
        var veiculo = ObterDados();
        locadora.AdicionarVeiculosDisponiveis(veiculo);
    }

    private static Veiculos ObterDados()
    {
        Console.WriteLine("Digite a marca do veículo.");
        string marca = Console.ReadLine()!;
        Console.WriteLine("Digite o modelo do veículo.");
        string modelo= Console.ReadLine()!;
        Console.WriteLine("Digite o ano de fabricação do veículo.");
        int anoFabricacao = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o valor de alocação do veículo.");
        double valorLocacao= double.Parse(Console.ReadLine()!);
        Console.WriteLine("O veículo tem transmissão automática? digite 1 para sim ou 0 para não.");
        bool transmicao = Console.ReadLine() == "1";
        Console.WriteLine("O veículo é elétrico? digite 1 para sim ou 0 para não.");
        bool eletrico= Console.ReadLine() == "1";
        Console.WriteLine("Digite a placa do veículo.");
        string placa= Console.ReadLine()!;
        Console.WriteLine("O carro está disponível para locação? ");
        bool disponivellocacao= Console.ReadLine() == "1";
        return new Veiculos(marca,modelo,anoFabricacao,valorLocacao,transmicao,eletrico,placa,disponivellocacao);
    }
}