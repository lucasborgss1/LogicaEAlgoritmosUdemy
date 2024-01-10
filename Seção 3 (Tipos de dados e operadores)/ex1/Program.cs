//escreva um programa que some 2 números digitados pelo 
//usuário e depois divida por 2, mostre o resultado da soma 
//entre os dois números e o resultado da divisão.


Console.WriteLine("Digite o 1° valor:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o 2° valor :");
double num2 = Convert.ToDouble(Console.ReadLine());

double soma = num1 + num2 ;
double divisão = soma / 2;

Console.WriteLine("Resultado da soma {1} + {2} é: {0}", soma, num1, num2);
Console.WriteLine("Resultado da divisão {1}/ 2 é: {0}", divisão, soma);
