using locadora.Modelos;

namespace locadora.Menus;

internal class ListarVeiculosAlugados
{
    public static void ListarVeiculos(GerenciarLocadora locadora)
    {
        var alugados = locadora.ListarVeiculosAlugados();
        if (alugados.Count==0)
        {
            Console.WriteLine("Não a nem um veículo alugado no momento.");
        }
        foreach (var item in alugados)
        {
            Console.WriteLine(item.Value.ExibirDetalhes());
        }
    }
}
