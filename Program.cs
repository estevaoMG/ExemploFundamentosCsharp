﻿using ExemploFundamentos.Models;



Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Estevão";
pessoa1.Idade = 30;
pessoa1.Apresentar();
































// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//         Console.WriteLine("Cadastro de cliente");
//         break;

//         case "2":
//         Console.WriteLine("Busca de cliente");
//         break;

//         case "3":
//         Console.WriteLine("Apagar cliente");
//         break;

//         case "4":
//         Console.WriteLine("Encerrar");
//         exibirMenu = false;
//         //Environment.Exit(0);
//         break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// Console.WriteLine("O programa se encerrou");



























// int soma = 0, numero = 0;


// do
// {
//     Console.WriteLine("Digite um número (0 para parar):");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");
































// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($" {contador}° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }








































// int numero = 5;



// for(int contador = 0; contador <= 10000; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }































// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Incrementando o 10");
// // numero = numero + 1;
// numeroIncremento++;
// Console.WriteLine(numeroIncremento);


// int numeroDecremento = 20;
// Console.WriteLine(numeroDecremento);
// Console.WriteLine("Decrementando o 20");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);



















// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar!");
// }
// else
// {
//     Console.WriteLine("Vou pedalar num outro dia!");
// }































// bool possuiPresencaMinima = true;
// double media = 8.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }































// bool ehMaiorDeIdade = false;
// bool possuiAltorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAltorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada!");
// }






























// Console.WriteLine("Digite uma letra:");
// string? letra = Console.ReadLine();


// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal!");
//         break;
    
//     default:
//         Console.WriteLine("Não é uma vogal!");
//         break;
// }






























// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal!");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal!");
// }






























// if (letra == "a")
// {
//     Console.WriteLine("Vogal!");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal!");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal!");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal!");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal!");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal!");
// }














// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}!");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida!");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }

























// int a = 5;
// double b = a;

// Console.WriteLine(b);

























// string a = 5;
// Console.WriteLine(a);









// int a = Convert.ToInt32("5");
// int a = Convert.ToInt32(null);
// int a = int.Parse(null);

// Console.WriteLine(a);


















// int a = 10;
// int b = 20;

// int c = a + b;

// c = c + 5;

// c += 5;

// c *= 5;

// Console.WriteLine(c);














// int a = 0;
// int b = 0;

// int c = a+b;

// Console.WriteLine(c);









// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));




// string apresentacao = "Olá! Seja bem-vindo!";





// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);





// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preço: " + preco);
// Console.WriteLine("Valor da variável condição: " + condicao);


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Estevão";
// pessoa1.Idade = 30;
// pessoa1.Apresentar();