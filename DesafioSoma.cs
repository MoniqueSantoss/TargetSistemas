using System;

class DesafioSoma
{
	public static void Executar()
	{
		int indice = 13;
		int soma = 0;
		int K = 0;

		while (K < indice)
		{
			K = K + 1;
			soma = soma + K;
		}
		Console.WriteLine("\nResultado: " + soma);
	}
}
