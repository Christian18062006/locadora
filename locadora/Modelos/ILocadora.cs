namespace locadora.Modelos;

internal interface ILocadora
{
    string NomeLocadora { get; }
    void AdicionarVeiculosDisponiveis( Veiculos veiculo);
    Dictionary<string, Veiculos> ListarVeiculosDisponiveis();
    void RemoverVeiculoDisponivel(string placa);
    void AdicionarVeiculosAlugados(Veiculos veiculo);
    Dictionary<string, Veiculos> ListarVeiculosAlugados();
    void RemoverVeiculosAlugados(string placa);
}
