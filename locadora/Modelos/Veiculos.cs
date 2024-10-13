namespace locadora.Modelos;

internal class Veiculos
{
    public string Marca { get; }
    public int Ano { get; }
    public string Modelo { get; }
    public double ValorLocacao { get; }
    public bool TransmicaoAutomatica { get; }
    public bool Eletrico { get; }
    public string Placa { get; }
    public bool DisponivelLocacao { get; }
    public Veiculos(string marca, string modelo, int ano, double valorLocacao, bool transmicaoAutomatica, bool eletrico, string placa, bool disponivelLocacao)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        ValorLocacao = valorLocacao;
        Eletrico = Eletrico;
        TransmicaoAutomatica = TransmicaoAutomatica;
        Placa = placa;
        DisponivelLocacao = disponivelLocacao;
    }
    public virtual string ExibirDetalhes()
    {
        if (TransmicaoAutomatica == false && Eletrico == false && DisponivelLocacao == false)
        {
            return ($"Marca: {Marca} modelo: {Modelo} ano de fabricação: {Ano} valor para locação: {ValorLocacao} O veículo não é automático e nem elétrico. o veículo não está disponível para ser alugado!");
        }
        else if (TransmicaoAutomatica == true && Eletrico == true && DisponivelLocacao == true)
        {
            return ($"Marca: {Marca} modelo: {Modelo} ano de fabricação: {Ano} valor para locação: {ValorLocacao} O veículo é automático e é elétrico. o veículo está disponível para ser alugado!");
        }
        else if(TransmicaoAutomatica==true &&  Eletrico == false && DisponivelLocacao==true)
        {
            return ($"Marca: {Marca} modelo: {Modelo} ano de fabricação: {Ano} valor para locação: {ValorLocacao} O veículo é automático e não é elétrico. o veículo está disponível para ser alugado!");
        }
        else if(TransmicaoAutomatica==false&&Eletrico==true&&DisponivelLocacao==true)
        {
            return ($"Marca: {Marca} modelo: {Modelo} ano de fabricação: {Ano} valor para locação: {ValorLocacao} O veículo é elétrico e não é automático. O veículo está disponível para ser alugado!");
        }
        else {
            return ($"Marca: {Marca} modelo: {Modelo} ano de fabricação: {Ano} valor para locação: {ValorLocacao} O veículo é automático e é elétrico. o veículo não está disponível para ser alugado!");

        }

    }
}