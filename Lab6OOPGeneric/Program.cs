//Ludvig Revholm Hedman .Net26
namespace Lab6OOPGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> employees = new Stack<Employee>(); // creates a new stack for class Employee named employees

            Employee employe1 = new Employee(3457, "tara", "f", 34000);// created 5 employee object in the class Employee 
            Employee employee2 = new Employee(2345, "sara", "f", 34000);
            Employee employee3 = new Employee(5667, "hasse", "m", 34000);
            Employee employee4 = new Employee(9347, "bob", "m", 40000);
            Employee employee5 = new Employee(8645, "noah", "m", 34000);

            employees.Push(employe1); //added the objects to the stack 
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);


            Console.WriteLine("-----print-----\n");
            foreach (var emplo in employees)// foreach loop to print all the employees
            {
                Console.WriteLine($"Id:{emplo.Id} \nName: {emplo.Name} \nGender: {emplo.Gender} \nSalary: {emplo.Salary}");
                Console.WriteLine(employees.Count);
            }

            Console.WriteLine("\n-----pop-----\n");
            while (employees.Count > 0)// while loop to be able to pop all the object in the stack and print the employees 
            {
                var emp = employees.Pop();

                Console.WriteLine($"Id:{emp.Id} \nName: {emp.Name} \nGender: {emp.Gender} \nSalary: {emp.Salary}");

                Console.WriteLine(employees.Count);
            }

            employees.Push(employe1); //added the employees back to the stack after geting removed by pop
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            Console.WriteLine("\n-----Peek 2-----\n");
            for(int i = 0; i < 2; i++)// created a for loop to get the top of the stack 2 times useing peek 
            {
                var empPeek = employees.Peek();

                Console.WriteLine($"Id:{empPeek.Id} \nName: {empPeek.Name} \nGender: {empPeek.Gender} \nSalary: {empPeek.Salary}\n");

                Console.WriteLine(employees.Count);
            }

            Console.WriteLine("\n-----Fins tredje anstäld?-----\n");
            if (employees.Count >= 3) // created if else to check if employees has atleast 3 emements and then print the third employee
            {
                
                Employee thirdEmployee = employees.ToArray()[2];

                Console.WriteLine($"Ja det finns en tredje anstäld: {thirdEmployee.Name} ");
            }
            else
            {
                Console.WriteLine("Det finns mindre än 3 anstälda i stacken just nu.");
            }

            List<Employee> employeesList = new List<Employee>(); // created a list 

            employeesList.Add(employe1); // added all the Employee object to the list
            employeesList.Add(employee2);
            employeesList.Add(employee3);
            employeesList.Add(employee4);
            employeesList.Add(employee5);

            Console.WriteLine("\n-----Existerar andra anstälda-----\n");
            if (employeesList.Contains(employee2))// created a if to check if employeesList contains the second employee and print that it exists
            {
                Console.WriteLine("anstäld 2 existerar i listan");
            }
            else
            {
                Console.WriteLine("anstäld 2 existerar inte i listan");
            }

            Console.WriteLine("\n----Första manen i listan-----\n");
            Employee findAMan = employeesList.Find(x => x.Gender == "m"); // used find method to find the first male in the list 

            if (findAMan != null)// created if to printed the first male when it find the first male 
            {
                Console.WriteLine($"Första manliga anstälda är: \nId:{findAMan.Id} \nName: {findAMan.Name} \nGender: {findAMan.Gender} \nSalary: {findAMan.Salary}\n");
            }

            Console.WriteLine("-----Alla män i listan-----");
            List<Employee> findAllMen = employeesList.FindAll(x => x.Gender == "m"); // used findall method to find all the male inte list 

            foreach (var allMen in findAllMen)// foreach loop to print out all the men that the findall finds 
            {
                Console.WriteLine($"All manliga anstälda är: \nId:{allMen.Id} \nName: {allMen.Name} \nGender: {allMen.Gender} \nSalary: {allMen.Salary}\n");
            }
        }
    }
}
