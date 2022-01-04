using System;
using System.Collections.Generic;
using System.IO;

namespace DIO.bank
{
    class Program
    {
        static List<Conta> ListContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":

                        ListarContas();
                        break;

                    case "2":

                        InserirConta();
                        break;

                    case "3":

                       Transferir();
                        break;

                    case "4":

                       Sacar();
                        break;

                    case "5":

                        Depositar();
                        break;

                    case "C":

                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                    case "X":
                    break;
                    

                }
                opcaoUsuario = ObterOpcaoUsuario();
                


            }
       
                Console.WriteLine("Obrigado por utilizar nosso serviço");
                Console.ReadLine();
        
         }    
                



        private static void InserirConta()
        {
            Console.WriteLine("Inserir Conta: ");

            Console.Write("Digite 1: Para pessoa Fisica e 2: para pessoa Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Insira o nome do Cliente:");
            string entradaNome = Console.ReadLine();

            Console.Write("Informe o Saldo Atual:");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Informe o Credito:");
            double entradaCredito = double.Parse(Console.ReadLine());


            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                                    saldo: entradaSaldo,
                                                    credito: entradaCredito,
                                                    nome: entradaNome);
            ListContas.Add(novaConta);
            
        }
        private static void ListarContas()
        {
            if(ListContas.Count == 0)
            {
                Console.WriteLine("Nenhuma Conta Cadastrada");
                return;
            }
            for(int i =0; i<= ListContas.Count; i++)
            {
                Conta conta = ListContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }
        }






        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("-- DIO's Bank -- ");
            Console.WriteLine("Informe a Opção desejada:");
            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario;
            opcaoUsuario = Console.ReadLine().ToUpper();

            Console.WriteLine();
            return opcaoUsuario;
            

        }        
        private static void Sacar()
        {
            Console.WriteLine("Informe o Numero da Conta:");
            int indiceConta = int.Parse(Console.ReadLine());


            Console.WriteLine("Informe o valor do Saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            ListContas[indiceConta].Sacar(valorSaque); 

            

        }

        private static void Depositar()
        {
            Console.WriteLine("Informe o Numero da Conta:");
            int indiceConta = int.Parse(Console.ReadLine());


            Console.WriteLine("Informe o valor do Deposito: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            ListContas[indiceConta].Sacar(valorDeposito); 

            

        }

        private static void Transferir()
        {
            Console.WriteLine("Informe o Numero da Conta de Origem:");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Numero da Conta de Destino:");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do Deposito: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            ListContas[indiceContaOrigem].Transferir(valorTransferencia, ListContas[indiceContaDestino]); 

            

        }
    }
}    


 