//escreva um programa que mostre todos os números anteriores 
//do número que o usuário digitou, some todos eles e exiba o 
//resultado.

Console.WriteLine("");
Console.WriteLine("*Este programa mostrará todos os números anteriores ao valor indicado e irá somá-los.*");
Console.WriteLine("");

Console.WriteLine("Digite um valor:");
int num = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("-----------");

int soma = 0 ;


for (int i = num - 1; i > 0; i--)
{
    soma += i;
    Console.WriteLine(i);
}
Console.WriteLine("Resultado da soma dos algarismos: "+soma);