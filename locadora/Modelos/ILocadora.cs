namespace locadora.Modelos;

internal interface ILocadora
{
    string NomeLocadora { get; }
  void AdicionarVeiculosDisponiveis( Veiculos veiculo);
   void ListarVeiculosDisponiveis();
   void RemoverVeiculoDisponivel(string placa);
  void AdicionarVeiculosAlugados(Veiculos veiculo);
 void  ListarVeiculosAlugados();
  void RemoverVeiculosAlugados(string placa);
}
