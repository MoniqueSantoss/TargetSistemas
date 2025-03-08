using System;// possui os comandos basicos de entrada e saida

class DesafioFibonacci
{
	public static void Executar()
	{

		Console.Write("\nDigite um número para verificar se pertence à sequência de Fibonacci: ");
		int numero = int.Parse(Console.ReadLine());

		if (Fibonacci(numero))
		{
			Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
		}
		else
		{
			Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
		}

		static bool Fibonacci(int num)
		{
			int num1 = 0, num2 = 1, soma = 0;

			while (soma < num)
			{
				soma = num1 + num2;
				num1 = num2;
				num2 = soma;
			}

			return soma == num || num == 0; // Se soma for igual ao número, ele pertence
		}

	}
} 

