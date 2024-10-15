namespace locadora.Modelos;

internal class GerenciarLocadora : ILocadora
{
    private Dictionary<string, Veiculos> veiculosDisponiveis = new Dictionary<string, Veiculos>();
    private Dictionary<string, Veiculos> veiculosAlugados = new Dictionary<string, Veiculos>();

    public string NomeLocadora { get; }

    public GerenciarLocadora(string nomeLocadora)
    {
        NomeLocadora = nomeLocadora;
    }

    public void AdicionarVeiculosAlugados(string placa)
    {
        if (veiculosDisponiveis.ContainsKey(placa) && !veiculosAlugados.ContainsKey(placa))
        {
            var veiculo = veiculosDisponiveis[placa];
            veiculo.AtualizarStatus(false);
            veiculosAlugados.Add(placa, veiculo);
            veiculosDisponiveis.Remove(placa);

            Console.WriteLine("Veículo alugado com sucesso!");
        }
        else
        {
            Console.WriteLine("O veículo não pode ser alugado, verifique se ele está disponível.");
        }
    }

    public void AdicionarVeiculosDisponiveis(Veiculos veiculo)
    {
        if (veiculosAlugados.ContainsKey(veiculo.Placa))
        {
            Console.WriteLine("O veículo está alugado no momento.");
        }
        else if (veiculosDisponiveis.ContainsKey(veiculo.Placa))
        {
            Console.WriteLine("O veículo já está disponível.");
        }
        else
        {
            veiculo.AtualizarStatus(true);
            veiculosDisponiveis.Add(veiculo.Placa, veiculo);
            Console.WriteLine("Veículo adicionado com sucesso à lista de disponíveis.");
        }
    }

    public Dictionary<string, Veiculos> ListarVeiculosAlugados()
    {
        return veiculosAlugados;
    }

    public Dictionary<string, Veiculos> ListarVeiculosDisponiveis()
    {
        return veiculosDisponiveis;
    }

    public void RemoverVeiculoDisponivel(string placa)
    {
        if (veiculosDisponiveis.ContainsKey(placa))
        {
            veiculosDisponiveis.Remove(placa);
            Console.WriteLine("Veículo removido da lista de disponíveis.");
        }
        else if (veiculosAlugados.ContainsKey(placa))
        {
            Console.WriteLine("O veículo está alugado, não pode ser removido dos disponíveis.");
        }
        else
        {
            Console.WriteLine("Veículo não encontrado na lista de disponíveis.");
        }
    }

    public void RemoverVeiculosAlugados(string placa)
    {
        if (veiculosAlugados.ContainsKey(placa))
        {
            var veiculo = veiculosAlugados[placa];
            veiculo.AtualizarStatus(true);
            veiculosAlugados.Remove(placa);
            veiculosDisponiveis.Add(placa, veiculo);
            Console.WriteLine("Veículo devolvido e agora está disponível para aluguel.");
        }
        else
        {
            Console.WriteLine("O veículo não está na lista de alugados.");
        }
    }
}
