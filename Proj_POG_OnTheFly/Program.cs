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
                        string validarLogin = ValidarEntrada("cpflogin");
                        if (validarLogin == null) TelaInicialPassageiros(passageiroAtivo);

                        else if (validarLogin == passageiroAtivo.Cpf)
                        {
                            TelaVendas(passageiroAtivo);
                        }

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
            string cpf;
            Passageiro passageiroAtivo;
            Console.Clear();
            cpf = ValidarEntrada("cpfexiste");
            if (passageiroAtivo == null)
            {
                Pausa();
                TelaInicialPassageiro();
            }
            foreach (Passageiro passageiro in ListPassageiro)
            {
                if (passageiro.Cpf == cpf)
                {
                    passageiroAtivo = passageiro;
                    TelaEditarPassageiro(passageiroAtivo); // encontrou um 'CPF' valido e existente nos cadastros, então manda para a tela de opções.
                }
            }
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

                        TelaInicialPassageiros(/*Passageiro passageiroAtivo*/);

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

        // LEMBRAR DE VERIFICAR OS NOMES DAS LISTAS E FUNÇÕES 'GRAVAR' ***
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
        static void TelaLoginCompanhiaAerea() // // OK ! Só dar um 'CTRL+K+U' em tudo pra tirar os comentarios
        {
            //string cnpj;
            //CompanhiaAerea compAtivo;
            Console.Clear();
            Console.WriteLine("\nInforme o 'CNPJ' para Entrar:\n");
            //cnpj = ValidarEntrada("cnpj");
            //if(cnpj == null) TelaInicialCompanhiasAereas();
            //
            //foreach (CompanhiaAerea existente in ListCompanhiaAerea)
            //{
            //if(existente.Cnpj == cnpj)
            //  {
            //      compAtivo = existente;
            //      TelaOpcoesCompanhiaAerea(/*compAtivo*/); // encontrou um 'CNPJ' valido e existente nos cadastros, então manda para a tela de opções
            //  }
            //}            

        }
        static void TelaCadastrarCompanhiaAerea() // OK ! Só dar um 'CTRL+K+U' em tudo pra tirar os comentarios
        {
            do
            {
                string nomeComp;
                string cnpj;
                string dataAbertura;
                // enviar nos parametros (date.now para datacadastro e situacao 'A')
                //CompanhiaAerea novaComp;

                //nomeComp = ValidarEntrada("nome");
                //if (nomeComp == null) TelaInicialCompanhiasAereas();
                //cnpj = ValidarEntrada("cnpj");
                //if (cnpj == null) TelaInicialCompanhiasAereas();
                //dataAbertura = ValidarEntrada("dataabertura");
                //if (dataAbertura == null) TelaInicialCompanhiasAereas();

                //novaComp = new CompanhiaAerea(cnpj, nomeComp, DateConverter(dataAbertura),System.DateTime.Now, System.DateTime.Now, 'A');
                //listCompanhia.Add(novaComp);
                //GravarCompanhia(listCompanhia);



            } while (true);
        }
        static void TelaOpcoesCompanhiaAerea(/*CompanhiaAerea compAtivo*/) // Ok ~ Só tirar os comentarios
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\nCompanhia Aérea " /* + compAtivo.RazaoSocial*/);
                Console.WriteLine("\nPor Favor, informe a Opção Desejada:\n");
                Console.WriteLine(" 1 - Cadastrar uma nova Aeronave\n");
                Console.WriteLine(" 2 - Programar um novo Voo\n");
                Console.WriteLine(" 4 - Ver a Lista de Aeronaves Cadastradas\n");
                Console.WriteLine(" 3 - Ver a Lista de Voos Cadastrados\n");               
                Console.WriteLine("\n 0 - Encerrar Sessão\n");
                opc = int.Parse(Console.ReadLine()); // opc = int.Parse(ValidarEntrada("menu"));

                switch(opc)
                {
                    case 0:

                        TelaInicialCompanhiasAereas(/*compAtivo*/);

                        break;

                    case 1:

                        TelaCadastrarAeronave(/*compAtivo*/);

                        break;

                    case 2:

                        TelaCadastrarVoo(/*compAtivo*/);

                        break;

                    case 3:

                        TelaVerAeronavesCadastradas(/*compAtivo*/);

                        break;

                    case 4:

                        TelaVerVoosCadastrados(/*compAtivo*/);

                        break;
                }


            } while (true);
        }
        static void TelaCadastrarAeronave(/*CompanhiaAerea compAtivo*/) // OK ! Só dar um 'CTRL+K+U' em tudo pra tirar os comentarios
        {
                string idAeronave;
                int capacidade;
                // enviar os assentos ocupados por parametro como '0';
                // enviar nos parametros (system.datetime.now para ultima venda e data cadastro)
                char situacao;
            //Aeronave novaAeronave;

            //idAeronave = ValidarEntrada("idaeronave");
            //if (idAeronave == null) TelaOpcoesCompanhiaAerea(/*compAtivo*/);
            //capacidade = int.Parse(ValidarEntrada("capacidade"));
            //if (capacidade == null) TelaOpcoesCompanhiaAerea(/*compAtivo*/);
            //situacao = char.Parse(ValidarEntrada("situacao"));
            //if (situacao.Equals(null)) TelaOpcoesCompanhiaAerea(/*compAtivo*/);

            //novaAeronave = new Aeronave(idAeronave, capacidade, 0, System.DateTime.Now, System.DateTime.Now, situacao);
            //listAeronave.Add(novaAeronave);
            //GravarAeronaves(listAeronave);
            Console.WriteLine("\nCadastro Realizado com Sucesso!");
            Pausa();
            TelaOpcoesCompanhiaAerea(/*compAtivo*/);
        }
        static void TelaCadastrarVoo(/*CompanhiaAerea compAtivo*/) // OK ! Só dar um 'CTRL+K+U' em tudo pra tirar os comentarios
        {
            Console.Clear();
            string idVoo;
            string destino;
            string idAeronave;
            string idPassagem;
            string auxData;
            DateTime dataVoo;///data e hora
            float valor;
            //Voo novoVoo;

            //idVoo = GeradorId("idvoo");
            //if (idVoo == null) TelaOpcoesCompanhiaAerea(/*compAtivo*/);

            //destino = ValidarEntrada("destino");
            //if (destino == null) TelaOpcoesCompanhiaAerea(/*compAtivo*/);

            //idAeronave = ValidarEntrada("aeronave");
            //if (idAeronave == null) TelaOpcoesCompanhiaAerea(/*compAtivo*/);

            //auxData = ValidarEntrada("datavoo");
            //if(auxData == null) TelaOpcoesCompanhiaAerea(/*compAtivo*/);
            //dataVoo = DateHourConverter(auxData));

            //valor = float.Parse(ValidarEntrada("valorpassagem"));
            //if (valor == null) TelaOpcoesCompanhiaAerea(/*compAtivo*/);

            //novoVoo = new Voo(GeradorId("idvoo"), destino, idAeronave, dataVoo, System.DateTime.Now, 'A');
            //listVoo.Add(novoVoo);
            //GravarVoo(listVoo);
            Console.WriteLine("\nCadastro Realizado com Sucesso!");
            Pausa();
            TelaOpcoesCompanhiaAerea(/*compAtivo*/);
        }
        static void TelaVerAeronavesCadastradas(/*CompanhiaAerea compAtivo*/)
        {
            //Console.Clear();
            //foreach (Aeronave aeroNave in listAeronave)
            //{
            //    Console.WriteLine("ID: " + aeroNave.Inscricao + "Situação: " + aeroNave.Situacao);
            //}
            //Console.WriteLine("\n-----------------------------------------------------------------");
            //Console.Write("\nInforme o ID da Aeronave que deseja ver os detalhes: ");
            //string aeronave = ValidarEntrada("aeronave");
            //if (aeronave == null) TelaOpcoesCompanhiaAerea(/*compAtivo*/);

            //foreach (Aeronave aeroNave in listAeronave)
            //{
            //    if (aeroNave.Inscricao == aeronave)
            //        TelaEditarAeronave(compAtivo, aeroNave);
            //}
        }
        static void TelaEditarAeronave(/*CompanhiaAerea compAtivo, Aeronave aeroNave*/)
        {

        }
        static void TelaVerVoosCadastrados()
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
