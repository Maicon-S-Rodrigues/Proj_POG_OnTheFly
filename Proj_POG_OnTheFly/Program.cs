using System;

namespace Proj_POG_OnTheFly
{
    internal class Program
    {

        #region TELAS
        static void TelaInicial() // INCOMPLETO 
        {
            int opc = 0;
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
                        TelaInicialCompanhiasAereas();

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
                        TelaInicialCpfRestritos();

                        break;

                    case 5:

                        // Chamar a tela para ver os CNPJ's Restritos
                        TelaInicialCnpjRestritos();

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
                Console.Clear();
                Console.WriteLine("\nInforme o 'CPF' para Entrar:\n");
                //passageiroAtivo = ValidarLoginPassageiro();
                //if (passageiroAtivo == null)
                //  {
                //      Pausa();
                //      TelaInicialPassageiro();
                //  }

                TelaOpcoesPassageiro(/*passageiroAtivo*/); // encontrou um 'CPF' valido e existente nos cadastros, então manda para a tela de opções.
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

        static void TelaCadastrarPassageiro() // OK ! Só dar um 'CTRL+K+U' em tudo pra tirar os comentarios 
        {
            do
            {
                // variaveis locais
                //string nome, cpf;
                //string dataNascimento;
                //char sexo;

                // Passageiro novoPassageiro;

                //nome = ValidarEntrada("nome");
                //if (nome == null) TelaInicialPassageiros();

                //cpf = ValidarEntrada("cpf");   /// OBS: Precisa validar se o 'CPF' já existe na lista de cadastros!
                //if (cpf == null) TelaInicialPassageiros();

                //dataNascimento = ValidarEntrada("datanascimento");
                //if (dataNascimento == null) TelaInicialPassageiros();

                //sexo = char.Parse(ValidarEntrada("sexo"));
                //if (sexo.Equals(null)) TelaInicialPassageiros();

                Console.WriteLine("\nPassageiro Cadastrado com Sucesso!");
                //Passageiro passageiro = new Passageiro(cpf, nome, DateConverter(dataNascimento), sexo, System.DateTime.Now, System.DateTime.Now, 'A');
                //listPassageiro.Add(passageiro);
                //GravarPassageiro(listPassageiro);
                Pausa();
                TelaInicialPassageiros();

            } while (true);
        }

        static void TelaEditarPassageiro(/*Passageiro passageiroAtivo*/) // OK ~ Falta Acertar o uso das funções e liberar as partes comentadas * 
        {
            int opc;
            string novoNome;
            string novaDataNascimento;
            DateTime data;
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
                Console.Write("\n 0 - Voltar");
                Console.WriteLine("\nOpção: ");
                opc = int.Parse(Console.ReadLine()); // opc = int.Parse(ValidarEntrada("menu"));

                switch (opc)
                {
                    case 0:

                        TelaOpcoesPassageiro(/*Passageiro passageiroAtivo*/);

                        break;

                    case 1:

                        Console.Clear();
                        Console.WriteLine("\nNome Atual: " /* + passageiroAtivo.Nome*/);
                        Console.Write("\n\nInforme o Novo Nome");
                        Pausa();
                        //novoNome = ValidarEntrada("nome");
                        //if (novoNome == null) TelaEditarPassageiro(passageiroAtivo);

                        //passageiroAtivo.Nome = novoNome;
                        Console.Clear();
                        Console.WriteLine("\nNome Alterado com Sucesso!");
                        Pausa();
                        TelaEditarPassageiro(/*passageiroAtivo*/);

                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine("\nData de nascimento Atual: "/* + passageiroAtivo.DataNascimento.ToShortDateString()*/);
                        Console.Write("\n\nInforme a Nova Data de Nascimento");
                        Pausa();
                        //novaDataNascimento = ValidarEntrada("datanascimento")
                        //if (novaDataNascimento == null) TelaEditarPassageiro(passageiroAtivo);
                        //data = DateConverter(novaDataNascimento);
                        //passageiroAtivo.DataNascimento = data;
                        Console.Clear();
                        Console.WriteLine("\nData de Nascimento Alterada com Sucesso!");
                        Pausa();
                        TelaEditarPassageiro(/*passageiroAtivo*/);

                        break;

                    case 3:

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\nSexo Atual: " /* + passageiroAtivo.Sexo*/);
                            Console.Write("\n\nInforme o Novo Sexo");
                            Pausa();
                            //novoSexo = char.Parse(ValidarEntrada("sexo"));
                            //if (novoSexo.Equals(null)) TelaInicialPassageiros();
                            //passageiroAtivo.Sexo = novoSexo;
                            Console.Clear();
                            Console.WriteLine("\nSexo Alterado com Sucesso!");
                            Pausa();
                            TelaEditarPassageiro(/*passageiroAtivo*/);
                        } while (true);

                    case 4:

                        Console.Clear();
                        Console.WriteLine("\nPASSAGEIRO: " /*passageiroAtivo.Nome*/);
                        //if (passageiroAtivo.Situacao == 'A')
                        { Console.WriteLine("\nSituação Atual: ATIVO"); }
                        //if (passageiroAtivo.Situacao == 'I')
                        { Console.WriteLine("\nSituação Atual: INATIVO"); }
                        Pausa();

                        //novaSituacao = char.Parse(ValidarEntrada("situacao"));
                        //if (novaSituacao.Equals(null)) TelaInicialPassageiros();

                        //passageiroAtivo.Situacao = novaSituacao;
                        Console.Clear();
                        Console.WriteLine("\nSituação de Cadastro Alterada com Sucesso!");
                        Pausa();
                        TelaEditarPassageiro(/*passageiroAtivo*/);
                        break;
                }

            } while (true);
        }

