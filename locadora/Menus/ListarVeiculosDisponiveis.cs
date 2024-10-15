using locadora.Modelos;

namespace locadora.Menus;

internal class ListarVeiculosDisponiveis
{
    public static void ListarVeiculos(GerenciarLocadora locadora)
    {
       var disponiveis= locadora.ListarVeiculosDisponiveis();
        if (disponiveis.Count==0)
        {
            Console.WriteLine("Nem um veículo está disponível.");
        }
        foreach (var item in disponiveis)
        {
            Console.WriteLine(item.Value.ExibirDetalhes());
        }
    }
}
