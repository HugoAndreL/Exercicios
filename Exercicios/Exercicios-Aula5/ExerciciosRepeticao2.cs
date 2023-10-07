﻿namespace Exercicios_Aula5
{
    internal class ExerciciosRepeticao2
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Selecione um Exercicio: (Digite apenas o número do exercicio)\n" +
                "-------------------------\n" +
                "1 = Exercicio 1 - Aula 5\n" +
                "2 = Exercicio 2 - Aula 5\n" +
                "3 = Exercicio 3 - Aula 5\n" +
                "4 = Exercicio 4 - Aula 5\n" +
                "5 = Exercicio 5 - Aula 5\n" +
                "6 = Exercicio 6 - Aula 5\n" +
                "7 = Exercicio 7 - Aula 5\n" +
                "8 = Exercicio 8 - Aula 5\n" +
                "9 = Exercicio 9 - Aula 5\n" +
                "10 = Exercicio 10 - Aula 5\n" +
                "11 = Exercicio 11 - Aula 5\n" +
                "12 = Exercicio 12 - Aula 5\n" +
                "13 = Exercicio 13 - Aula 5\n" +
                "14 = Exercicio 14 - Aula 5\n" +
                "15 = Exercicio 15 - Aula 5\n" +
                "16 = Exercicio 16 - Aula 5\n" +
                "17 = Exercicio 17 - Aula 5\n" +
                "18 = Exercicio 18 - Aula 5\n" +
                "19 = Exercicio 19 - Aula 5\n" +
                "20 = Exercicio 20 - Aula 5\n" +
                "21 = Exercicio 21 - Aula 5\n" +
                "--------------------------");
                int input = int.Parse(Console.ReadLine());
                Console.Write("\n");

                switch (input)
                {
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                    case 1:
                        ex1("***** Exercicio 1 - Aula 5 *****");
                        break;
                    case 2:
                        ex2("***** Exercicio 2 - Aula 5 *****");
                        break;
                    case 3:
                        ex3("***** Exercicio 3 - Aula 5 *****");
                        break;
                    case 4:
                        ex4("***** Exercicio 4 - Aula 5 *****");
                        break;
                    case 5:
                        ex5("***** Exercicio 5 - Aula 5 *****");
                        break;
                    case 6:
                        ex6("***** Exercicio 6 - Aula 5 *****");
                        break;
                    case 7:
                        ex7("***** Exercicio 7 - Aula 5 *****");
                        break;
                    case 8:
                        ex8("***** Exercicio 8 - Aula 5 *****");
                        break;
                    case 9:
                        ex9("***** Exercicio 9 - Aula 5 *****");
                        break;
                    case 10:
                        ex10("***** Exercicio 10 - Aula 5 *****");
                        break;
                    case 11:
                        ex11("***** Exercicio 11 - Aula 5 *****");
                        break;
                    case 12:
                        ex12("***** Exercicio 12 - Aula 5 *****");
                        break;
                    case 13:
                        ex13("***** Exercicio 13 - Aula 5 *****");
                        break;
                    case 14:
                        ex14("***** Exercicio 14 - Aula 5 *****");
                        break;
                    case 15:
                        ex15("***** Exercicio 15 - Aula 5 *****");
                        break;
                    case 16:
                        ex16("***** Exercicio 16 - Aula 5 *****");
                        break;
                    case 17:
                        ex17("***** Exercicio 17 - Aula 5 *****");
                        break;
                    case 18:
                        ex18("***** Exercicio 18 - Aula 5 *****");
                        break;
                    case 19:
                        ex19("***** Exercicio 19 - Aula 5 *****");
                        break;
                    case 20:
                        ex20("***** Exercicio 20 - Aula 5 *****");
                        break;
                    case 21:
                        ex21("***** Exercicio 21 - Aula 5 ******");
                        break;
                }
                Console.WriteLine("Deseja limpar o console: (S - Sim; N - Não)");
                char cls = char.Parse(Console.ReadLine());
                if (cls == 'S' || cls == 's')
                    Console.Clear();
                else
                {
                    Console.Write("\n");
                    Console.WriteLine($"Retornando à pagina de navegação.\n");
                }
            }
        }

        static void ex1(string? msg)
        {
            /*
             * 1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
             * (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
             * Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.
             */
            Console.WriteLine(msg);

            int n = 0;

            while (n <= 0)
            {
                Console.Write("Digite um número inteiro positivo: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out n) && n > 0)
                    break;
                else
                    Console.WriteLine("Número inválido. Por favor, digite um número inteiro positivo.");
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine($"Números pares entre 1 e {n}:");

            for (int i = 2; i <= n; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----- Fim do Programa -----\n");
        }

        static void ex2(string msg)
        {
            /*
             * 2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
             * informar um outro número. Caso positivo, o programa em VS deve ser repetido.
             */
            ex1(msg);

            char input;

            while (true)
            {
                Console.WriteLine("Gostaria de Informar outro número (s/n)?");
                input = char.Parse(Console.ReadLine());

                if (input == 'S' || input == 's')
                    ex1(null);
                else break;
            }
        }

        static void ex3(string msg)
        {
            /*
             * 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
             * Se o usuário digitar 0 o programa em VS deve parar. 
             * Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.
             */
            Console.WriteLine(msg);

            int n;
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Insira um numero de usuário (Insira 0 para sair):");
                n = int.Parse(Console.ReadLine());

                if (n == 0)
                    sair = true;
                else continue;
            }

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex4(string msg)
        {
            /* 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
             * Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
             * Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
             * Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
             * escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
             * de votos em branco.
             */
            Console.WriteLine(msg);

            int zeca = 0, joao = 0, white = 0;
            string input;
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Digite o canditado à prefeito:\n" +
                    "JOAO\n" +
                    "ZECA\n" +
                    "BRANCO\n" +
                    "FIM para ver os resultados");
                input = Console.ReadLine();

                switch (input)
                {
                    case "ZECA":
                        zeca += 1;
                        break;
                    case "JOAO":
                        joao += 1;
                        break;
                    case "BRANCO":
                        white += 1;
                        break;
                    case "FIM":
                        sair = true;
                        break;
                }

                Console.Write("\n");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Resultados da Eleição:\n" +
                $"Votos Brancos: {white}\n" +
                $"Votos para Joao: {joao}\n" +
                $"Votos para Zeca: {zeca}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex5(string msg)
        {
            /*
             * 5.Modifique o programa em VS anterior para aceitar votos nulos
             * (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO).
             * Ao final, informe o nome do candidato vencedor, o número de votos nulos
             * e o número de pessoas que votaram.
             */
            Console.WriteLine(msg);

            int zeca = 0, joao = 0, white = 0, nulo = 0, maior = 0;
            string input, vencedor = "";
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Digite o canditado à prefeito:\n" +
                    "JOAO\n" +
                    "ZECA\n" +
                    "BRANCO\n" +
                    "FIM para ver os resultados");
                input = Console.ReadLine();

                switch (input)
                {
                    case "ZECA":
                        zeca += 1;
                        break;
                    case "JOAO":
                        joao += 1;
                        break;
                    case "BRANCO":
                        white += 1;
                        break;
                    case "FIM":
                        sair = true;
                        break;
                }
                if (input != "ZECA" && input != "JOAO" && input != "BRANCO" && input != "FIM")
                    nulo += 1;

                Console.Write("\n");
            }

            if (zeca > maior)
                vencedor = "Zeca";
            if (joao > maior)
                vencedor = "Joao";

            Console.WriteLine("----------------------------");
            Console.WriteLine("Resultados da Eleição:\n" +
                $"Votos Brancos: {white}\n" +
                $"Votos Nulos: {nulo}\n" +
                $"Votos para Joao: {joao}\n" +
                $"Votos para Zeca: {zeca}\n" +
                $"Cadidato Vencedor: {vencedor}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex6(string msg)
        {
            /*
             * 6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
             * ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
             * Ao final, mostre a idade digitada.
             */
            Console.WriteLine(msg);

            int idade = -1;

            while (idade <= 0)
            {
                Console.Write("Insira a sua idade:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out idade) && idade > 0)
                    break;
                else Console.WriteLine("Idade inválida. Por favor, insira uma idade válida maior do que zero.");
            }

            Console.WriteLine($"Idade válida digitada: {idade}");
        }

        static void ex7(string msg)
        {
            /*
             * 7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
             * A cada solicitação, teste se o usuário informou um valor válido. 
             * Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
             * informe que ele está incorreto e saia do programa em VS. 
             * Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
             * informe que está errada e saia. Se estiver correta, solicite o salário. 
             * Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
             * Se estiver correto, mostre todos os valores lidos.
             */
            Console.WriteLine(msg);

            string nome;
            int idade;
            double sal;


            while (true)
            {
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nome) || int.TryParse(nome, out _))
                {
                    Console.WriteLine("Nome incorreto. Por favor, digite um nome válido.");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.Write("Digite a idade: ");
                if (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
                {
                    Console.WriteLine("Idade incorreta. Por favor, digite uma idade válida maior que zero.");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.Write("Digite o salário: ");
                if (!double.TryParse(Console.ReadLine(), out sal) || sal <= 0)
                {
                    Console.WriteLine("Salário incorreto. Por favor, digite um salário válido maior que zero.");
                    continue;
                }

                break;
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Nome: {nome}\n" +
                $"Idade: {idade}\n" +
                $"Salário: R$ {sal},00");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex8(string msg)
        {
            /* 
             * 8. Faça um programa em VS que solicite um numero inteiro. 
             * Se o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
             * Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
             */
            Console.WriteLine(msg);

            int n = 0;
            string input = "";

            while (n <= 0)
            {
                Console.Write("Digite um número inteiro positivo: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out n) && n > 0)
                    break;
                else
                    Console.WriteLine("Número inválido. Por favor, digite um número inteiro positivo.");
            }

            Console.WriteLine("----------------------------");
            if (n % 2 == 0)
                Console.WriteLine($"O numero {int.Parse(input)} é par");
            else
                Console.WriteLine($"O número {int.Parse(input)} é impar");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex9(string msg)
        {
            /* 
             * 9.Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram
             * o zoológico num determinado dia, imprimindo:
             * Quantas pessoas tem entre 1 e 3 filhos.
             * Quantas pessoas tem entre 4 e 7 filhos.
             * Quantas pessoas tem mais de 8 filhos.
             * Quantas pessoas não tem filhos.
             */
            Console.WriteLine(msg);

            int nFilhos, pessoas13Filhos = 0, pessoas47Filhos = 0, pessoas8Filhos = 0, pessoas0Filhos = 0;

            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine($"Insira o número de filhos da {i}º pessoa:");
                nFilhos = int.Parse(Console.ReadLine());

                if (nFilhos >= 1 && nFilhos <= 3)
                    pessoas13Filhos += 1;
                else if (nFilhos >= 4 && nFilhos <= 7)
                    pessoas47Filhos += 1;
                else if (nFilhos >= 8)
                    pessoas8Filhos += 1;
                else if (nFilhos == 0)
                    pessoas0Filhos += 1;
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Contagem de Filhos:" +
                $"Pessoas sem filhos: {pessoas0Filhos}\n" +
                $"Pessoas entre 1 e 3 filhos: {pessoas13Filhos}\n" +
                $"Pessoas entre 4 e 7 filhos: {pessoas47Filhos}\n" +
                $"Pessoas com mais de 8 filhos: {pessoas8Filhos}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex10(string msg)
        {
            /*
             * 10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
             * Número de pessoas do sexo masculino.
             * Número de pessoas do sexo feminino.
             * Número de pessoas com idade inferior a 30 anos.
             * Número de pessoas com idade superior a 60 anos.
             * Média de idade das mulheres.
             */
            Console.WriteLine(msg);

            string nome;
            int idade, m = 0, f = 0, i30 = 0, i60 = 0, sumF = 0;
            float mediaTotal = 0;
            char sexo;

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"Digite o nome da {i}º pessoa:");
                nome = Console.ReadLine();

                Console.WriteLine($"Insira a idade da {i}º pessoa:");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine($"Selecione o sexo da {i}º pessoa (M - Masculino, F - Feminino):");
                sexo = char.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------");

                Console.Write("\n");

                switch (sexo)
                {
                    case 'M' or 'm':
                        m++;
                        break;
                    case 'F' or 'f':
                        f++;
                        break;
                }

                if (idade < 30)
                    i30++;
                else if (idade > 60)
                    i60++;

                if (sexo == 'F' || sexo == 'f')
                {
                    sumF += idade;
                    mediaTotal = sumF / f;
                }
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Dados dos Usuários:\n" +
                $"Número de Mulheres: {f}\n" +
                $"Número de Homens: {m}\n" +
                $"Número de pessoas com idade inferior a 30 anos: {i30}\n" +
                $"Número de pessoas com idade superior a 60 anos: {i60}\n" +
                $"Média de idade das mulheres: {mediaTotal}");
            Console.WriteLine("----- Fim do Exercicio -----\n");

        }

        static void ex11(string msg)
        {
            /*
             * 11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
             * a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura.
             */
            Console.WriteLine(msg);

            int quantAlunos = 0;
            double nota, notaBaixa = 10.0, notaAlta = 0.0, sum = 0, media;

            while (true)
            {
                Console.Write($"Digite a nota do aluno (-1 para encerrar): ");
                nota = double.Parse(Console.ReadLine());

                sum += nota;

                if (nota != -1)
                {
                    quantAlunos++;
                    Console.WriteLine("----------------------------");
                    Console.Write("\n");
                    if (nota > notaAlta && nota != -1)
                        notaAlta = nota;

                    if (nota < notaBaixa && nota != -1)
                        notaBaixa = nota;
                }

                if (nota == -1)
                    break;

            }

            media = sum / quantAlunos;
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Nota mais alta: {notaAlta}\n" +
                $"Nota mais baixa: {notaBaixa}\n" +
                $"Média da turma: {media}\n" +
                $"Quantidade de alunos: {quantAlunos}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex12(string msg)
        {
            // 12. Apresentar o total da soma dos cem primeiros números inteiros.
            Console.WriteLine(msg);

            int sum = 0;

            for (int i = 1; i <= 100; i++)
                sum += i;

            Console.WriteLine("----------------------------");
            Console.WriteLine($"A soma dos cem primeiros números inteiros é: {sum}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex13(string msg)
        {
            /* 
             * 13. Elaborar um programa que apresente o somatório dos valores pares existentes 
             * entre 1 e 500.
             */
            Console.WriteLine(msg);

            int sum = 0;

            for (int i = 1; i <= 500; i++)
                if (i % 2 == 0)
                    sum += i;

            Console.WriteLine("----------------------------");
            Console.WriteLine($"A soma dos números par entre 1 e 500 é: {sum}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex14(string msg)
        {
            // 14. Mostrar as potências de 2 variando de 0 a 10.
            Console.WriteLine(msg);

            double result = 1;

            Console.WriteLine("----------------------------");

            Console.WriteLine($"As potências de 2 variando de 0 e 10 é:");

            for (int e = 0; e <= 10; e++)
            {
                Console.WriteLine($"2^{e} = {result}");
                result *= 2;
            }

            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex15(string msg)
        {
            /*
             * 15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
             * ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
             * Considerar nota 7,0 como mínima para aprovação.
             */
            Console.WriteLine(msg);

            string status;
            double mediaPond;
            // Vetores
            double[] notas = new double[4];
            int[] w = { 2, 1, 2, 4 };

            for (int i = 0, j = 1; i <= 3 && j <= 4; i++, j++)
            {
                Console.WriteLine($"Insira a {j}º nota:");
                notas[i] = double.Parse(Console.ReadLine());
            }

            mediaPond = (notas[0] * w[0] + notas[1] * w[1] + notas[2] * w[2] + notas[3] * w[3]) / (w[0] + w[1] + w[2] + w[3]);

            if (mediaPond >= 7.0)
                status = "Aprovado";
            else status = "Reprovado";

            Console.WriteLine("----------------------------");
            Console.WriteLine(status);
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex16(string msg)
        {
            /*
             * 16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
             * na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
             * enfrentar novamente em um novo jogo.
             * ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
             * ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
             * plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.
             */
            Console.WriteLine(msg);

            int placarCasa, placarFora;

            for (int i = 1; true; i++)
            {
                Console.Write($"Insira o placar do {i}º jogo - Time da casa: ");
                placarCasa = int.Parse(Console.ReadLine());

                Console.Write($"Insira o placar do {i}º jogo - Time de fora: ");
                placarFora = int.Parse(Console.ReadLine());

                if (placarFora - placarCasa >= 2)
                {
                    Console.WriteLine("O time de fora já se classificou para a próxima fase");
                    break;
                }
                else
                {
                    Console.WriteLine("Os dois times se enfrentarão em um novo jogo");
                    Console.WriteLine("----------------------------");
                    continue;
                }
            }
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex17(string msg)
        {
            /*
             * 17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados,
             * formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
             * os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).
             */
            Console.WriteLine(msg);

            double a, b, c;
            bool verificaTriangulo;

            Console.WriteLine("Insira o lado A do triangulo:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado B do triangulo:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado C do triangulo:");
            c = double.Parse(Console.ReadLine());

            verificaTriangulo = a + b > c && a + c > b && b + c > a;

            if (verificaTriangulo)
            {
                Console.WriteLine("----------------------------");
                if (a == b && b == c)
                    Console.WriteLine("Os lados formam um triângulo equilátero");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Os lados formam um triângulo isósceles");
                else if (a != b && b != c)
                    Console.WriteLine("Os lados formam um triângulo escaleno");
                Console.WriteLine("----- Fim do Exercicio -----\n");
            }
            else
            {
                Console.WriteLine("Os lados não formam um triângulo.");
                Console.WriteLine("----- Fim do Exercicio -----\n");
            }
        }

        static void ex18(string msg)
        {
            Console.WriteLine(msg);

            double[] vals = new double[3];
            int maiorVal = 0;

            for (int i = 1; i < 3; i++)
            {
                Console.Write($"Valor {i}: ");
                vals[i] = double.Parse(Console.ReadLine());

                for (int j = 1; j < 3; j++)
                    if (vals[j] > maiorVal)
                        maiorVal = (int)vals[j];
            }
            
            Console.WriteLine("----------------------------");
            Console.WriteLine($"O maior valor entre os valores informados é {maiorVal}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex19(string msg)
        {
            // 19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.
            Console.WriteLine(msg);

            double[] vals = new double[3];
            int maiorVal = 0;

            for (int i = 1; i < 3; i++)
            {
                Console.Write($"Valor {i}: ");
                vals[i] = double.Parse(Console.ReadLine());

                for (int j = 1; j < 3; j++)
                    if (vals[j] > maiorVal)
                        maiorVal = (int)vals[j];
            }

            Array.Sort(vals);

            Console.WriteLine("----------------------------");

            Console.WriteLine($"Valores digitados:");

            /*
             * Foreach
             * Em vez de usar o for decidi usar o foreach por ser mais prático
             * Ele pega um valor de um vetor ou um array
             * - Crie uma variavel e depois use o in e color o vetor ou array
             * Exemplo:
             * Foreach (string item in items) {}
             */
            foreach (double val in vals)
            {
                Console.WriteLine(val);
            }


            Console.WriteLine("----------------------------");
            Console.WriteLine($"O maior valor entre os valores informados é {maiorVal}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }

        static void ex20(string msg)
        {
            /*
             * 20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
             * plus: você pode gerar o número de forma randomica (função random c#).
             */
            Console.WriteLine(msg);
            /* Radom
             * Gera um número aleatório
             */
            Random random = new Random();
            int tentativas = 3, tentativa, nS = random.Next(1, 100); // Gera um número aleatório entre 1 e 100

            Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
            Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");

            for (int i = 1; i <= tentativas; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Você tem {tentativas} tentativas.");
                Console.WriteLine($"{i}º Tentativa:");
                tentativa = int.Parse(Console.ReadLine());

                if (tentativa == nS)
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Parabéns! Você acertou o número secreto.");
                    Console.WriteLine("----- Fim do Exercicio -----\n");
                    break;
                }
                else if (tentativa < nS)
                    Console.WriteLine("É maior.");
                else
                    Console.WriteLine("É menor.");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Você esgotou suas tentativas.\n" +
                "O número secreto era: " + nS);
            Console.WriteLine("----- Fim do Exercicio -----\n");

        }

        static void ex21(string msg)
        {
            /*
             * 21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada (metros, centímetros, polegadas ou pés) e uma unidade de 
             * medida de saída usando um menu com o comando switch case. O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse 
             * valor para a unidade de saída selecionada.
             */
            Console.WriteLine(msg);

            int input, output;
            string unidade = "";
            double val, convert = 0;
            
            Console.WriteLine("Insira um medida de entrada: (Número)\n" +
            "1 = 1. Metros\n" +
            "2 = 2. Centímetros\n" +
            "3 = 3. Polegadas\n" +
            "4 = 4. Pés");
            input = int.Parse(Console.ReadLine());

            Console.Write("\n");

            Console.WriteLine("Insira um medida de saída: (Número)\n" +
            "1 = 1. Metros\n" +
            "2 = 2. Centímetros\n" +
            "3 = 3. Polegadas\n" +
            "4 = 4. Pés");
            output = int.Parse(Console.ReadLine());

            Console.Write("\n");

            Console.WriteLine("Insira o valor para conversão:");
            val = double.Parse(Console.ReadLine());
            switch (input) { // Entrada
                case 1: // Metros
                    switch (output) // Saida
                    {
                        case 1:
                            convert = val;
                            unidade = "Metros";
                            break;
                        case 2:
                            convert = val * 100;
                            unidade = "Centímetros";
                            break;
                        case 3:
                            convert = val * 39.37;
                            unidade = "Polegadas";
                            break;
                        case 4:
                            convert = val * 3.281;
                            unidade = "Pés";
                            break;
                    }
                    break;
                case 2: // Centímetro
                    switch (output)
                    {
                        case 1: 
                            convert = val / 100;
                            unidade = "Metros";
                            break;
                        case 2:
                            convert = val;
                            unidade = "Centímetros";
                            break;
                        case 3:
                            convert = val / 2.54;
                            unidade = "Polegadas";
                            break;
                        case 4:
                            convert = val / 30.48;
                            unidade = "Pés";
                            break;
                    }
                    break;
                case 3: // Polegadas
                    switch (output)
                    {
                        case 1:
                            convert = val / 39.37;
                            unidade = "Metros";
                            break;
                        case 2:
                            convert = val * 2.54;
                            unidade = "Centímetros";
                            break;
                        case 3:
                            convert = val;
                            unidade = "Polegadas";
                            break;
                        case 4:
                            convert = val / 12;
                            unidade = "Pés";
                            break;
                    }
                    break;
                case 4: // Pés
                    switch (output)
                    {
                        case 1:
                            convert = val / 3.281;
                            unidade = "Metros";
                            break;
                        case 2:
                            convert = val * 30.48;
                            break;
                        case 3:
                            convert = val * 12;
                            unidade = "Polegadas";
                            break;
                        case 4:
                            convert = val;
                            unidade = "Pés";
                            break;
                    }
                    break;
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Resultado da Conversão: {convert} {unidade}");
            Console.WriteLine("----- Fim do Exercicio -----\n");
        }
    }
}