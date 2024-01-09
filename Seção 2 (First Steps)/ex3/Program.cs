//Faça um programa utilizando for, que permita que o usuário fazer três contas de soma entre 2 números, e 
//exibir o resultado ao final de cada soma.

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Informe um valor:");
    int num1 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Informe um valor:");
    int num2 = Convert.ToInt16(Console.ReadLine()); 

    int soma = num1 + num2;

    Console.WriteLine("Total da soma: {0}", soma);
    Console.WriteLine("-----------");
}