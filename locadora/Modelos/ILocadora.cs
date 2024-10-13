namespace locadora.Modelos;

internal interface ILocadora
{
    string NomeLocadora { get; }
    void AdicionarVeiculo(Veiculos veiculo);
    Dictionary<string, Veiculos> ListarVeiculos();
}
