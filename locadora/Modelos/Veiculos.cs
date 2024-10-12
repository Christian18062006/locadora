namespace locadora.Modelos;

internal class Veiculos
{
    public String Marca { get; }
    public int Ano { get; }
    public String Modelo { get; }
    public Veiculos(String marca, String modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }
}
