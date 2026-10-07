//Ludvig Revholm Hedman .Net26
namespace Lab6OOPGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> employees = new Stack<Employee>();

            Employee employe1 = new Employee(3457, "tara", "f", 34000);
            Employee employee2 = new Employee(2345, "sara", "f", 34000);
            Employee employee3 = new Employee(5667, "hasse", "m", 34000);
            Employee employee4 = new Employee(9347, "bob", "m", 40000);
            Employee employee5 = new Employee(8645, "noah", "m", 34000);

            employees.Push(employe1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);


            Console.WriteLine("-----print-----\n");
            foreach (var emplo in employees)
            {
                Console.WriteLine($"Id:{emplo.Id} \nName: {emplo.Name} \nGender: {emplo.Gender} \nSalary: {emplo.Salary}");
                Console.WriteLine(employees.Count);
            }

            Console.WriteLine("\n-----pop-----\n");
            while (employees.Count > 0)
            {
                var emp = employees.Pop();

                Console.WriteLine($"Id:{emp.Id} \nName: {emp.Name} \nGender: {emp.Gender} \nSalary: {emp.Salary}");

                Console.WriteLine(employees.Count);
            }

            employees.Push(employe1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            Console.WriteLine("\n-----Peek 2-----\n");
            for(int i = 0; i < 2; i++)
            {
                var empPeek = employees.Peek();

                Console.WriteLine($"Id:{empPeek.Id} \nName: {empPeek.Name} \nGender: {empPeek.Gender} \nSalary: {empPeek.Salary}\n");

                Console.WriteLine(employees.Count);
            }

            Console.WriteLine("\n-----Fins tredje anstäld?-----\n");
            if (employees.Count >= 3)
            {
                
                Employee thirdEmployee = employees.ToArray()[2];

                Console.WriteLine($"Ja det finns en tredje anstäld: {thirdEmployee.Name} ");
            }
            else
            {
                Console.WriteLine("Det finns mindre än 3 anstälda i stacken just nu.");
            }

            List<Employee> employeesList = new List<Employee>();

            employeesList.Add(employe1);
            employeesList.Add(employee2);
            employeesList.Add(employee3);
            employeesList.Add(employee4);
            employeesList.Add(employee5);

            Console.WriteLine("\n-----Existerar andra anstälda-----\n");
            if (employeesList.Contains(employee2))
            {
                Console.WriteLine("anstäld 2 existerar i listan");
            }
            else
            {
                Console.WriteLine("anstäld 2 existerar inte i listan");
            }

            Console.WriteLine("\n----Första manen i listan-----\n");
            Employee findAMan = employeesList.Find(x => x.Gender == "m");

            if (findAMan != null)
            {
                Console.WriteLine($"Första manliga anstälda är: \nId:{findAMan.Id} \nName: {findAMan.Name} \nGender: {findAMan.Gender} \nSalary: {findAMan.Salary}\n");
            }

            Console.WriteLine("-----Alla män i listan-----");
            List<Employee> findAllMen = employeesList.FindAll(x => x.Gender == "m");

            foreach (var allMen in findAllMen)
            {
                Console.WriteLine($"All manliga anstälda är: \nId:{allMen.Id} \nName: {allMen.Name} \nGender: {allMen.Gender} \nSalary: {allMen.Salary}\n");
            }
        }
    }
}
