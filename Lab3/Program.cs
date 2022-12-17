using System;
using Computer_Class;
using CashIn_Class;


namespace Lab3
{
  class Program
  {
    static void Main(string[] args)
    {
      //var com1 = new Computer();
      //com1.Print();
      //var com2 = new Computer(0.0, "");
      //com2.Print();

      var cashIn1 = new CashIn();
      cashIn1.AddCashIn(10,10,10,"USD");
      char exit = 'Y';
      Console.WriteLine("Бакномат TeachMeSkills\nДоступыне валюты для снятия денег:\nUSD\nEUR\nBYN\n");
      do
      {
        Console.WriteLine("Выберите валюту: ");
        string ccyr = Console.ReadLine();
        if (!cashIn1.PrintInfo(ccyr)) continue;
        Console.Write("Введите сумму: ");
        int sumOut = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if (cashIn1.OutCashIn(sumOut, ccyr)) cashIn1.PrintCheck(sumOut, ccyr);
        else Console.WriteLine($"В банкомате не достаточно средств для снятия {sumOut.ToString()} {ccyr.ToUpper()}.\n");
        Console.WriteLine($"Выполнить еще одну операцию?(Y,N): ");
        exit = Convert.ToChar(Console.ReadLine());
      } while (exit == 'Y');
    }
  } 
}
