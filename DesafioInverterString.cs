using System;// possui os comandos basicos de entrada e saida

class DesafioInverterString
{
	public static void Executar()
	{
		Console.Write("\nDigite uma palavra ou frase para fazer a conversão: ");
		string variavel = Console.ReadLine();

		for (int i = variavel.Length - 1; i >= 0; i--)
		{

			Console.Write(variavel[i]);

		}

	}
}

