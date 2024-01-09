//escreva um programa para ler 2 valores (considere que serão valores diferentes) e escreva o maior deles.



Console.WriteLine("Informe o primeiro valor:");
int num1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o segundo valor:");
int num2= Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("O maior valor informado é " +num1);
}
else
{
    Console.WriteLine("O maior valor informado é " +num2);
}