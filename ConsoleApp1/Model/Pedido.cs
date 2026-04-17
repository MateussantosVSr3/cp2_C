using AppPOOInterface.Interfaces;

namespace AppPOOInterface.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public IPagavel FormaDePagamento { get; set; }

        public Pedido(int id, IPagavel formaDePagamento)
        {
            Id = id;
            FormaDePagamento = formaDePagamento;
        }

        public List<string> FinalizarPedido()
        {
            List<string> mensagens = new List<string>();
            mensagens.Add($"Finalizando pedido #{Id}");
            mensagens.Add(FormaDePagamento.ProcessarPagamento());
            mensagens.Add(FormaDePagamento.EmitirRecibo());
            return mensagens;
        }
    }
}

//poi