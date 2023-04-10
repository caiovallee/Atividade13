using System.ComponentModel;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace Atividade013
{
    internal class Program
    {
//        Uma conta corrente possui um número, um saldo, um status que informa se ela é especial ou não, um limite e um conjunto
//        de movimentações.Uma movimentação possui um valor e uma informação se ela é uma movimentação de crédito ou débito. 

//Cada conta terá operações de saques, depósitos, visualização de saldo, visualização de extrato e transferência entre contas.
//        Uma conta corrente só pode fazer saques desde que o valor não exceda o limite de saque que é o limite + saldo.

//Não precisa implementar a interação com usuário.

        static void Main(string[] args)
        {

            Contacorrente conta1 = new Contacorrente(1, 600, true, 200);
            Contacorrente conta2 = new Contacorrente(2, 600, true, 200);

            conta1.Sacar(100);
            Console.WriteLine();
            conta1.Depositar(200);
            Console.WriteLine();
            conta1.Transferir(200, conta2, conta1);
            Console.WriteLine();
            conta1.VisualizarEstrato();
            Console.WriteLine();
            conta1.VisualizarSaldo();
            
            Console.ReadLine();



            
            




        }
    }
}