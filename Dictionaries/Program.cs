using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO","Gwyn",95,200),
                new Employee("Manager","Jow",35,25),
                new Employee("HR","Lora",32,21),
                new Employee("Secretary","Petra",28,18),
                new Employee("Lead Developer","Artorias",55,35),
                new Employee("Intern","Ernest",22,8)
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            string keyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(keyToUpdate))
            {
                employeesDirectory[keyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee with Role/Key {0} was updated!", keyToUpdate);
            }
            else
            {
                Console.WriteLine("No employee found with this key: {0}", keyToUpdate);

            }

            // remove

            string keyToRemove = "Intern";
            if (employeesDirectory.ContainsKey(keyToRemove))
            {
                employeesDirectory.Remove(keyToRemove);
                Console.WriteLine("Employee with Role/Key {0} was removed!", keyToRemove);
            }
            else
            {
                Console.WriteLine("No employee found with this key: {0}", keyToUpdate);

            }

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                Console.WriteLine("Key: {0}, i is {1}", keyValuePair.Key, i);
                Employee employeeValue = keyValuePair.Value;

                Console.WriteLine("Employee name: {0}", employeeValue.Name);
                Console.WriteLine("Employee role: {0}", employeeValue.Role);
                Console.WriteLine("Employee age: {0}", employeeValue.Age);
                Console.WriteLine("Employee salary: {0}", employeeValue.Salary);
            }

            string key = "CEO";

            if (employeesDirectory.ContainsKey(key))
            {
                Employee emp1 = employeesDirectory[key];
                Console.WriteLine("Employee name: {0}, Role: {1}, Salary: {2}", emp1.Name, emp1.Role, emp1.Salary);
            }
            else
            {
                Console.WriteLine("This key does not exist Key:{0}", key);
            }

            Employee result = null;

            if(employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value retrieved!");

                Console.WriteLine("Employee name: {0}", result.Name);
                Console.WriteLine("Employee role: {0}", result.Role);
                Console.WriteLine("Employee age: {0}", result.Age);
                Console.WriteLine("Employee salary: {0}", result.Salary);
            }
            else
            {
                Console.WriteLine("The key does not exist");
            }



            Console.Read();
        }
    }
}
