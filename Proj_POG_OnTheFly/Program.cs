using System;

namespace Proj_POG_OnTheFly
{
    internal class Program
    {

        #region TELAS
        static void TelaInicial() // INCOMPLETO 
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindo à POG On The Fly!");
                Console.WriteLine("\nPor Favor, informe a Opção Desejada:\n");
                Console.WriteLine(" 1 - Acesso aos Cadastros de Companhias Aéreas\n");
                Console.WriteLine(" 2 - Acesso aos Cadastros de Passageiros\n");
                Console.WriteLine(" 3 - Acesso às Vendas de Passagens\n");
                Console.WriteLine(" 4 - Acesso a Lista de CPF Restritos\n");
                Console.WriteLine(" 5 - Acesso a Lista de CNPJ Restritos");
                Console.WriteLine("\n 0 - Encerrar Sessão\n");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine()); // opc = int.Parse(ValidarEntrada("menu"));

                switch (opc)
                {
                    case 0:

                        // Lembrar de colocar uma chamada para todas funções de salvar antes.
                        Console.WriteLine("Encerrando...");
                        Environment.Exit(0); //Fecha o programa 

                        break;

                    case 1:

                        // Chamar a tela de Companhias Aereas

                        break;

                    case 2:

                        // Chamar a tela de passageiros
                        TelaInicialPassageiros();
                        break;

                    case 3:

                        // Chamar a tela de entrada para as vendas

                        break;

                    case 4:

                        // Chamar a tela para ver os CPF's Restritos

                        break;

                    case 5:

                        // Chamar a tela para ver os CNPJ's Restritos

                        break;
                }

            } while (opc != 0);

        }

        #region TELAS_PASSAGEIROS
        static void TelaInicialPassageiros() //OK ~ Falta Acertar o uso das funções *  
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\nInforme a Opção Desejada:\n");
                Console.WriteLine(" 1 - Passageiro já cadastrado\n");
                Console.WriteLine(" 2 - Cadastrar um novo Passageiro\n");
                Console.WriteLine("\n 0 - SAIR\n");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine()); // opc = int.Parse(ValidarEntrada("menu"));

                switch (opc)
                {
                    case 0:

                        // volta para tela inicial
                        TelaInicial();

                        break;

                    case 1:

                        // chamar a tela para validar entrada com CPF
                        TelaLoginPassageiro();

                        break;

                    case 2:

                        // chamar a tela para cadastrar passageiro
                        TelaCadastrarPassageiro();

                        break;
                }

            } while (opc != 0);
        }

        static void TelaLoginPassageiro() // OK ~ Falta Acertar o uso das funções e liberar as partes comentadas * 
        {
            //Passageiro passageiroAtivo;
            do
            {
                Console.Clear();
                Console.WriteLine("\nInforme o 'CPF' para Entrar:\n");
                //passageiroAtivo = ValidarLoginPassageiro();
                //if (passageiroAtivo == null)
                //  {
                //      Pausa();
                //      TelaInicialPassageiro();
                //  }

                TelaOpcoesPassageiro(/*passageiroAtivo*/); // encontrou um 'CPF' valido e existente nos cadastros, então manda para a tela de opções.


            } while (true);
        }

        static void TelaOpcoesPassageiro(/*Passageiro passageiroAtivo*/) // OK ~ Falta Acertar o uso das funções e liberar as partes comentadas * 
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("\nOPÇÕES PARA O PASSAGEIRO: " /* + passageiroAtivo.Nome*/);
                Console.WriteLine("\nEscolha a Opção Desejada:\n");
                Console.WriteLine(" 1 - Editar Cadastro\n");
                Console.WriteLine(" 2 - Comprar Passagem\n");
                Console.WriteLine("\n 0 - SAIR\n");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine()); // opc = ValidarEntrada("menu");

                switch (opc)
                {
                    case 0:

                        TelaInicialPassageiros(); // escolheu sair, volta para a tela inicial de passageiros

                        break;

                    case 1:

                        TelaEditarPassageiro(/*Passageiro passageiroAtivo*/); // abre os dados do passageiro em questão para escolher quais quer editar

                        break;

                    case 2:

                        //bool restrito = false;
                        //bool maiorDe18 = false;
                        //string cpf = passageiroAtivo.Cpf;
                        //DateTime nascimento = passageiroAtivo.DataNascimento;

                        // maiorDe18 = VerificarMaiorDe18(nascimento);
                        // if (maiorDe18 == false)
                        // {
                        //      Console.Clear();
                        //      Console.WriteLine("\nImpossível acessar Area de Vendas com Passageiro menor de 18 anos!");
                        //      Pausa();
                        //      TelaOpcoesPassageiro(passageiroAtivo);
                        // }
                        // 
                        // restrito = VerificarCpfRestrito("cpf");
                        // if (restrito == false)
                        // {
                        //      Console.Clear();
                        //      Console.WriteLine("\nAcesso à area de Vendas está 'RESTRITA' para esse 'CPF'!");
                        //      Pausa();
                        //      TelaOpcoesPassageiro(passageiroAtivo);
                        // }

                        // if (restrito == true && maiorDe18 == true)
                        //{
                        //      TelaInicialVendas();
                        //}

                        break;
                }

            } while (true);
            // case 2:
            //
            // validar se o Passageiro com esse CPF é maior de 18 anos
            //
            // validar se o CPF está na lista de bloqueados
            //
            // se as duas condições acima forem verdadeiras (é maior de 18 e não está na lista de bloqueados)
            // segue para as vendas ||| se uma das duas não for verdadeira retornara para tela anterior depois de uma mensagem com o motivo.
        }

        static void TelaCadastrarPassageiro() // OK ~ Falta Acertar o uso das funções e liberar as partes comentadas * 
        {
            do
            {
                // variaveis locais
                string nome, cpf;
                DateTime dataNascimento;
                char sexo;
                // Passageiro novoPassageiro;

                Console.Clear();
                Console.WriteLine("\nCADASTRO DE PASSAGEIRO");
                Console.Write("\n\nInforme o 'Nome': ");
                nome = Console.ReadLine(); // nome = ValidarEntrada("nome");
                if (nome == null) TelaInicialPassageiros();

                Console.Write("\nInforme o 'CPF': ");
                cpf = Console.ReadLine(); // cpf = ValidarEntrada("cpf");   /// OBS: Precisa validar se o 'CPF' já existe na lista de cadastros!
                if (cpf == null) TelaInicialPassageiros();

                Console.Write("\nInforme a 'Data de Nascimento': ");
                dataNascimento = DateTime.Parse(Console.ReadLine()); // dataNascimento = DateTime.Parse(ValidarEntrada("datanascimento"));
                if (dataNascimento == null) TelaInicialPassageiros();

                Console.Write("\nInforme o 'Sexo': ");
                Console.Write("\n [ F ] - Feminino");
                Console.Write("\n [ M ] - Masculino");
                Console.Write("\n [ N ] - Não informar");
                Console.Write("\nOpção: ");
                sexo = char.Parse(Console.ReadLine()); // sexo = char.Parse(ValidarEntrada("sexo"));
                if (sexo.Equals(null)) TelaInicialPassageiros();


                // PRECISA DECIDIR COMO VAI SER ENVIADO O PARAMETRO PARA A FUNÇÃO DE GRAVAR:
                //--------------------------------------------
                // novoPassageiro = new Passageiro(cpf, nome, dataNascimento, sexo);
                //--------------------------------------------
                // GravarPassageiro(novoPassageiro);
                //--------------------------------------------
                // passageiros.ADD(novoPassageiro);
                // GravarPassageiro(passageiros);
                //--------------------------------------------
                Console.WriteLine("\nPassageiro Cadastrado com Sucesso!");
                Pausa();
                TelaInicialPassageiros();

            } while (true);
        }

        static void TelaEditarPassageiro(/*Passageiro passageiroAtivo*/) // INCOMPLETO 
        {
            int opc;
            string novoNome;
            DateTime novaDataNascimento;
            char novoSexo;
            char novaSituacao;

            do
            {
                Console.Clear();
                Console.WriteLine("\nEDTAR DADOS");
                Console.WriteLine("\nEscolha qual Dado deseja Editar: ");
                Console.Write("\n 1 - Nome");
                Console.Write("\n 2 - Data de Nascimento");
                Console.Write("\n 3 - Sexo");
                Console.Write("\n 4 - Situação (Ativo / Inativo");
                Console.Write("\n 0 - VOLTAR");
                opc = int.Parse(Console.ReadLine()); // opc = int.Parse(ValidarEntrada("menu"));

                switch (opc)
                {
                    case 0:

                        TelaOpcoesPassageiro(/*Passageiro passageiroAtivo*/);

                        break;

                    case 1:

                        Console.Clear();
                        Console.WriteLine("\nNome Atual: " /* + passageiroAtivo.Nome*/);
                        Console.Write("\n\nInforme o Novo Nome: ");
                        //novoNome = ValidarEntrada("nome");
                        //if (novoNome == null) TelaEditarPassageiro(passageiroAtivo);

                        //passageiroAtivo.Nome = novoNome;
                        Console.WriteLine("\nNome Alterado com Sucesso!");
                        Pausa();
                        TelaEditarPassageiro(/*passageiroAtivo*/);

                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine("\nData de nascimento Atual: "/* + passageiroAtivo.DataNascimento.ToShortDateString()*/);
                        Console.Write("\n\nInforme a Nova Data de Nascimento: ");
                        //novaDataNascimento = DateTime.Parse(ValidarEntrada("datanascimento"));
                        //if (novaDataNascimento == null) TelaEditarPassageiro(passageiroAtivo);

                        //passageiroAtivo.DataNascimento = novaDataNascimento;
                        Console.WriteLine("\nData de Nascimento Alterada com Sucesso!");
                        Pausa();
                        TelaEditarPassageiro(/*passageiroAtivo*/);

                        break;

                    case 3:

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\nSexo Atual: " /* + passageiroAtivo.Sexo*/);
                            Console.Write("\n\nInforme o Novo Sexo: ");
                            Console.Write("\n [ F ] - Feminino");
                            Console.Write("\n [ M ] - Masculino");
                            Console.Write("\n [ N ] - Não informar");
                            Console.Write("\nOpção: ");
                            //novoSexo = char.Parse(ValidarEntrada("sexo"));
                            //if (novoSexo.Equals(null)) TelaInicialPassageiros();

                            //passageiroAtivo.Sexo = novoSexo;
                            Console.WriteLine("\nSexo Alterado com Sucesso!");
                            Pausa();
                            TelaEditarPassageiro(/*passageiroAtivo*/);
                        } while (true);

                    case 4:

                        Console.Clear();
                        Console.WriteLine("\nPASSAGEIRO: " /*passageiroAtivo.Nome*/);
                        //if (passageiroAtual.Situacao == 'A')
                        { Console.WriteLine("\nSituação Atual: ATIVO"); }
                        //if (passageiroAtual.Situacao == 'I')
                        { Console.WriteLine("\nSituação Atual: INATIVO"); }

                        //novaSituacao = char.Parse(ValidarEntrada("situacao"));
                        //if (novaSituacao.Equals(null)) TelaInicialPassageiros();

                        //passageiroAtivo.Situacao = novaSituacao;
                        Console.WriteLine("\nSexo Alterado com Sucesso!");
                        Pausa();
                        TelaEditarPassageiro(/*passageiroAtivo*/);
                        break;
                }

            } while (true);
        }

        #endregion

        #endregion
        static void Pausa() // OK 
        {
            Console.WriteLine("\nAperte 'ENTER' para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            TelaInicial();
        }
    }
}
