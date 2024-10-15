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
        Console.WriteLine("Escolha qual veículo deseja adicionar \n 1: Carro. \n: 2: Moto. \n 3: Caminhão.");
        int opcao = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a marca do veículo.");
        string marca = Console.ReadLine()!;
        Console.WriteLine("Digite o modelo do veículo.");
        string modelo = Console.ReadLine()!;
        Console.WriteLine("Digite o ano de fabricação do veículo.");
        int anoFabricacao = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o valor de alocação do veículo.");
        double valorLocacao = double.Parse(Console.ReadLine()!);
        Console.WriteLine("O veículo tem transmissão automática? digite 1 para sim ou 0 para não.");
        bool transmicao = Console.ReadLine() == "1";
        Console.WriteLine("O veículo é elétrico? digite 1 para sim ou 0 para não.");
        bool eletrico = Console.ReadLine() == "1";
        Console.WriteLine("Digite a placa do veículo.");
        string placa = Console.ReadLine()!;
        Console.WriteLine("O veículo está disponível para locação? ");
        bool disponivelLocacao = Console.ReadLine() == "1";
        Veiculos novoVeiculo = null;
        switch (opcao)
        {
            case 1:
                {
                    Console.WriteLine("Digite o número de portas.");
                    int portas = int.Parse(Console.ReadLine()!);
                    novoVeiculo = new Carro(marca, modelo, anoFabricacao, valorLocacao, transmicao, eletrico, portas, disponivelLocacao, placa);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Digite a quantidade de cilindrada do motor.");
                    int quantidadeCilindrada = int.Parse(Console.ReadLine()!);
                    novoVeiculo = new Moto(marca, modelo, anoFabricacao, valorLocacao, transmicao, eletrico, quantidadeCilindrada, disponivelLocacao, placa);
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Digite a quantidade em kilos que o caminhão suporta.");
                    int kg = int.Parse(Console.ReadLine()!);
                    novoVeiculo = new Caminhao(marca, modelo, anoFabricacao, valorLocacao, transmicao, eletrico, kg, placa, disponivelLocacao);
                    break;
                }
        }
        return novoVeiculo;
    }
}
