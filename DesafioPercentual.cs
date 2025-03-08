using System;// possui os comandos basicos de entrada e saida

class DesafioPercentual
{
	public static void Executar()
	{
		decimal SP = 67836.43m;
		decimal RJ = 36678.66m;
		decimal MG = 29229.88m;
		decimal ES = 27165.48m;
		decimal Outros = 19849.53m;

		// Soma dos valores
		decimal cemPorcentoValor = SP + RJ + MG + ES + Outros;

		decimal porcetagem_SP = (SP / cemPorcentoValor) * 100;
		decimal porcetagem_RJ = (RJ / cemPorcentoValor) * 100;
		decimal porcetagem_MG = (MG / cemPorcentoValor) * 100;
		decimal porcetagem_ES = (ES / cemPorcentoValor) * 100;
		decimal porcetagem_Outros = (Outros / cemPorcentoValor) * 100;

		Console.WriteLine("\nPercentual de representação que cada estado teve dentro do valor total mensal da distribuidora: \n");
		Console.WriteLine($"São Paulo: {porcetagem_SP:f2}%");
		Console.WriteLine($"Rio de Janeiro: {porcetagem_RJ:f2}%");
		Console.WriteLine($"Minas Gerais: {porcetagem_MG:f2}%");
		Console.WriteLine($"Espirito Santo: {porcetagem_ES:f2}%");
		Console.WriteLine($"Outros: {porcetagem_Outros:f2}%");


		// Exibe o resultado corretamente formatado para moeda
		Console.WriteLine($"Resultado da soma: R$ {cemPorcentoValor:n2}");

	}
}

