using locadora.Modelos;

namespace locadora.Menus;

internal class ListarVeiculosDisponiveis
{
    public static void ListarVeiculos(GerenciarLocadora locadora)
    {
       var disponiveis= locadora.ListarVeiculosDisponiveis();
        foreach (var item in disponiveis)
        {
            Console.WriteLine(item.Value.ExibirDetalhes());
        }
    }
}
