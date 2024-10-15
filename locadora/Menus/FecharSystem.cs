using locadora.Modelos;

namespace locadora.Menus
{
    internal class FecharSystem
    {
        public static void Fechar(GerenciarLocadora locadora)
        {
            Console.WriteLine($"Obrigado por ter alugado com a locadora {locadora.NomeLocadora} volte sempre!");
        }
    }
}
