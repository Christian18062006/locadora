
namespace locadora.Modelos;

internal class GerenciarLocadora : ILocadora
{
    private Dictionary<string,Veiculos> veiculosDisponiveis= new Dictionary<string,Veiculos>();
    private Dictionary<string,Veiculos> veiculosAlugados= new Dictionary<string,Veiculos>();
    public string NomeLocadora { get; }
public GerenciarLocadora(string nomeLocadora)
    {
NomeLocadora = nomeLocadora;
    }

    public void AdicionarVeiculosAlugados(Veiculos veiculo)
    {
        if (veiculosDisponiveis.ContainsKey(veiculo.Placa) && !veiculosAlugados.ContainsKey(veiculo.Placa))
        {
            veiculosAlugados.Add(veiculo.Placa, veiculo);
            veiculosDisponiveis.Remove(veiculo.Placa);
        }
        else
        {
            Console.WriteLine("O veículo não pode ser adicionado, verifique se ele está disponível.");
        }
    }

    public void AdicionarVeiculosDisponiveis(Veiculos veiculo)
    {
            if (veiculosAlugados.ContainsKey(veiculo.Placa))
                {
                Console.WriteLine("O veículo está sendo alocado no momento.");
            }
            else
            {
                veiculosDisponiveis.Add(veiculo.Placa, veiculo);
            }
        }
    public void ListarVeiculosAlugados()
    {
            foreach (var item in veiculosAlugados)
            {
                Console.WriteLine(item.Key);

            }

    }

    public void ListarVeiculosDisponiveis()
    {
            foreach (var item in veiculosDisponiveis)
            {
                Console.WriteLine(item.Key);
                
            }
        }
    public void RemoverVeiculoDisponivel(string placa)
        {
            if (veiculosAlugados.ContainsKey(placa))
            {
                Console.WriteLine ("O veículo está em alocação.");
            }
            else if(veiculosDisponiveis.ContainsKey(placa)){
                veiculosDisponiveis.Remove(placa);
            }
        }
    public void RemoverVeiculosAlugados(string placa)
    {
if(veiculosAlugados.ContainsKey(placa))
                 {
            veiculosAlugados.Remove(placa);
            }
else
        {
            Console.WriteLine("O veículo não está na lista de disponíveis por isso não pode ser removido.");
        }
    }
}
