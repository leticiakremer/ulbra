﻿
using TrabalhoPooBanco.Domain.Entities;



namespace TrabalhoPooBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar um cliente
            int id = 1;
            string nome = "João";
            string cpf = "123456789";
            ESexo sexo = ESexo.Masculino;
            var cliente = new Cliente(id, nome, cpf, sexo);

            // Criar um depósito e associá-lo ao cliente
            decimal valor = 100.00m;
            var deposito = new Deposito(valor);
            deposito.DefinirCliente(cliente);

            // Realizar operações com o depósito
            var resultado = deposito.Executar();

            // Exibir o resultado
            Console.WriteLine(resultado.Mensagem);

            // Mostrar dados do cliente
            cliente.MostrarDados();

            Console.ReadLine();
        }
    }
}


        /* do
         {
             WriteLine("--- Escolha a operação que deseja realizar");
             WriteLine("------- 1 - Criar uma conta");
             WriteLine("------- 2 - Listar clientes");
             WriteLine("------- 3 - Realizar uma transferência");
             WriteLine("------- 4 - Realizar um saque");
             WriteLine("------- 5 - Realizar um depósito");
             WriteLine("------- 6 - Sair");

             var input = ReadLine();
             if (!int.TryParse(input, out var escolha))
             {
                 WriteLine("Você não informou uma opção correta!");
                 continue;
             }

             if (escolha == 1)
             {
                 //Criar conta
                 WriteLine("Certo, vamos criar a sua conta!!");
                 WriteLine("Informe o seu nome:");
                 var nome = ReadLine();

                 WriteLine("Informe o seus cpf:");
                 var cpf = ReadLine();

                 WriteLine("Informe o seu sexo:");
                 WriteLine("-- 1 para masculino");
                 WriteLine("-- 2 para feminino");
                 var sexoInput = ReadLine();

                 var conta = new ContaCorrente(Random.Shared.NextInt64(2000).ToString(), 0);
                 var cliente = new Cliente(nome, cpf, Enum.Parse<ESexo>(sexoInput), conta);

                 var repository = new ClienteRepository();
                 repository.Save(cliente);

                 cliente.MostrarDados();
             }
             else if (escolha == 2)
             {
                 var repository = new ClienteRepository();
                 var clientes = repository.Listar();
                 foreach (var cliente in clientes)
                 {
                     cliente.MostrarDados();
                     WriteLine();
                 }
             }
             else if (escolha == 3)
             {
                 //Realizar transferencia
             }
             else if (escolha == 4)
             {
                 //Realizar saque
             }
             else if (escolha == 5)
             {

                 WriteLine("Informe o número da conta que deseja fazer depósito:");
                 var numeroConta = ReadLine();

                 var repository = new ClienteRepository();
                 var cliente = repository.ObterClientePeloNumeroConta(numeroConta);
                 if (cliente == null)
                 {
                     WriteLine("Conta não existente!");
                     continue;
                 }

                 WriteLine("Informe o valor que deseja depositar na conta:");
                 var valorInput = ReadLine();
                 //Validar se realmente é um decimal
                 var valor = decimal.Parse(valorInput);
                 var deposito = new Deposito(cliente, valor);
                 var resultado = deposito.Executar();

                 var transacaoRepository = new TransacaoRepository();
                 transacaoRepository.Save(deposito);

                 WriteLine(resultado.Mensagem);
             }
             else
             {
                 WriteLine("Você não informou uma opção correta!");
                 continue;
             }

         } while (true);*/
    
