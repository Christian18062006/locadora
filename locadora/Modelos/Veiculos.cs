namespace locadora.Modelos;

internal class Veiculos
{
    public String Marca { get; }
    public int Ano { get; }
    public String Modelo { get; }
    public double ValorLocacao { get;}
    public bool TransmicaoAutomatica { get;}
    public bool Eletrico { get; }
    public Veiculos(String marca, String modelo, int ano, double valorLocacao,bool transmicaoAutomatica, bool Eletrico)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        ValorLocacao = valorLocacao;
        Eletrico = Eletrico;
        TransmicaoAutomatica=TransmicaoAutomatica;
    }
    public virtual String ExibirDetalhes()
    {
        if (TransmicaoAutomatica == false && Eletrico == false)
        {
            return ($"Marca: {Marca} modelo: {Modelo} ano de fabricação: {Ano} valor para locação: {ValorLocacao} O veículo não é automático e nem elétrico.");
        }
        else if (TransmicaoAutomatica == true && Eletrico == true)
        {
            return ($"Marca: {Marca} modelo: {Modelo} ano de fabricação: {Ano} valor para locação: {ValorLocacao} O veículo é automático e é elétrico.");
        }
    }
}
