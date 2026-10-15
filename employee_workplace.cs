using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Department
    {
        private string name;
        private Employee head;
        private Employee[] employees;
        private int count;

        public Department(string name)
        {
            this.name = name;
            employees = new Employee[10];
            this.count = 0;
        }

        public string Name
        {
            get { return name; }
        }

        public Employee Head
        {
            get { return head; }
            set { head = value; }
        }

        public Employee[] Employees
        {
            get { return employees; }
        }

        internal void addEmployee(Employee e) 
        {
            employees[count++] = e;
        }

    }
    internal class Employee
    {
        private string name;
        private Department department;

        public Employee(string input_name, Department input_department)
        {
            this.name = input_name;
            this.department = input_department;
            this.department.addEmployee(this);
        }

        public string Name 
        { 
            get { return name; } 
        }

        public override string ToString()
        {
            if (this == department.Head)
            {
                return $"{name} является начальником отдела {department.Name}";
            }
            else if (department.Head is null) 
            {
                return $"{name} работает в отделе {department.Name}";
            }
            else
            {
                return $"{name} работает в отделе {department.Name}, начальник которого {department.Head.Name}";
            }
        }

        public void deptEmployees()
        {
            Console.WriteLine("Список всех сотрудников отдела:");
            for (int i = 0; i < department.Employees.Length; i++) 
            {
                if (department.Employees[i] is null)
                {
                    continue;
                }
                Console.WriteLine(department.Employees[i].Name);
            }
        }

    }

}
