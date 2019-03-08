using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

  public class program
  {
    static void Main(string[] args)
    {
      DerivedClass derived = new DerivedClass("Hello", 4, 5);
      Console.WriteLine(derived.GetResults());
    }
  }
  public class BaseClass
  {

    protected string Config1 { get; set; }

    protected int Config2 { get; set; }



    public BaseClass(string config1, int config2)
    {

      Config1 = config1;

      Config2 = config2;

    }



    public virtual string GetResults()
    {

      return Config1 + Config2;

    }

  }
  class DerivedClass : BaseClass
  {
    private int Repetitions { get; set; }

    public DerivedClass(string config1, int config2, int repetitions) : base(config1, config2)//constructor to pass values to base
    {

      Repetitions = repetitions;
      Config1 = config1;

      Config2 = config2;

    }


    public override string GetResults()//override method
    {
      string result = "";
      for (int i = 0; i < Repetitions; i++)
      {
        if (i == Repetitions - 1)//check for the last comma to be inserted

          result = result + base.GetResults();//getting data from base class
        else
          result = result + base.GetResults() + ",";//getting data from base class

      }
      return result;

    }
  }
}

