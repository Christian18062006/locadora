namespace locadora.Modelos;

internal class Caminhao:Veiculos
{
    public int CargaSuportada { get;}
    public Caminhao(String marca, string modelo, int anoFabricacao, double valor, bool transmicao, bool eletrico, int cargaSuportada):base(marca,modelo,anoFabricacao,valor,transmicao,eletrico)
    {
        CargaSuportada = cargaSuportada;
    }
    public override string ExibirDetalhes()
    {
        string detalhes=base.ExibirDetalhes();
        return $"{detalhes} carga suportada: {CargaSuportada} kg";
    }
}
