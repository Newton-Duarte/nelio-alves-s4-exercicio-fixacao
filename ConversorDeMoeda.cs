class ConversorDeMoeda
{
  const double IOF = 6.00;

  public static double ComprarDolares(double cotacao, double quantia)
  {
    double total = quantia * cotacao;
    return total + total * IOF / 100.0;
  }
}