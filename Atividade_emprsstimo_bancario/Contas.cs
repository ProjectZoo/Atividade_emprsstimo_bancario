namespace Atividade_emprsstimo_bancario;

class Conta
{
    
     public double saldo {get; set;}
    public double limite {get; set;}
    public double valor;
    public int parcelas;
    public double taxa;

    
    
    
    public void sacar (double valor){
        this.saldo -= valor;
    }

    
    public double ConsultaSaldo(){
        return this.saldo + this.limite;

    }
    public void Deposito()
    {
       double valordeposito = saldo * valor;
        Console.WriteLine("Valor deposito:" + valordeposito);
    }
   
 public void Calculoemprestimo()
 {
   double valorparcelasemjuros = valor / parcelas;
        double valorJuros = valor * taxa;
        double valorparcelacomjuros = valorparcelasemjuros + valorJuros;
        double valorPagar = valorparcelacomjuros * 12;
        Console.WriteLine("Valor: R$ " + valor + "; Taxa : " + taxa);
        Console.WriteLine("R$ " + valor + " x " + taxa + "taxa = R$" + valorJuros + valorparcelacomjuros);
        Console.WriteLine("Valor dos juros ao mês: R$ " + valorJuros + "; Valor da prestação ao mês: R$ " + valorparcelasemjuros);
        Console.WriteLine("Valor dos juros com prestação: R$ " + valorparcelacomjuros);
        Console.WriteLine("Valor a pagar R$:" + valorPagar);
 }
  }


