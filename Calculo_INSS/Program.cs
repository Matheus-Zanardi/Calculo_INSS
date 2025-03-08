using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_INSS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // iniciando com RM e senha

            string usuario = "";
            string senha = "";
            string sexo = "";
            int idade = 0;
            int tempoContribuicao = 0;

            while (true)
            {
                Console.WriteLine("Digite o email para logar");
                usuario = Console.ReadLine();
                Console.WriteLine("Digite a senha do login!");
                senha = Console.ReadLine();
                if (usuario == "rm98832@fiap.com.br" && senha == "98832")
                    break;
                else
                {
                    Console.WriteLine("usuario ou senha incorretos!!!\nTente novamente...");
                }
            }
                // Validação do sexo
                while (true)
                {
                    Console.WriteLine("Digite o sexo da pessoa (M para Masculino, F para Feminino): ");
                    sexo = Console.ReadLine().ToUpper();

                    if (sexo == "M" || sexo == "F")
                        break;
                    else
                        Console.WriteLine("Sexo inválido! Por favor, digite 'M' para Masculino ou 'F' para Feminino.");
                }

                // Validação da idade
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Digite a idade da pessoa: ");
                        idade = int.Parse(Console.ReadLine());

                        if (idade > 0)
                            break;
                        else
                            Console.WriteLine("Idade invalida! Por favor, insira um numero positivo.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Entrada inválida! Por favor, insira um número válido para a idade.");
                    }
                }

                // Validação do tempo de contribuição
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Digite o tempo de contribuição (em anos): ");
                        tempoContribuicao = int.Parse(Console.ReadLine());

                        if (tempoContribuicao >= 0)
                            break;
                        else
                            Console.WriteLine("Tempo de contribuição invalido! Por favor, insira um número válido.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Entrada inválida! Por favor, insira um número válido para o tempo de contribuição.");
                    }
                }

                // Idade para se aposentar e Tempo de Contribuicao

                int idadeMinima = 0;
                if (sexo == "M")
                {
                    idadeMinima = 65;
                }
                else
                {
                    idadeMinima = 62;
                }

                int tempoMinimoContribuicao = 0;
                if (sexo == "M")
                {
                    tempoMinimoContribuicao = 35;
                }
                else
                {
                    tempoMinimoContribuicao = 30;
                }

                // Verificando se a pessoa pode se aposentar
                if (idade >= idadeMinima && tempoContribuicao >= tempoMinimoContribuicao)
                {
                    Console.WriteLine("A pessoa pode se aposentar pelo INSS.");
                }
                else
                {
                    if (idade < idadeMinima)
                    {
                        Console.WriteLine($"A pessoa ainda não atingiu a idade mínima para aposentadoria. Precisa ter {idadeMinima} anos.");
                        Console.ReadKey();
                    }
                    if (tempoContribuicao < tempoMinimoContribuicao)
                    {
                        Console.WriteLine($"A pessoa ainda não tem o tempo de contribuição mínimo. Precisa de {tempoMinimoContribuicao} anos.");
                        Console.ReadKey();
                    }
                }
            Console.WriteLine("Muito obrigado por usar nosso calculo de INSS\n\nAperte qualquer tecla para Sair");
            Console.ReadLine();
            }
        }
    }