        #endregion

        #region TELAS_ARQUIVOS_BLOQUEADOS
        static void TelaInicialCpfRestritos() // falta adicionar as funções aqui (busca,adicionar, retirar, mostrar lista)
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n'CPF' RESTRITOS");
                Console.WriteLine("\nInforme a Opção Desejada:\n");
                Console.WriteLine(" 1 - Ver a Lista de 'CPF' Restritos\n");
                Console.WriteLine(" 2 - Adicionar um 'CPF' à Lista de Restritos\n");
                Console.WriteLine(" 3 - Remover um 'CPF' da Lista de Restritos\n");
                Console.WriteLine("\n 0 - Sair\n");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine()); // opc = int.Parse(ValidarEntrada("menu"));

                switch (opc)
                {
                    case 0:

                        TelaInicial();

                        break;

                    case 1:

                        // mostrar na tela toda a lista de cpf's restritos

                        break;

                    case 2:

                        // adicionar um novo cpf nessa lista de restritos

                        break;

                    case 3:

                        // procurar por um cpf especifico nessa lista e se achar deve remove-lo

                        break;
                }

            } while (true);
        }
        static void TelaInicialCnpjRestritos() // falta adicionar as funções aqui (busca,adicionar, retirar, mostrar lista)
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n'CNPJ' RESTRITOS");
                Console.WriteLine("\nInforme a Opção Desejada:\n");
                Console.WriteLine(" 1 - Ver a Lista de 'CNPJ' Restritos\n");
                Console.WriteLine(" 2 - Adicionar um 'CNPJ' à Lista de Restritos\n");
                Console.WriteLine(" 3 - Remover um 'CNPJ' da Lista de Restritos\n");
                Console.WriteLine("\n 0 - Sair\n");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine()); // opc = int.Parse(ValidarEntrada("menu"));

                switch (opc)
                {
                    case 0:

                        TelaInicial();

                        break;

                    case 1:

                        // mostrar na tela toda a lista de cnpj's restritos

                        break;

                    case 2:

                        // adicionar um novo cnpj nessa lista de restritos

                        break;

                    case 3:

                        // procurar por um cnpj especifico nessa lista e se achar deve remove-lo

                        break;
                }

            } while (true);
        }
        #endregion

        #region TELAS_COMPANHIAS_AEREAS
        static void TelaInicialCompanhiasAereas() // OK! Só tirar o comentario!
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\nInforme a Opção Desejada:\n");
                Console.WriteLine(" 1 - Companhia Aéria já cadastrada\n");
                Console.WriteLine(" 2 - Cadastrar uma Nova Companhia Aérea\n");
                Console.WriteLine("\n 0 - SAIR\n");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine()); // opc = int.Parse(ValidarEntrada("menu"));

                switch (opc)
                {
                    case 0:

                        TelaInicial();

                        break;

                    case 1:

                        TelaLoginCompanhiaAerea();

                        break;

                    case 2:

                        TelaCadastrarCompanhiaAerea();

                        break;
                }

            } while (opc != 0);
        }

        static void TelaLoginCompanhiaAerea() // OK ~ Falta Acertar o uso das funções e liberar as partes comentadas *
        {
            //CompanhiaAerea compAtivo;
            Console.Clear();
            Console.WriteLine("\nInforme o 'CNPJ' para Entrar:\n");
            //compAtivo = ValidarLoginCompanhiaAerea();
            //if (compAtivo == null)
            //  {
            //      Pausa();
            //      TelaInicialPassageiro();
            //  }

            TelaOpcoesCompanhiaAerea(/*compAtivo*/); // encontrou um 'CNPJ' valido e existente nos cadastros, então manda para a tela de opções
        }
        static void TelaCadastrarCompanhiaAerea()
        {

        }
        static void TelaOpcoesCompanhiaAerea(/*CompanhiaAerea compAtivo*/)
        {

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
