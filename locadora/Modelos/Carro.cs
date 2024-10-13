namespace locadora.Modelos
{
    internal class Carro:Veiculos
    {
        public int QuantidadePortas { get; }
        public Carro(string marca, string modelo, int anoFabricacao, double valorLocacao, bool transmicaoAutomatica, bool eletrico, int quantidadePortas):base(marca,modelo,anoFabricacao,valorLocacao,transmicaoAutomatica,eletrico)
        {
QuantidadePortas = quantidadePortas;
        }
        public override string ExibirDetalhes()
        {
            string detalhes = base.ExibirDetalhes();
            return $"{detalhes} Quantidade de portas: {QuantidadePortas}";
        }
    }
}
