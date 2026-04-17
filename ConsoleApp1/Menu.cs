using System;

namespace AppPOOInterface
{
    public static class Menu
    {
        public static string ExibirMenu()
        {
            Console.WriteLine("\n Sistema de Processamento de Pagamentos ");
            Console.WriteLine("Escolha a forma de pagamento ");
            Console.WriteLine("1: Cartão");
            Console.WriteLine("2: Boleto");
            Console.WriteLine("3: Sair");
            Console.Write("Escolha uma opção: ");

            return Console.ReadLine();
        }
    }
}