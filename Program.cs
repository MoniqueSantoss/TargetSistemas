using System;

class Program
{
	static void Main()
	{
		while (true)
		{
			Console.WriteLine("Escolha uma opção:");
			Console.WriteLine("1 - Soma de Índices");
			Console.WriteLine("2 - Verificar Fibonacci");
			Console.WriteLine("3 - Análise de Faturamento JSON");
			Console.WriteLine("4 - Distribuição Percentual ");
			Console.WriteLine("5 - Inverta uma string");
			Console.WriteLine("6 - Sair");
			Console.Write("Opção: ");

			string opcao = Console.ReadLine();

			switch (opcao)
			{
				case "1":
					DesafioSoma.Executar();
					break;
				case "2":
					DesafioFibonacci.Executar();
					break;
				case "3":
					DesafioFaturamentoJson.Executar();
					break;
				case "4":
					DesafioPercentual.Executar();
					break;
				case "5":
					DesafioInverterString.Executar();
					break;
				case "6":
					Console.WriteLine("Saindo do programa...");
					return;
				default:
					Console.WriteLine("Opção inválida.");
					break;
			}

			Console.WriteLine("\nPressione ENTER para continuar...");
			Console.ReadLine();
			Console.Clear();
		}
	}
}
