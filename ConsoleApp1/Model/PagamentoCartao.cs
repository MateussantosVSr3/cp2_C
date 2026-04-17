namespace AppPOOInterface.Model
{
    public class PagamentoCartao : PagamentoBase
    {
        public string NumeroCartao { get; set; }

        public PagamentoCartao(decimal valor, string numeroCartao) : base(valor)
        {
            NumeroCartao = numeroCartao;
        }

        public override string ProcessarPagamento()
        {
            
            return $"Processando pagamento de R$ {Valor:N2} via Cartão (Número: {NumeroCartao}) na data {Data:dd/MM/yyyy}.";
        }
    }
}