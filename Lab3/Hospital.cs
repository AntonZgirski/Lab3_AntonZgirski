using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Class
{
  class Hospital
  {
    public Surgeon surgeon;
    public Dentist dentist;
    public Therapist therapist;
    public Patient patient;
    public Plan plan;
    public Hospital()
    {
      surgeon = new Surgeon();
      dentist = new Dentist();
      therapist = new Therapist();
      patient = new Patient();
      plan = new Plan();
    }
  }

  class Surgeon
  {
    public void Treat(string name)
    {
      Console.WriteLine($"Пациенту {name} необходимо провести операцию.");
    }
  }
  class Dentist
  {
    public void Treat(string name)
    {
      Console.WriteLine($"Пациенту {name} необходимо поставить пломбу.");
    }
  }

  class Therapist
  {
    public void Treat(string name)
    {
      Console.WriteLine($"Пациенту {name} необходимо выпесать рецепт.");
    }
  }

  class Patient
  {
    public string name;
    public void EnterName(string name)
    {
      this.name = name;
    }
  }

  class Plan
  {
    public void Treat()
    {
      var patient = new Patient();
      Console.WriteLine("Введите имя пациента: ");
      patient.EnterName(Console.ReadLine());
      int code;
      Console.WriteLine("Введите код лечения:");
      code = Convert.ToInt32(Console.ReadLine());
      switch (code)
      {
        case 1:
          var doctor = new Surgeon();
          doctor.Treat(patient.name);
          break;
        case 2:
          var doctor1 = new Dentist();
          doctor1.Treat(patient.name);
          break;
        default:
          var doctor2 = new Therapist();
          doctor2.Treat(patient.name);
          break;
      }
    }
  }  
}
