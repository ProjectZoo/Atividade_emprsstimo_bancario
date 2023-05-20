namespace Atividade_emprsstimo_bancario;

class Program
{
    static void Main(string[] args)
    {
       Conta conta = new Conta();

        
      
        
        conta.limite = 1000;
        
        conta.saldo = 1000;
        conta.valor = 1000;
        conta.parcelas = 12;
        conta.taxa =0.06;
        
        
        

        Console.WriteLine( "Olá seu saldo é de: " + conta.saldo);
        Console.WriteLine("Seu Limite de saque é de: " + conta.saldo);
        conta.Deposito();
        
        
        
        conta.sacar(50);
        conta.Calculoemprestimo();
    
       

    }
}
