using System;
using System.Collections.Generic;
using Projeto.Classes;

namespace Projeto
{
    class Program
    {
        static void Main()
        {
            try
            {
                #region  |Cliente 1 - Conta Poupança|
                Console.WriteLine("Digite o nome do cliente: ");
                string nomeCliente1 = Console.ReadLine();

                Console.WriteLine("Digite o endereço do cliente: ");
                string enderecoCliente1 = Console.ReadLine();

                Console.WriteLine("Digite o telefone do cliente: ");
                string telefone1 = Console.ReadLine();
                long telefoneCliente1 = long.Parse(telefone1);

                Console.WriteLine("Digite o CPF do cliente: ");
                string cpfCliente1 = Console.ReadLine();

                Console.WriteLine("Digite a data de nascimento do cliente: ");
                string dataNascimento1 = Console.ReadLine();
                DateTime dataNascimentoCliente1 = DateTime.Parse(dataNascimento1);

                var cliente1 = Clientes.CreateCliente(nomeCliente1, enderecoCliente1, telefoneCliente1, cpfCliente1, dataNascimentoCliente1);
                Console.WriteLine(cliente1.ToString());

                Console.WriteLine($"Entre com o valor do saldo inicial para o {nomeCliente1}: ");
                int saldoCliente1 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Entre com um número da conta para o {nomeCliente1}: ");
                int numeroConta1 = int.Parse(Console.ReadLine());

                Conta contaPoupancaCliente1 = new Poupanca(cliente1, numeroConta1, saldoCliente1);
                #endregion

                #region  |Cliente 2 - Conta Corrente|
                Console.WriteLine("Digite o nome do cliente: ");
                string nomeCliente2 = Console.ReadLine();

                Console.WriteLine("Digite o endereço do cliente: ");
                string enderecoCliente2 = Console.ReadLine();

                Console.WriteLine("Digite o telefone do cliente: ");
                string telefone2 = Console.ReadLine();
                long telefoneCliente2 = long.Parse(telefone1);

                Console.WriteLine("Digite o CPF do cliente: ");
                string cpfCliente2 = Console.ReadLine();

                Console.WriteLine("Digite a data de nascimento do cliente: ");
                string dataNascimento2 = Console.ReadLine();
                DateTime dataNascimentoCliente2 = DateTime.Parse(dataNascimento1);

                var cliente2 = Clientes.CreateCliente(nomeCliente2, enderecoCliente2, telefoneCliente2, cpfCliente2, dataNascimentoCliente2);
                Console.WriteLine(cliente1.ToString());

                Console.WriteLine($"Entre com o valor do saldo inicial para o {nomeCliente2}: ");
                int saldoCliente2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Entre com um número da conta para o {nomeCliente2}: ");
                int numeroConta2 = int.Parse(Console.ReadLine());

                Conta contaCorrenteCliente2 = new ContaCorrente(cliente2, numeroConta2, saldoCliente2);

                List<Conta> contas = new List<Conta>() { contaPoupancaCliente1, contaCorrenteCliente2 };
                #endregion

                #region  |Ações da Conta 1 - Poupança - Depósitos e Saques|
                Console.WriteLine($"O saldo de {nomeCliente1} é: R$ {contaPoupancaCliente1.Saldo}");
                Console.WriteLine($"Qual o valor do depósito que deseja realizar na conta {nomeCliente1}?");
                int valorDepo1 = int.Parse(Console.ReadLine());
                contaPoupancaCliente1.Depositar(valorDepo1);
                Console.WriteLine($"O saldo atual de {nomeCliente1} é: R$ {contaPoupancaCliente1.Saldo}");

                Console.WriteLine($"Qual valor deseja sacar da conta de {nomeCliente1}?");
                int valorSaque1 = int.Parse(Console.ReadLine());
                contaPoupancaCliente1.Sacar(valorSaque1);
                Console.WriteLine($"O saldo atual de {nomeCliente1} é: R$ {contaPoupancaCliente1.Saldo}");
                #endregion

                #region  |Ações da Conta 2 - Conta Corrente - Depósitos e Saques|
                Console.WriteLine($"O saldo de {nomeCliente2} é: R$ {contaCorrenteCliente2.Saldo}");
                Console.WriteLine($"Qual o valor do depósito que deseja realizar na conta {nomeCliente2}?");
                int valorDepo2 = int.Parse(Console.ReadLine());
                contaCorrenteCliente2.Depositar(valorDepo2);
                Console.WriteLine($"O saldo atual de {nomeCliente2} é: R$ {contaCorrenteCliente2.Saldo}");

                Console.WriteLine($"Qual valor deseja sacar na conta de {nomeCliente2} ?");
                int valorSaque2 = int.Parse(Console.ReadLine());
                contaCorrenteCliente2.Sacar(valorSaque2);
                Console.WriteLine($"O saldo atual de {nomeCliente2} é: R$ {contaCorrenteCliente2.Saldo}");
                #endregion

                #region  |Transferência|
                Console.WriteLine($"Qual o valor que deseja transferir de {numeroConta1} para {numeroConta2}?");
                int valorTransferencia = int.Parse(Console.ReadLine());

                contaPoupancaCliente1.Transferir(valorTransferencia, contaCorrenteCliente2);
                #endregion
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
} 