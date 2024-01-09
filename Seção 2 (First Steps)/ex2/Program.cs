//Escreva um programa que verifique a validade de uma senha fornecida pelo usuário. A senha válida 
//é o número 1234. Devem impressas as seguintes mensagens: 
//
//SENHA VALIDA caso a senha seja válida.
//SENHA INVALIDA caso a senha seja inválida.

int senha = 1234;

Console.WriteLine("Informe a senha:");
int senhainformada = Convert.ToInt32(Console.ReadLine());

if (senha == senhainformada)
{
    Console.WriteLine("SENHA VÁLIDA");
}
else
{
    Console.WriteLine("SENHA INVÁLIDA");
}