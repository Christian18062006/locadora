namespace locadora.Modelos
{
    internal class Carro:Veiculos
    {
        public int QuantidadePortas { get; }
        public Carro(String marca, String modelo, int anoFabricacao, double valorLocacao, int quantidadePortas):base(marca,modelo,anoFabricacao,valorLocacao)
        {
QuantidadePortas = quantidadePortas;
        }
        public override string ExibirDetalhes()
        {
            String detalhes = base.ExibirDetalhes();
            return $"{detalhes} Quantidade de portas: {QuantidadePortas}";
        }
    }
}
