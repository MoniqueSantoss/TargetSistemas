using System;// possui os comandos basicos de entrada e saida
using System.Text.Json;

class DesafioFaturamentoJson
{
	public class DiaValor
	{
		public int dia { get; set; }
		public decimal valor { get; set; }
	}

	public static void Executar()
	{
		// Caminho para o arquivo JSON (pode ser substituído com seu próprio caminho)
		string caminhoArquivo = @"C:\Unip\c#\ConsoleAula02_Operadores\dados.json";
		decimal totalFaturamento = 0;
		int totalDias = 0;
		decimal media = 0;
		int quantidade = 0;
		int quantidadeDias = 0;
		decimal maior = 0;
		decimal menor = decimal.MaxValue;

		try
		{
			// Lê o conteúdo do arquivo JSON
			string json = File.ReadAllText(caminhoArquivo);

			// Desserializa o JSON para uma lista de objetos DiaValor
			List<DiaValor> dados = JsonSerializer.Deserialize<List<DiaValor>>(json);

			// Exibe os dados lidos
			foreach (var item in dados)
			{
				//Console.WriteLine($"Dia {item.dia}: R$ {item.valor:N2}");
				totalFaturamento += item.valor;
				totalDias += item.dia;

				if (item.valor > maior)
				{
					maior = item.valor;
				}

				if (item.valor > 0 && item.valor < menor)
				{
					menor = item.valor;
				}

				if (item.valor > 0)
				{
					quantidade++;
				}

				media = quantidade > 0 ? totalFaturamento / quantidade : 0;

				if (item.valor > media)
				{
					quantidadeDias++;
				}

			}

			Console.WriteLine($"\nFaturamento mensal distribuidora: R$ {totalFaturamento:n2}");
			Console.WriteLine($"O maior valor de faturamento ocorrido em um dia do mês : R$ {maior:n2}");
			Console.WriteLine($"O menor valor de faturamento ocorrido em um dia do mês : R$ {menor:n2}");
			Console.WriteLine($"Media mensal : {media:n2}");
			Console.WriteLine("Número de dias no mês em que o valor de faturamento diário foi superior à média mensal: " + quantidadeDias);

		}
		catch (Exception ex)
		{
			Console.WriteLine("Erro ao ler ou desserializar o arquivo: " + ex.Message);
		}
	}
}