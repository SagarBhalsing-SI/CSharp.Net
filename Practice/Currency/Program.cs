namespace Currency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Currency c1 = new Currency();
            List<double> number = new List<double> { 10.10, 15.5, 30.2 };
            c1.DisplayCurrency(number, c1.FormatCurrency);
            c1.DisplayCurrency(number, c1.PercentageCurrency);
        }
    }
}