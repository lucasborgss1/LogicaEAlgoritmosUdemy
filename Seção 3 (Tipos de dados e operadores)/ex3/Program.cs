//escreva um programa que leia o preço de um determinado produto e
//calcule seu valor de venda acrescentando 25% do seu valor.
//Mostrar o produto e o valor do produto.

Console.WriteLine("");
Console.WriteLine("Informe o produto:");
string produto = Console.ReadLine();

Console.WriteLine("Informe o valor do produto:");
double valor = Convert.ToDouble(Console.ReadLine());
double taxa = valor + (valor * 0.25);


Console.WriteLine($"O produto {produto} custa {taxa} reais.");