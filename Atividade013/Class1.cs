using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade013
{
    internal class Contacorrente
    {
        internal double saldo;
        internal int numero;
        internal double limite;
        internal bool especial;
        internal ArrayList movimentacoes;


        internal Contacorrente (int numero, double saldo, bool especial,double limite)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.especial = especial;
            this.limite = limite;
            this.movimentacoes = new ArrayList ();
        }

        public void Depositar(double valor)
            {
                string mensagem = ($"Realizado deposito de {valor}$");
                this.movimentacoes.Add(mensagem);
                this.saldo += valor;
                Console.WriteLine($"O deposito de {valor}$  para a conta {this.numero} foi um sucesso");
            }

        public void Sacar(double valor)
        {
            double limiteSaque = this.saldo + this.limite;

            if (valor <= limiteSaque)
            {
                string mensagem = ($"Realizado Saque de {valor}$");
                this.saldo -= valor;
                this.movimentacoes.Add(mensagem);
                Console.WriteLine($"O saque de {valor}$  da conta  {this.numero} foi um sucesso");
            }
            else
            {
                Console.WriteLine("Não é possível realizar o saque. O valor informado excede o limite de saque.");
            }
        }

        public void VisualizarSaldo()
        {
            Console.WriteLine($"O saldo na conta {this.numero} é de : {this.saldo} $");
        }

        public void VisualizarEstrato()
        {
            for (int i = 0; i < this.movimentacoes.Count; i++)
            {
                Console.WriteLine(this.movimentacoes[i]);
            }
        }

        public void Transferir(double valor, Contacorrente objinicio, Contacorrente objDestino)
        {
            double limitetransferencia = this.saldo + this.limite;

            if (valor <= limitetransferencia)
            {
                string mensagem = ($"Realizado transferencia  da conta {objinicio.numero} no valor de {valor}$ para conta {objDestino.numero}");
                this.movimentacoes.Add(mensagem);
                objinicio.saldo -= valor;
                objDestino.saldo += valor;
                Console.WriteLine(mensagem);
            }
            else
            {
                Console.WriteLine("Não é possível realizar a transferencia. O valor informado excede o limite de transferencia.");
            }
            
            
            
        }


    }
}
