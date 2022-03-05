using System;

namespace teste
{
    class continuacao
    {
        public void OperadoresAritmeticos()
        {
            Console.WriteLine("\n\nOPERADORES ARITMETICOS");       
            int numeroSoma = 20 + 20;
            int numeroSub = 15 - 7;
            int numeroMult = 10 * 90;
            int numeroDiv = 90 / 10;

            Console.WriteLine(numeroSoma);
            Console.WriteLine(numeroSub);
            Console.WriteLine(numeroMult);
            Console.WriteLine(numeroDiv);

        }


        public void OperadoresCondicionais()
        {
            Console.WriteLine("\n\nOPERADORES CONDICIONAIS:");
            Console.Write("\nDigite um numero inteiro: ");
            int num = int.Parse(Console.ReadLine());

            //O console readline le o valor digitado pelo usuario como uma string, sendo assim, na atribuição do valor à variavel, usa-se "int.Parse" Para converter o valor para tipo inteiro

            //if, else if e else:
            if(num > 2){
                Console.WriteLine("É VERDADE!!");

            }else if (num == 2){
                Console.WriteLine("SÃO IGUAIS!!");

            }else{
                Console.WriteLine("SEU NUMERO É MENOR HAHAHAHAHAH");

            }
        }


        public void Arrays()
        {   

            Console.WriteLine("\n\nARRAYS: ");
            //Arrays = Vetores

            /*
            string produto1 = "Sea of thieves";
            string produto2 = "Minecraft";
            string produto3 = "Counter Strike;"
            */

            //DECLARAÇÃO DO VETOR:
            string[] produtos = new string[3] { "Sea of Thieves", "Minecraft", "Counter Strike" };

            Console.WriteLine("\n\nLeitura de posição do vetor: ");
            Console.WriteLine("Vetor posição 0: " + produtos[0]);
            Console.WriteLine("Alterando o que está na posição 1: ");
            produtos[0] = "FIFA 21";
            Console.WriteLine(produtos[0]);

            int[] valores = { 40, 50, 60, 70, 20 };
            //O C# entende o tamanho do vetor pela quantidade de elementos
            // é uma forma mais simples

        }


        public void switchcase()
        {
            Console.WriteLine("\n\nSWITCH CASE: ");
            //Switch case é uma das opções para nao usar 300 if e eslse if, mas tambem não é a unica utilidade
            //Ele nao trabalha com condicionais: ">, <, !=, ==, etc"

            string cor = "Azul";
            switch(cor){
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho");
                    break;

                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é amarelo");
                    break;
                
                case "Azul":
                    Console.WriteLine("Sua cor favorita é Azul");
                    break;
                //Se nenhum dos casos existirem, ele executa o default
                default:
                    Console.WriteLine("EU NAO SEI SUA COR FAVORITA");
                    break;
            }

        }
        

        //Você pode usar um Enum para representar um conjunto fixo pequeno de constantes ou um modo de classe interno enquanto aumenta a legibilidade. Além disso, as enums podem impor uma certa rigidez quando usadas nos parâmetros do método.

        enum Cor { Azul, Verde, Amarelo, Vermelho}
        
        //Enum padrao:
        //Delaração acima
        //Fuunciona como a criação de um novo tipo
        //DEVO CRIAR ELE ACIMA DA FUNÇÃO



        //DECLARAÇÃO DO ENUM A SER USADO COM SWITCHCASE:
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
            
        //Agora toda vez que eu criar uma variavel com o tipo cor, ela só vai poder ter um desses valores
        //cada elemento tem um valor, começando pelo 0, porém posso alterar o valor de cada
        //PASSE O MOUSE POR CIMA DE CADA ELEMENTO PARA VER O VALOR

        public void enumeradorEEnumSwitch()
        {
            
            Console.WriteLine("\n\nENUMERADOR");
            //EXEMPLO DE ENUM:
            Cor corfavorita = Cor.Vermelho;
            Cor corfavoritamyfriend = Cor.Amarelo;

            Console.WriteLine(corfavorita);
            Console.WriteLine((int)corfavoritamyfriend); //com o tipo em parenteses antes, eu posso converter pra numero, se chama cast
            Console.WriteLine((Cor)2); //O mesmo acontece ao contrário
            
            
            

            Console.WriteLine("\n\nCRIANDO UM MENU COM ENUMERADOR E SWITCHCASE: ");
            //Criando um menu:
            Console.WriteLine("Selecione uma das opcoes abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar\n");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            Console.WriteLine("OPÇÃO SELECIONADA: " + opcaoSelecionada);
            
            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("\nVoce quer criar algo!!!");
                    break;

                case Opcao.Deletar:
                    Console.WriteLine("\nDELETE!! DELETE IMEDIATAMENTE!!!");
                    break;

                case Opcao.Editar:
                    Console.WriteLine("\nEditar é muito bom!");
                    break;

                case Opcao.Listar:
                    Console.WriteLine("\nHMMM entao voce quer listar algo???");
                    break;

                case Opcao.Atualizar:
                    Console.WriteLine("\nAtualizando...");
                    break;
                default:
                    Console.WriteLine("\nOPÇÃO NAO ENCONTRADA!!!");
                    break;
            }
        }


        public void Enquanto()
        {
            Console.WriteLine("\n\nESTRUTURA WHILE");
            //While = enquanto
            //While repete tal estrutura enquanto tal condição for verdadeira
            //Se le como: enquanto for verdade faça
            int contador = 0;
            while(contador < 5)
            {
                Console.WriteLine("WHILE ESTÁ RODANDO");
                //contador = contador + 1;]
                //contador+=1;
                contador++;
            }
            Console.WriteLine("FIM DA LINHA");
        }


        public void facaEnquanto()
        {   
            Console.WriteLine("\n\nESTRUTURA DO WHILE");
            //DO WHILE
            //FAÇA ENQUANTO
            int n = 9;
            do
            {
                Console.WriteLine("DO WHILE");
                n++;
                
            }while(n < 11);
        }

        public void estruturaForeach()
        {
            Console.WriteLine("\n\nESTRUTURA FOREACH");

            string[] nomes = { "Jhonatan", "Gabriel", "Joao", "Maria", "Tamires", "Pedro", "Aurora" };
            //deve ter uma variavel de loop do mesmo tipo que o array
            foreach(string nome in nomes) // foreach = para cada //PARA CADA NOME NO ARRAY NOMES< REPITA O BLOCO DE CODIGO
            {
                Console.WriteLine(nome);
            }
        }


        public void estruturaFor()
        {
            Console.WriteLine("\n\nESTRUTURA FOR");

            string[] nomes = { "Jhonatan", "Gabriel", "Joao", "Maria", "Tamires", "Pedro", "Aurora" };

            for(int i = 0; i < nomes.Length ; i++ ){ //Lenght diz o tamanho do array
                Console.WriteLine(nomes[i]);
            }
        }


        public void Escopo()
        {
            //Está diretamente relacionado com variaveis
            //Esopo local é quando vc declara uma variavel dentro de uma função
            //Escopo global é uma variavel global que qualquer função consegue chamar
            //A nossa class é o escopo global, se eu criar a variavel la, qualquer função conesgue chamar
            //porem devo declara a variavel com "static" antes, ex: static string meuNome = "jhonatan";
            Console.WriteLine("\n\nPARA VER SOBRE ESCOPO, VEJA O FINAL DO ARQUIVO CONTINUAÇÃO");



        }
    }
}