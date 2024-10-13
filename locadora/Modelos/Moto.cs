namespace locadora.Modelos;

internal class Moto:Veiculos
{
    public int CilindradaCC { get; }
    public Moto(String marca, String modelo, int anoFabricacao, double valorLocacao, bool transmicaoAutomatica, bool eletrico, int cilindradaCC):base(marca, modelo, anoFabricacao, valorLocacao, transmicaoAutomatica, eletrico)
    {
        CilindradaCC = cilindradaCC;
    }
    public override string ExibirDetalhes()
    {
        String detalhes = base.ExibirDetalhes();
        return $"{detalhes} Cilindrada: {CilindradaCC} cm³";
    }
}
