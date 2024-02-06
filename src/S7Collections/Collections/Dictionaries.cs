using S7Collections.Models;

namespace S7Collections.Collections;

public class Dictionaries
{
    public static void DictionariesMain()
    {
        // Dictionary initialization
        Dictionary<int, string> myDictionary = new Dictionary<int, string>(){
            {1, "one"},
            {2, "two"},
            {3, "three"}
        };
        
        Employee[] employees =
        {
            new Employee("CEO", "Gwyn", 95, 200),
            new Employee("Manager", "Joe", 35, 25),
            new Employee("HR", "Lora", 32, 21),
            new Employee("Secretary", "Petra", 28, 18),
            new Employee("Lead Developer", "Artorias", 55, 35),
            new Employee("Intern", "Ernest", 22, 8)
        };

        Dictionary<string, Employee> employeesDictionary = new Dictionary<string, Employee>();
        foreach (Employee emp in employees)
        {
            employeesDictionary.Add(emp.Role, emp);
        }

        Employee ceo = employeesDictionary["CEO"];
        ceo.PrintData();
        
        // Safer Way of Retrieval: ContainsKey
        string key = "CEO";
        if (employeesDictionary.ContainsKey(key))
        {
            Employee tmp = employeesDictionary[key];
            tmp.PrintData();
        }
        else
        {
            Console.WriteLine("The key does not exist...");
        }
        
        // Safest Way of Retrieval: TryGetValue()
        Employee result = null;
        if (employeesDictionary.TryGetValue("Intern", out result))
        {
            result.PrintData();
        }
        else
        {
            Console.WriteLine("The key does not exist...");
        }
        
        // Iterate through KeyValuePair using LINQ
        KeyValuePair<string, Employee> keyValuePair;
        for (int i = 0; i < employeesDictionary.Count; i++)
        {
            keyValuePair = employeesDictionary.ElementAt(i);
            Console.WriteLine($"Key: {keyValuePair.Key}");
            Employee employeeValue = keyValuePair.Value;
            employeeValue.PrintData();
        }
        
        // Update Dictionary
        string keyToUpdate = "HR";
        if (employeesDictionary.ContainsKey(keyToUpdate))
        {
            employeesDictionary[keyToUpdate] = new Employee("HR", "Eleka", 26, 17);
            Console.WriteLine($"Employee with key {keyToUpdate} has been successfully updated...");
        }
        else
        {
            Console.WriteLine($"Error updating key {keyToUpdate}. The key does not exist...");
        }
        
        // Remove Key
        string keyToDelete = "Intern";
        if (employeesDictionary.Remove(keyToDelete))
        {
            Console.WriteLine($"The key {keyToDelete} has been successfully deleted...");
        }
        else
        {
            Console.WriteLine($"Failed to delete key {keyToDelete}.The key does not exist...");
        }
    }
}