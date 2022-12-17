using System;
using System.Collections.Generic;
using System.Text;

namespace CashIn_Class
{
  class CashIn
  {
    public int sumCashBYN;
    public int bill20BYN;
    public int bill50BYN;
    public int bill100BYN;
    public int sumCashUSD;
    public int bill20USD;
    public int bill50USD;
    public int bill100USD;
    public int sumCashEUR;
    public int bill20EUR;
    public int bill50EUR;
    public int bill100EUR;

    public CashIn()
    {
      bill20BYN = bill50BYN = bill100BYN = 10;
      sumCashBYN = (bill20BYN * 20) + (bill50BYN * 50) + (bill100BYN * 100);
      bill20USD = bill50USD = bill100USD = 10;
      sumCashUSD = (bill20USD * 20) + (bill50USD * 50) + (bill100USD * 100);
      bill20EUR = bill50EUR = bill100EUR = 10;
      sumCashEUR = (bill20EUR * 20) + (bill50EUR * 50) + (bill100EUR * 100);

    }

    public CashIn(int bill20, int bill50, int bill100)
    {
      this.bill20BYN = bill20;
      sumCashBYN += 20 * this.bill20BYN;
      this.bill50BYN = bill50;
      sumCashBYN += 50 * this.bill50BYN;
      this.bill100BYN = bill100;
      sumCashBYN += 100 * this.bill100BYN;
      this.bill20USD = bill20;

      sumCashUSD += 20 * this.bill20USD;
      this.bill50USD = bill50;
      sumCashUSD += 50 * this.bill50USD;
      this.bill100USD = bill100;
      sumCashUSD += 100 * this.bill100USD;

      this.bill20EUR = bill20;
      sumCashEUR += 20 * this.bill20EUR;
      this.bill50EUR = bill50;
      sumCashEUR += 50 * this.bill50EUR;
      this.bill100EUR = bill100;
      sumCashEUR += 100 * this.bill100EUR;      
    }

    public void AddCashIn(int bill20, int bill50, int bill100, string ccyr)
    {
      switch (ccyr.ToUpper())
      {
        case "BYN":
          bill20BYN += bill20;
          sumCashBYN += 20 * bill20;
          bill50BYN += bill50;
          sumCashBYN += 50 * bill50;
          bill100BYN += bill100;
          sumCashBYN += 100 * bill100;
          break;
        case "USD":
          bill20USD += bill20;
          sumCashUSD += 20 * bill20;
          bill50USD += bill50;
          sumCashUSD += 50 * bill50;
          bill100USD += bill100;
          sumCashUSD += 100 * bill100;
          break;
        case "EUR":
          bill20EUR += bill20;
          sumCashEUR += 20 * bill20;
          bill50EUR += bill50;
          sumCashEUR += 50 * bill50;
          bill100EUR += bill100;
          sumCashEUR += 100 * bill100;
          break;
        default:
          Console.WriteLine($"Введена не верная валюта!");
          break;
      }
    }

    public bool OutCashIn(int sum, string ccyr)
    {
      bool success;      
      switch (ccyr.ToUpper())
      {
        case "BYN":
          success = sum <= this.sumCashBYN ? true : false;
          return success;
        case "USD":
          success = sum <= this.sumCashUSD ? true : false;
          return success;
        case "EUR":
          success = sum <= this.sumCashEUR ? true : false;
          return success;
        default:
          Console.WriteLine($"Введена не верная валюта!");
          return false;          
      }
    }

