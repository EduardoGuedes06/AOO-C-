
class program{
    static void Main(string[] args)
    {
        // Tipo de Referencia
        // -> Endereço dos dados
        var pagamentoBoleto = new PagamentoBoleto();
        pagamentoBoleto.Pagar();
        pagamentoBoleto.Vencimento = DateTime.Now;
        pagamentoBoleto.NumeroBoleto = "123";

        var pagemento = new Pagamento();
    }

}

class Pagamento
{

    public DateTime Vencimento;

    public void Pagar(){
        
    }

}

class PagamentoBoleto : Pagamento
{
    public string NumeroBoleto;

}
class PagamentoCredito : Pagamento
{
    public string Numero; 
}