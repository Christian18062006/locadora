namespace locadora.Modelos;

internal class Caminhao:Veiculos
{
    public int CargaSuportada { get;}
    public Caminhao(string marca, string modelo, int anoFabricacao, double valor, bool transmicao, bool eletrico, int cargaSuportada, string placa, bool disponivel):base(marca,modelo,anoFabricacao,valor,transmicao,eletrico,placa, disponivel)
    {
        CargaSuportada = cargaSuportada;
    }
    public override string ExibirDetalhes()
    {
        string detalhes=base.ExibirDetalhes();
        return $"{detalhes} carga suportada: {CargaSuportada} kg";
    }
}
