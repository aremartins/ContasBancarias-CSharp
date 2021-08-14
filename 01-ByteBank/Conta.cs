using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_ByteBank
{
    public abstract class Conta
    {
        public static int TotalContasCriadas { get; private set; }


        public Conta(int agencia, int numero)
        {
            if ( agencia <= 0 )
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0", nameof(agencia));
            }

            if ( numero <= 0 )
            {
                throw new ArgumentException("O argumento número deve ser maior que 0", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalContasCriadas++;
        }

        public Cliente Titular { get; set; }
        
        public int Agencia { get; }            

        public int Numero { get; }

        
        private double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if(value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
            
        }

        public void Depositar(double valor)
        {
            if(valor > 0)
            {
                _saldo += valor;
            }
        }

        public bool transferir(Conta contaDestino, double valor)
        {
            if(valor > _saldo)
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
