using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            //Essa é a estrutura padrão do C#. para criá-la, basta abrir o console e digitar "dotnet new console"
            //Para executar, abra o console e digite "dotnet run"



            //Variáveis declaração completa:
            int SegundaGuerraMundial = 1945;
            string corfavorita = "azul"; //sempre aspas duplas para string
            float velocidadeF1 = 298.48f; //Float necessita f apos o numero
            char inicial = 'J'; //Char usa aspas simples somente
            bool segundaGuerra = true; //Bool recebe true ou false

            //Variáveis declaração preguiçosa:
            var CarroFavorito = "GTR Skyline";
            var numeros = 12345;
            //O C# vai adivinhar qual o tipo da variavel de acordo com o valor que foi atribuido

            //Variável dinamica:
            dynamic cor_favorita = "Vermelho";
            //Diferente dos outros, eu posso alterar o tipo desse variavel durante a execução do programa
            //Foge do padrao do C#, PQ TODA HORA ELE VAI CHECAR SE O TIPO FOI ALTERADO, NÃO É PRATICO, É LENTO

            //Escrevendo as variaveis na tela:
            Console.WriteLine("Variaveis completas: ");
            Console.WriteLine(SegundaGuerraMundial);
            Console.WriteLine(corfavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(inicial);
            Console.WriteLine(segundaGuerra);
            //Variaveis preguiçosas:
            Console.WriteLine("\nVariaveis preguiçosas:");
            Console.WriteLine(CarroFavorito);
            Console.WriteLine(numeros);
            //Dinamica:
            Console.Write("\nVariavel dinamica: " + cor_favorita);

            //writeLine escreve na tela linha por linha como se colocasse um \n, ja o write escreve sem
            //pode ser feita concatenação usando o "+"



            //Chamando uma função mesmo arquivo:
            //declaro ela na main como uma variavel:
            //Eu busco ela a class do arquivo e apos isso eu busco a função com: class.NomeDaVariavelCriada
            Program principal = new Program();
            principal.constantes();
            principal.conta(90);

            //Para receber o retorno de uma função, devo atribui-la a uma variavel:
            int soma1 = Somar(50, 10, 20);
            Console.WriteLine("\n\nResultado de soma1: " + soma1); 



            //Buscando em outro aruivo:
            // é a mesma forma
            continuacao Continuação = new continuacao();
            Continuação.OperadoresAritmeticos();
            Continuação.OperadoresCondicionais();
            Continuação.Arrays();
            Continuação.switchcase();
            Continuação.enumeradorEEnumSwitch();
            Continuação.Enquanto();
            Continuação.facaEnquanto();
            Continuação.estruturaForeach();
            Continuação.estruturaFor();
            Continuação.Escopo();
        }

            //Criando uma FUNÇAO

        public void constantes()
        {
            //Declaração de constantes:
            const float PI = 3.14555445f;

            //Uma constante só é definida uma unica vez e o valor dela nunca será mudado durante a execução do programa
            Console.WriteLine("\nValor da constante: " + PI);
        }


        public void conta(int num)
        {
            //Esta função passa um numero de tipo inteiro por parametros
            Console.WriteLine(num + " * 4 = " + (num * 4));

        }


        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal; //Essa função retorna o valor de resultadoFinal

        }

    }
}