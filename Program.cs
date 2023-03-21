using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float primeirovalor = 0;
            float segundovalor = 0;

            //Limpando console
            Console.Clear();

            MostrarMenu();

            int OperacaoEscolhida = int.Parse(Console.ReadLine());

            // perguntando usuário o primeiro valor do calculo
            Console.WriteLine("Por favor, Digite o primeiro valor !");
            //pegando o que usuário digitar e transformando o texto em float (numeros decimais)
            primeirovalor = float.Parse(Console.ReadLine());
            //Mostrando no console o primeiro valor digitado 
            Console.WriteLine("O primeiro valor é : " + primeirovalor);

            Console.WriteLine();

            //Se a operação escolhida for diferente de uma raiz quadrada, perguntar o segundo valor.
            if(OperacaoEscolhida != 5)
            {
                //perguntando usuário o segundo valor do calculo
                Console.WriteLine("Por favor, Digite o segundo valor !");
                //pegando o que usuário digitar e transformando o texto em float (numeros decimais)
                segundovalor = float.Parse(Console.ReadLine());
                //Mostrando no console o segundo  valor digitado 
                Console.WriteLine("O segundo valor é: " + segundovalor);
            }

            Console.WriteLine();

            switch (OperacaoEscolhida)
            {
                case 1:Somar(primeirovalor,segundovalor);break;
                case 2:Subtracao (primeirovalor,segundovalor);break;
                case 3:Multiplicacao(primeirovalor,segundovalor);break;
                case 4:Divisao (primeirovalor,segundovalor);break;
                case 5:Raizquadrada(primeirovalor);break;
                case 6:System.Environment.Exit(0);break;
                default:MostrarMenu();break;
            }
        }

        static void Somar(float primeirovalor, float segundovalor)
        {
            Console.WriteLine("A Soma é: " + (primeirovalor + segundovalor));
        }

        static void Subtracao(float primeirovalor, float segundovalor)
        {
            Console.WriteLine("A Subtracão é :" + (primeirovalor - segundovalor));
        }

        static void Multiplicacao(float primeirovalor, float segundovalor)
        {
            Console.WriteLine("A Multiplicacão é :" + (primeirovalor * segundovalor));
        }

        static void Divisao(float primeirovalor, float segundovalor)
        {
            Console.WriteLine("A Divisão é :" + (primeirovalor / segundovalor));
        }
        
        static void Raizquadrada (float primeirovalor)
        {
           var valorRaizQuadrada = Math.Sqrt(primeirovalor);
           Console.WriteLine("Raiz Quadrada é:" + valorRaizQuadrada);
        }    
           
        static void MostrarMenu()
        {
            Console.WriteLine("O que deseja ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Raiz Quadrada");

            Console.WriteLine("");
            Console.WriteLine("Por favor, escolha uma operação");
         }
    }
}