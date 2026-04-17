using AppPOOInterface;
using AppPOOInterface.Model;
using AppPOOInterface.Interfaces;

bool executando = true;

while (executando)
{
    
    string opcao = Menu.ExibirMenu();

    if (opcao == "3")
    {
        executando = false;
        Console.WriteLine("Encerrando o sistema...");
        continue;
    }

    if (opcao == "1" || opcao == "2")
    {
        
        Console.Write("Informe o valor do pagamento: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
        {
            Console.WriteLine("Valor inválido. Use números e vírgula/ponto adequadamente.");
            continue;
        }

        IPagavel pagamento = null;

        
        if (opcao == "1")
        {
            Console.Write("Informe o número do cartão: ");
            string numeroCartao = Console.ReadLine();
            pagamento = new PagamentoCartao(valor, numeroCartao);
        }
        else if (opcao == "2")
        {
            Console.Write("Informe o código de barras: ");
            string codigoBarras = Console.ReadLine();
            pagamento = new PagamentoBoleto(valor, codigoBarras);
        }

        
        Console.WriteLine($"\nOpção {opcao}: {pagamento.ProcessarPagamento()}");

        
        Console.WriteLine(pagamento.EmitirRecibo());
    }
    else
    {
        Console.WriteLine("Opção inválida! Tente novamente.");
    }
}