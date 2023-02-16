using System.Globalization;

namespace ExercicioFixacao
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.Write("Qual é cotação do dólar? ");
      double cotacao = double.Parse(Console.ReadLine());

      System.Console.Write("Quantos dólares você vai comprar? ");
      double quantia = double.Parse(Console.ReadLine());
      double valorAPagar = ConversorDeMoeda.ComprarDolares(cotacao, quantia);

      System.Console.WriteLine($"Valor a ser pago em reais = {valorAPagar.ToString("F2", CultureInfo.InvariantCulture)}");
    }
  }
}