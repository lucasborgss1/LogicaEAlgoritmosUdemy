//Faça um programa, utilizando for que peça ao usuário um número que ele deseja efetuar
//a tabuada, já o segundo número que o usuário digitar será a quantidade de vezes que a 
//tabuada será calculada.

Console.WriteLine("Informe o número que deseja ver a tabuada:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantos múltiplos?");
int tabuada = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

for (int i = 0; i < tabuada; i++)
{
    int mult = (num * i);
    Console.WriteLine("{0} x {1} = {2}", num, i, mult);
}