    public void PrintCheck(int sum, string ccyr)
    {
      int countOutBill20 = 0;
      int countOutBill50 = 0;
      int countOutBill100 = 0;      
      int sumOut = sum;      

      switch (ccyr.ToUpper())
      {
        case "BYN":
          while (countOutBill100 < this.bill100BYN && (sum - 100) >= 0)
          {
            sum -= 100;
            countOutBill100++;
          }

          while (countOutBill50 < this.bill50BYN && (sum - 50) >= 0)
          {
            sum -= 50;
            countOutBill50++;
          }

          while (countOutBill20 < this.bill20BYN && ((sum - 20) >= 0))
          {
            sum -= 20;
            countOutBill20++;
          }

          if (sum > 0)
            Console.WriteLine("Введите сумму кратную 100, 50 или 20.");
          else if (sum == 0)
          {
            Console.WriteLine($"Выдана сумма: {sumOut.ToString()} {ccyr.ToUpper()}\nКоличество выданных купюр:\n" +
                              $"100 {ccyr} - {countOutBill100.ToString()}\n50 {ccyr} - {countOutBill50.ToString()}\n" +
                              $"20 {ccyr} - {countOutBill20.ToString()}\n");
            this.sumCashBYN -= sumOut;
            this.bill100BYN -= countOutBill100;
            this.bill50BYN -= countOutBill50;
            this.bill20BYN -= countOutBill20;
          }
          break;
        case "USD":
          while (countOutBill100 < this.bill100USD && (sum - 100) >= 0)
          {
            sum -= 100;
            countOutBill100++;
          }

          while (countOutBill50 < this.bill50USD && (sum - 50) >= 0)
          {
            sum -= 50;
            countOutBill50++;
          }

          while (countOutBill20 < this.bill20USD && ((sum - 20) >= 0))
          {
            sum -= 20;
            countOutBill20++;
          }

          if (sum > 0)
            Console.WriteLine("Введите сумму кратную 100, 50 или 20.");
          else if (sum == 0)
          {
            Console.WriteLine($"Выдана сумма: {sumOut.ToString()} {ccyr.ToUpper()}\nКоличество выданных купюр:\n" +
                              $"100 {ccyr} - {countOutBill100.ToString()}\n50 {ccyr} - {countOutBill50.ToString()}\n" +
                              $"20 {ccyr} - {countOutBill20.ToString()}\n");
            this.sumCashUSD -= sumOut;
            this.bill100USD -= countOutBill100;
            this.bill50USD -= countOutBill50;
            this.bill20USD -= countOutBill20;
          }
          break;
        case "EUR":
          while (countOutBill100 < this.bill100EUR && (sum - 100) >= 0)
          {            
            sum -= 100;
            countOutBill100++;
          }

          while (countOutBill50 < this.bill50EUR && (sum - 50) >= 0)
          {            
            sum -= 50;
            countOutBill50++;
          }

          while (countOutBill20 < this.bill20EUR && ((sum - 20) >= 0))
          {            
            sum -= 20;
            countOutBill20++;
          }

          if (sum > 0)
          {
            Console.WriteLine("Введите сумму кратную 100, 50 или 20.");
          }
          else if (sum == 0)
          {
            Console.WriteLine($"Выдана сумма: {sumOut.ToString()} {ccyr.ToUpper()}\nКоличество выданных купюр:\n" +
                              $"100 {ccyr} - {countOutBill100.ToString()}\n50 {ccyr} - {countOutBill50.ToString()}\n" +
                              $"20 {ccyr} - {countOutBill20.ToString()}\n");
            this.sumCashEUR -= sumOut;
            this.bill100EUR -= countOutBill100;
            this.bill50EUR -= countOutBill50;
            this.bill20EUR -= countOutBill20;
          }
          break;
        default:
          Console.WriteLine($"Введена не верная валюта!");
          break;
      }
    }

    public bool PrintInfo(string ccyr)
    {      
      switch (ccyr.ToUpper())
      {
        case "BYN":
          Console.WriteLine($"Максимальная сумма снятия: {this.sumCashBYN} BYN\nНаличие купюр в банкомате:\n" +
            $"100 BYN - {this.bill100BYN.ToString()}\n50 BYN - {this.bill50BYN.ToString()}\n" +
            $"20 BYN - {this.bill20BYN.ToString()}\n");
          return true;     
        case "USD":
          Console.WriteLine($"Максимальная сумма снятия: {this.sumCashUSD} USD\nНаличие купюр в банкомате:\n" +
                      $"100 USD - {this.bill100USD.ToString()}\n50 USD - {this.bill50USD.ToString()}\n" +
                      $"20 USD - {this.bill20USD.ToString()}\n");
          return true;
        case "EUR":
          Console.WriteLine($"Максимальная сумма снятия: {this.sumCashEUR} EUR\nНаличие купюр в банкомате:\n" +
                      $"100 EUR - {this.bill100EUR.ToString()}\n50 EUR - {this.bill50EUR.ToString()}\n" +
                      $"20 EUR - {this.bill20EUR.ToString()}\n");
          return true;
        default:
          Console.WriteLine($"Введена не верная валюта!\n");
          return false;
      }
    }
  }
}
