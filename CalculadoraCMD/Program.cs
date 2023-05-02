﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCMD
{
    internal class Program
    {
        /* Este Enum esta definindo os itens de nosso MENU. Como ENUM começã no Indice 0, podemos setar o valor 1 no primeiro valor
        Dessa forma os subsequentes vão pegar os proximos em ordem crescente, ou definir manualmente seus indices. */
        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4 , Potencia = 5, Raiz = 6, Sair = 7 }

        static void Main(string[] args)
        {
            bool escolheuSair = false;

            // sinal de (! exclamação) antes da condição, inverte o 
            while (!escolheuSair) // Equanto usuario não escolhe sair, EXIBA O MENU
            {
                /* Esse código cria uma calculadora pelo CMD onde possível realizar as seguintes operações:
               Soma, Subtração, Multiplicação, Divisão, Raiz e Potencia -- Com um menu em Loop -- */

                // Menu CMD - Opções
                Console.WriteLine("Seja bem vindo ao Calc CMD, Selecione a operação desejada: ");
                Console.WriteLine("\n1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair");

                // 1° Precisamos converter o texto(String do Usuário) para um INTeiro com: int.Pars
                // 2° Vamos converter esse INT para ENUM Colocando o Tipo dendtro de () no caso (Menu) que é um Enum
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        break;

                    case Menu.Divisao:
                        Divisao();
                        break;

                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                
                }

                Console.Clear();
            }            
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu: ");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu: ");
            Console.ReadLine();   
        }

        /* Na divisão vamos precisar fazer um CAST do tipo de dado de: INT para FLOAT 
         No caso do RESULTADO, apena alterando um dos dados para FLOAT, o resultado ja ira sew tornar um FLOAT, por fim didaditicos, fizemos CAST nas duas variaveis */
        static void Divisao()
        {
            Console.WriteLine("Divisão entre dois númeoros: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado  = (float)a / (float)b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu: ");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação entre dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar: ");
            Console.ReadLine();
        }

        /* static void Potencia()
        {
            Console.WriteLine("Potencia entre dois números: ");
            Console.WriteLine("Digite o priemiro número: ");
            double a = double.Parse (Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a ** b;
        } */
    }
}
