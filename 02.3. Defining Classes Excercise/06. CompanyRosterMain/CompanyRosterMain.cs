using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CompanyRosterMain
{
    public class CompanyRosterMain
    {
        public static void Main()
        {
            var incomingEmployees = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();
            for (int i = 0; i < incomingEmployees; i++)
            {
                var inputArgs = Console.ReadLine().Split();
                var name = inputArgs[0];
                var salary = double.Parse(inputArgs[1]);
                var position = inputArgs[2];
                var department = inputArgs[3];
                var email = string.Empty;
                var age = 0;
                if (inputArgs.Length == 4)
                {
                    employees.Add(new Employee(name, salary, position, department));
                    continue;
                }
                if (inputArgs.Length == 5)
                {
                    if (!int.TryParse(inputArgs[4], out age))
                    {
                        email = inputArgs[4];
                        employees.Add(new Employee(name, salary, position, department, email));
                    }
                    else
                    {
                        employees.Add(new Employee(name, salary, position, department, age));
                    }
                    continue;
                }
                email = inputArgs[4];
                age = int.Parse(inputArgs[5]);
                employees.Add(new Employee(name, salary, position, department, email, age));
            }
            var reqDepartment = string.Empty;
            if (employees.Count > 0)
            {
                reqDepartment = employees.GroupBy(x => x.department, (key, values) => new
                                                                                            {
                                                                                                AverageSalary = values.Average(x => x.salary),
                                                                                                Department = key
                                                                                            })
                .OrderByDescending(x => x.AverageSalary)
                .First()
                .Department;
            }
            else
            {
                Console.WriteLine();
                return;
            }
            Console.WriteLine($"Highest Average Salary: {reqDepartment}");
            foreach (var employee in employees.Where(x => x.department == reqDepartment).OrderByDescending(x => x.salary))
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
