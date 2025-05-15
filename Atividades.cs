using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace AtividadeAvalitiva
{
    class Atividades
    {
        public static void ValidadorDeSenha()
        {
            Console.Write("Digite uma senha: ");
            string senha = Console.ReadLine();
        
            bool tamanho = senha.Length >= 8;
            bool maiuscula = Regex.IsMatch(senha, "[A-Z]");
            bool numero = Regex.IsMatch(senha, "[0-9]");
            bool especial = Regex.IsMatch(senha, @"[!@#$%\^&*()_\-+=\[\]{}|;:',.<>?/`~]");
        
            if (tamanho && maiuscula && numero && especial)
                Console.WriteLine("Senha forte!");
            else
                Console.WriteLine("Senha fraca!");
        }

        public static void Tabuada()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        public static void Fatorial()
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            int resultado = 1;

            while (n > 1)
            {
                resultado *= n;
                n--;
            }

            Console.WriteLine("Fatorial: " + resultado);
        }

        public static void ConversorTemperatura()
        {
            int opcao;
            do
            {
                Console.WriteLine("\n1 - Celsius para Fahrenheit");
                Console.WriteLine("2 - Fahrenheit para Celsius");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Celsius: ");
                        double c = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Fahrenheit: {c * 9 / 5 + 32}");
                        break;
                    case 2:
                        Console.Write("Fahrenheit: ");
                        double f = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Celsius: {(f - 32) * 5 / 9}");
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 3);
        }

        public static void VerificadorDePalindromo()
        {
            Console.Write("Digite uma palavra ou frase: ");
            string entrada = Console.ReadLine().ToLower();
            string limpo = Regex.Replace(entrada, "[^a-z0-9]", "");
            string reverso = new string(limpo.Reverse().ToArray());

            Console.WriteLine(limpo == reverso ? "É um palíndromo." : "Não é um palíndromo.");
        }

        public static void CadastroDeProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());
                produtos.Add(new Produto { Nome = nome, Preco = preco, Quantidade = quantidade });
            }

            foreach (var p in produtos)
            {
                Console.WriteLine($"{p.Nome} - Total em estoque: {p.Preco * p.Quantidade}");
            }
        }

        public static void SomaNumerosPares()
        {
            int[] numeros = new int[10];
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] % 2 == 0) soma += numeros[i];
            }

            Console.WriteLine("Soma dos pares: " + soma);
        }

        public static void CalculoIMC()
        {
            Console.Write("Peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Altura (m): ");
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);

            Console.WriteLine($"IMC: {imc:F2}");

            if (imc < 18.5) Console.WriteLine("Abaixo do peso");
            else if (imc < 25) Console.WriteLine("Peso normal");
            else if (imc < 30) Console.WriteLine("Sobrepeso");
            else Console.WriteLine("Obesidade");
        }

        public static void JogoAdivinhacao()
        {
            Random rnd = new Random();
            int numero = rnd.Next(1, 101);
            int tentativa, tentativas = 0;

            do
            {
                Console.Write("Adivinhe o número (1-100): ");
                tentativa = int.Parse(Console.ReadLine());
                tentativas++;

                if (tentativa < numero) Console.WriteLine("Maior!");
                else if (tentativa > numero) Console.WriteLine("Menor!");
                else Console.WriteLine($"Acertou em {tentativas} tentativas!");

            } while (tentativa != numero);
        }

        public static void ListaDeTarefas()
        {
            List<string> tarefas = new List<string>();
            string opcao;

            do
            {
                Console.Write("Digite uma tarefa (ou 'sair' para encerrar): ");
                opcao = Console.ReadLine();
                if (opcao.ToLower() != "sair") tarefas.Add(opcao);
            } while (opcao.ToLower() != "sair");

            Console.WriteLine("Tarefas adicionadas:");
            foreach (var t in tarefas)
                Console.WriteLine("- " + t);
        }
    }

    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
    }
}
