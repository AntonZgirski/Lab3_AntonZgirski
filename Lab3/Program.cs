using System;

namespace Lab3
{
  class Program
  {
    static void Main(string[] args)
    {
      var mother = new Phone
      {
        number = "+375-29-123-45-67",
        model = "Samsung",
        weight = 800.00
      };

      var dad = new Phone();
      dad.number = "+375-29-765-43-21";
      dad.model = "IPhone";
      dad.weight = 867.12;

      var son = new Phone();
      son.number = "+375-29-547-36-38";
      son.model = "Nokia";
      son.weight = 925.12;

      mother.Print();
      dad.Print();
      son.Print();

      mother.RecieveCall("Mother");
      dad.RecieveCall("Dad");
      son.RecieveCall("Son");
      
      mother.RecieveCall("Mother",mother.GetNumber());
      dad.RecieveCall("Dad", dad.GetNumber());
      son.RecieveCall("Son", son.GetNumber());

      Console.WriteLine();

      var message = new Phone();
      message.SendMessage(mother.GetNumber(), dad.GetNumber(), son.GetNumber());
            
      //Console.WriteLine(mother.GetNumber()); 
      //Console.WriteLine(dad.GetNumber());
      //Console.WriteLine(son.GetNumber());
    }
  }
  class Phone
  {
    public string number;
    public string model;
    public double weight;
    public void Print()
    {
      Console.WriteLine($"Number: {number}. Model: {model}. Weight: {weight} gram.");
    }
    public void RecieveCall(string name)
    {
      Console.WriteLine($"Calling {name}.");
    }
    public void RecieveCall(string name, string number)
    {
      Console.WriteLine($"Calling {name}. Number {number}.");
    }
    public string GetNumber()
    {
      return number;
    }
    public void SendMessage(params string[] elem)
    {
      foreach(var el in elem)
      {
        Console.WriteLine(el);
      }
    }
  }
}
