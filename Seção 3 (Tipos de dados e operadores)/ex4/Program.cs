//Escreva um programe que calcule a média de um aluno,
//a quantidade de notas não deverão ser limitadas, o usuário do programa 
//deverá escolher a quantidade de notas a serem calculadas.

Console.WriteLine("");
Console.WriteLine("Informe a quantidade de notas a serem calculadas:");
int numnotas = Convert.ToInt16(Console.ReadLine());
double soma = 0;

for (int i = 1; i <= numnotas; i++)
{
    Console.WriteLine("------------");
    Console.WriteLine($"Informe a nota {i}:");
    double nota = Convert.ToDouble(Console.ReadLine());
    soma += nota;
}

Console.WriteLine("");
Console.WriteLine($"A média do aluno foi: {soma/numnotas}");
