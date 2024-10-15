using locadora.Modelos;

namespace locadora.Menus;

internal class ListarVeiculosAlugados
{
    public static void ListarVeiculos(GerenciarLocadora locadora)
    {
        var alugados = locadora.ListarVeiculosAlugados();
        foreach (var item in alugados)
        {
            Console.WriteLine(item.Value.ExibirDetalhes());
        }
    }
}
