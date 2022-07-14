using System;
using System.Collections.Generic;

namespace TargetTest
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Aperte enter para iniciar as questões");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Questão 1 - Soma");
                    Questao1();
                    Console.WriteLine();
                    Console.WriteLine("-------");
                    Console.Write("Aperte enter para a quesão 2");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("Questão 2 - Fibonacci");
                    Console.Write("Digite um número para a sequência de Fibonacci: ");
                    Questao2();
                    Console.WriteLine();
                    Console.WriteLine("-------");
                    Console.Write("Aperte enter para a questão 3");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("Questão 3 - Lógica próximo elemento");
                    Questao3();
                    Console.WriteLine();
                    Console.WriteLine("-------");
                    Console.Write("Aperte enter para a questão 4");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("Questão 4 - Distância");
                    Questao4();
                    Console.WriteLine();
                    Console.WriteLine("-------");
                    Console.Write("Aperte enter para a questão 5");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("Questão 5 - Texto invertido");
                    Questao5();
                    Console.WriteLine();
                    Console.WriteLine("-------");
                    Console.WriteLine("Obrigado!");
                    Console.WriteLine("Aperte enter para sair");
                    Console.ReadKey();
                    Console.Clear();

                }
                catch (System.FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Erro! Só dados numéricos");
                    Console.WriteLine("Reiniciando...");
                    Console.WriteLine();
                }
            }
        }


        //Questão 1 - Soma
        static void Questao1()
        {
            int indice = 13, soma = 0;

            for (int k = 0; k < indice; k++)
            {
                k += 1;
                soma += +k;
            }
            Console.WriteLine("Resultado: " + soma);
        }


        //Questão 2 - Fibonacci
        static void Questao2()
        {
            int digite = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            int numero1 = 0, numero2 = 1, auxiliar;

            //Cálculo Fibonacci
            for (int i = 0; i​​​​​​​ < digite; i++)
            {
                auxiliar = numero1;
                numero1 = numero2;
                numero2 = numero1 + auxiliar;
                Console.WriteLine(numero2);
                list.Add(numero2);
            }

            //Teste para ver se há o número informado na lista Fibonacci
            if (list.Contains(digite))
            {
                Console.WriteLine(); Console.WriteLine($"O número informado: ({digite}) pertence a sequência Fibonacci!");
            }
            else
            {
                Console.WriteLine(); Console.WriteLine($"O número informado: ({digite}) não pertence a sequência Fibonacci!");
            }
        }


        //Questão 3 - Lógica próximo elemento
        static void Questao3()
        {
            Console.WriteLine("Respostas:");
            Console.WriteLine("A) 1, 3, 5, 7, Resposta: (9)");
            Console.WriteLine("B) 2, 4, 8, 16, 32, 64, Resposta: (128)");
            Console.WriteLine("C) 0, 1, 4, 9, 16, 25, 36, Resposta: (49)");
            Console.WriteLine("D) 4, 16, 36, 64, Resposta: (100)");
            Console.WriteLine("E) 1, 1, 2, 3, 5, 8, Resposta: (13)");
            Console.WriteLine("F) 2, 10, 12, 16, 17, 18, 19, Resposta: (200)");
        }


        //Questão 4 - Distância
        static void Questao4()
        {
            double velCarro = 110, velCaminhao = 80, dist = 100;
            double tempoPedagio = 10.0 / 60.0;

            double tempo = (velCaminhao + velCarro) / dist;
            double x1 = velCarro * tempo;
            double x2 = (dist - velCaminhao) * tempo;
            double sb = tempoPedagio * x2;

            if (x1 > sb)
            {
                Console.WriteLine("O caminhão está mais perto de Ribeirão Preto");
            }
            else
            {
                Console.WriteLine("O Carro está mais perto de Ribeirão Preto");
            }

            /* Cheguei a esse resultado somando a velocidade do carro com a velocidade do caminhão e dividindo pela distância
             * armazenei na variável tempo, depois multipliquei a velocidade do carro pela variável tempo para saber a distância do carro,
             * subtrai a velocidade do caminhão pela distância e após multipliquei pelo tempo para saber a distância do caminhão,
             * por último multipliquei o resutado da distância do caminhão pelo tempo gasto no pedágio. 
             * */

        }


        //Questão 5 - Texto invertido
        public static void Questao5()
        {
            string texto = "Minha String para Inverter";
            string textoInvertido = "";

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                textoInvertido += texto[i];
            }

            Console.WriteLine(string.Format($"Original : {texto}"));
            Console.WriteLine(string.Format($"Invertido: {textoInvertido}"));
        }

    }

}