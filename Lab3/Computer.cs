using System;
using System.Collections.Generic;
using System.Text;


namespace Computer_Class
{
  class Computer
  {
    public double price;
    public string model;
    public Ram ram;
    public Hdd hdd;

    public Computer()
    {
      ram = new Ram();
      hdd = new Hdd();
      price = 100.00;
      model = "Macintosh";
    }

    public Computer(double price, string model)
    {
      Console.WriteLine();
      Console.WriteLine("Введите стоимость: ");
      this.price = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Введите модель: ");
      this.model = Console.ReadLine();
      this.ram = new Ram("", 0);
      this.hdd = new Hdd("", 0, "");
    }

    public void Print()
    {
      Console.WriteLine();
      Console.WriteLine($"Стоимость ПК: {String.Format("{0:f2}", this.price)}");
      Console.WriteLine($"Модель ПК: {this.model}");
      ram.Print();
      hdd.Print();
    }
  }

  class Ram
  {
    public string name;
    public int volume;  

    public Ram()
    {
      this.name = "Abc";
      this.volume = 124;
    }

    public Ram(string name, int volume)
    {
      Console.WriteLine("Введите название RAM: ");
      this.name = Console.ReadLine();
      Console.WriteLine("Введите объем RAM: ");
      this.volume = Convert.ToInt32(Console.ReadLine());
    }

    public void Print()
    {
      Console.WriteLine($"Название RAM: {this.name}");
      Console.WriteLine($"Объем RAM: {this.volume.ToString()}");
    }
  }

  class Hdd
  {
    public string name;
    public int volume;
    public string type;

    public Hdd()
    {
      this.name = "Samsung";
      this.volume = 128;
      this.type = "внутренний";
    }

    public Hdd(string name, int volume, string type)
    {
      Console.WriteLine("Введите название HDD: ");
      this.name = Console.ReadLine();
      Console.WriteLine("Введите объем HDD: ");
      this.volume = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Определите тип  HDD(внешний/внутренний): ");
      this.type = Console.ReadLine();
    }    

    public void Print()
    {
      Console.WriteLine($"Название HDD: {this.name}");
      Console.WriteLine($"Объем HDD: {this.volume.ToString()}");
      Console.WriteLine($"Тип HDD: {this.type}");
    }
  }
}