namespace locadora.Modelos;

internal class Veiculos
{
    public String Marca { get; }
    public int Ano { get; }
    public String Modelo { get; }
    public double ValorLocacao { get;}
    public Veiculos(String marca, String modelo, int ano, double valorLocacao)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        ValorLocacao = valorLocacao;
    }
    public virtual String ExibirDetalhes()
    {
        return ($"Marca: {Marca} modelo: {Modelo} ano de fabricação: {Ano} valor para locação: {ValorLocacao}");
    }
}
