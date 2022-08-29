// See https://aka.ms/new-console-template for more information
double anoNascimento, anoAtual, idade;

Console.Write("Digite o ano de nascimento: ");
anoNascimento = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o ano atual: ");
anoAtual = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

idade = anoAtual - anoNascimento;

Console.WriteLine("A idade é: " + idade);
Console.ReadKey();