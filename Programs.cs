using System;

namespace AtividadeAvalitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            do
            {
                Console.WriteLine("\nSelecione uma atividade:");
                Console.WriteLine("1 - Validador de Senhas Fortes");
                Console.WriteLine("2 - Tabuada Completa");
                Console.WriteLine("3 - Fatorial");
                Console.WriteLine("4 - Conversor de Temperaturas");
                Console.WriteLine("5 - Verificador de Palíndromos");
                Console.WriteLine("6 - Cadastro de Produtos");
                Console.WriteLine("7 - Soma de Números Pares");
                Console.WriteLine("8 - Cálculo de IMC");
                Console.WriteLine("9 - Jogo da Adivinhação");
                Console.WriteLine("10 - Lista de Tarefas");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha: ");

                if (!int.TryParse(Console.ReadLine(), out escolha))
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                    continue;
                }

                Console.Clear();

                switch (escolha)
                {
                    case 1:
                        Atividades.ValidadorDeSenha();
                        break;
                    case 2:
                        Atividades.Tabuada();
                        break;
                    case 3:
                        Atividades.Fatorial();
                        break;
                    case 4:
                        Atividades.ConversorTemperatura();
                        break;
                    case 5:
                        Atividades.VerificadorDePalindromo();
                        break;
                    case 6:
                        Atividades.CadastroDeProdutos();
                        break;
                    case 7:
                        Atividades.SomaNumerosPares();
                        break;
                    case 8:
                        Atividades.CalculoIMC();
                        break;
                    case 9:
                        Atividades.JogoAdivinhacao();
                        break;
                    case 10:
                        Atividades.ListaDeTarefas();
                        break;
                    case 0:
                        Console.WriteLine("Encerrando o programa.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                if (escolha != 0)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (escolha != 0);
        }
    }
}
