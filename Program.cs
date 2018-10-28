using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Homework
{
    class MainClass
    {
    public static void Main(string[] args)
        {
            List<Person> PersonList = new List<Person>();
            PersonList.Add(new Person("Иван",31,"Male",400));
            PersonList.Add(new Person("Женя",24,"Male",21000));
            PersonList.Add(new Person("Даша",22,"Famale",570));
            PersonList.Add(new Person("Леша",25,"Male",14758));
            PersonList.Add(new Person("Соня",27,"Famale",4792));
            
            var selectedPerson1 = PersonList.OrderByDescending(x => x.Age).FirstOrDefault();
            Console.WriteLine($"Самый старший: {selectedPerson1.Name}");
            
            var selectedPerson2 = PersonList.OrderByDescending(x => x.Balance).FirstOrDefault();
            Console.WriteLine($"Самый богатый: {selectedPerson2.Name}");
            
            var CountPerson = PersonList.Where(x => x.Balance>4000).Count();
            Console.WriteLine($"Кол-во людей, у которых баланс выше 4000: {CountPerson}");
            
            Console.WriteLine("------------------------");
            Console.WriteLine("Сортировка по возрасту:");
            var selectedPerson3 = PersonList.OrderBy(x => x.Age);
            foreach (Person p in selectedPerson3)
            {
             Console.WriteLine($"{p.Name},{p.Age},{p.Sex},{p.Balance}");   
            }
            
            Console.WriteLine("------------------------");
            Console.WriteLine("Сортировка по полу:");
            var selectedPerson4 = PersonList.OrderBy(x => x.Sex);
            foreach (Person p in selectedPerson4)
            {
             Console.WriteLine($"{p.Name},{p.Age},{p.Sex},{p.Balance}");   
            }
            
            Console.WriteLine("------------------------");
            Console.WriteLine("Сортировка по балансу:");
            var selectedPerson5 = PersonList.OrderBy(x => x.Balance);
            foreach (Person p in selectedPerson5)
            {
             Console.WriteLine($"{p.Name},{p.Age},{p.Sex},{p.Balance}");   
            }
        }
    }
    
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public decimal Balance { get; set; }
        
        public Person(string name, int age, string sex, decimal balance)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Balance = balance;
        }
    }
}
