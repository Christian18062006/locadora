namespace locadora.Modelos;

internal class Moto:Veiculos
{
    public int CilindradaCC { get; }
    public Moto(string marca, string modelo, int anoFabricacao, double valorLocacao, bool transmicaoAutomatica, bool eletrico, int cilindradaCC, bool disponivelLocacao, string placa):base(marca, modelo, anoFabricacao, valorLocacao, transmicaoAutomatica, eletrico,placa, disponivelLocacao)
    {
        CilindradaCC = cilindradaCC;
    }
    public override string ExibirDetalhes()
    {
        string detalhes = base.ExibirDetalhes();
        return $"{detalhes} Cilindrada: {CilindradaCC} cm³";
    }
}
