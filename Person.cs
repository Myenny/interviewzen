using System;

public class Person
{
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public int Age { get; set; }
  public int HealthPlanId { get; set; }
  public Person(string firstName, string lastName, int age, int id)
  {
    FirstName = firstName;
    LastName = lastName;
    Age = age;
    HealthPlanId = id;
  }
  // Other properties, methods, events...
}

class Client
{
  static void Main()
  {
    Person client1 = new Person("Leopold", "Strong", 6, 13389);
    Console.WriteLine("client1 First Name = {0} client1 Last Name = {1} Age = {2} client1 id = {3}", client1.FirstName, client1.LastName, client1.Age, client1.HealthPlanId);

  }
}
