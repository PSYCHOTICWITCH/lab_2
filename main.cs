using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int option = 1;
            while (option != 0)
            {
                Console.WriteLine("Лабораторная работа 2");
                Console.WriteLine("Введите номер задания 1 - 5 (0 для выхода)");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Имена");

                            Console.WriteLine("Введите фамилию");
                            string surname = Console.ReadLine();
                            Console.WriteLine("Введите имя");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите отчество");
                            string patronym = Console.ReadLine();
                            Name name_1 = new(surname, name, patronym);
                            Console.WriteLine("Объект 1 создан");

                            Console.WriteLine("Введите фамилию");
                            surname = Console.ReadLine();
                            Console.WriteLine("Введите имя");
                            name = Console.ReadLine();
                            Name name_2 = new(surname, name);
                            Console.WriteLine("Объект 2 создан");

                            Console.WriteLine("Введите имя");
                            name = Console.ReadLine();
                            Name name_3 = new(name);
                            Console.WriteLine("Объект 3 создан");

                            Console.WriteLine("Созданные имена:");
                            Console.WriteLine(name_1.ToString());
                            Console.WriteLine(name_2.ToString());
                            Console.WriteLine(name_3.ToString());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Дом");
                            Console.WriteLine("Введите количество этажей первого дома");
                            int floors;
                            while (!int.TryParse(Console.ReadLine(), out floors))
                            {
                                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                            }
                            House house_1 = new(floors);
                            Console.WriteLine("Объект 1 создан");

                            Console.WriteLine("Введите количество этажей второго дома");
                            while (!int.TryParse(Console.ReadLine(), out floors))
                            {
                                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                            }
                            House house_2 = new(floors);
                            Console.WriteLine("Объект 2 создан");

                            Console.WriteLine("Введите количество этажей третьего дома");
                            while (!int.TryParse(Console.ReadLine(), out floors))
                            {
                                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                            }
                            House house_3 = new(floors);
                            Console.WriteLine("Объект 3 создан");

                            Console.WriteLine("Созданные объекты:");

                            Console.WriteLine(house_1.ToString());
                            Console.WriteLine(house_2.ToString());
                            Console.WriteLine(house_3.ToString());

                            break;
                        }
                    case 3: 
                        {
                            Console.WriteLine("Сотрудники и отделы");

                            Console.WriteLine("Введите название отдела:");
                            string dept_name = Console.ReadLine();
                            Department dept = new(dept_name);

                            Console.WriteLine("Введите фамилию первого сотрудника:");
                            string name_1 = Console.ReadLine();
                            Employee employee_1 = new(name_1, dept);

                            Console.WriteLine("Введите фамилию второго сотрудника:");
                            string name_2 = Console.ReadLine();
                            Employee employee_2 = new(name_2, dept);

                            Console.WriteLine("Введите фамилию третьего сотрудника:");
                            string name_3 = Console.ReadLine();
                            Employee employee_3 = new(name_3, dept);

                            Console.WriteLine("Выберите сотрудника, которого нужно сделать начальником:");

                            Console.WriteLine($"1 - {name_1}");
                            Console.WriteLine($"2 - {name_2}");
                            Console.WriteLine($"3 - {name_3}");

                            int head_number;

                            while (!int.TryParse(Console.ReadLine(), out head_number) && (head_number != 1 || head_number != 2 || head_number != 3))
                            {
                                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                            }

                            switch (head_number)
                                {
                                case 1: dept.Head = employee_1; break;
                                case 2: dept.Head = employee_2; break;
                                case 3: dept.Head = employee_3; break;
                            }

                            Console.WriteLine("Созданные объекты");

                            Console.WriteLine(employee_1.ToString());
                            Console.WriteLine(employee_2.ToString());
                            Console.WriteLine(employee_3.ToString());

                            Console.WriteLine("Введите название еще одного отдела:");
                            string dept_name_2 = Console.ReadLine();
                            Department dept_2 = new(dept_name);

                            Console.WriteLine("Введите фамилию первого сотрудника:");
                            string name_4 = Console.ReadLine();
                            Employee employee_4 = new(name_4, dept_2);

                            Console.WriteLine("Введите фамилию второго сотрудника:");
                            string name_5 = Console.ReadLine();
                            Employee employee_5 = new(name_5, dept_2);

                            Console.WriteLine("Выберите сотрудника, список коллег которого нужно вывести:");

                            Console.WriteLine($"1 - {name_1}");
                            Console.WriteLine($"2 - {name_2}");
                            Console.WriteLine($"3 - {name_3}");
                            Console.WriteLine($"4 - {name_4}");
                            Console.WriteLine($"5 - {name_5}");

                            int employee_number;

                            while (!int.TryParse(Console.ReadLine(), out employee_number) && (employee_number != 1 || employee_number != 2 || employee_number != 3 || employee_number != 4 || employee_number != 5))
                            {
                                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                            }

                            switch (employee_number)
                            {
                                case 1: employee_1.deptEmployees(); break;
                                case 2: employee_2.deptEmployees(); break;
                                case 3: employee_3.deptEmployees(); break;
                                case 4: employee_4.deptEmployees(); break;
                                case 5: employee_5.deptEmployees(); break;
                            }

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Имена");

                            Console.WriteLine("Введите имя");
                            string name = Console.ReadLine();
                            Name name_1 = new(name);
                            Console.WriteLine("Объект задан одним параметром");

                            Console.WriteLine("Введите фамилию");
                            string surname = Console.ReadLine();
                            Console.WriteLine("Введите имя");
                            name = Console.ReadLine();
                            Name name_2 = new(surname, name);
                            Console.WriteLine("Объект задан двумя параметрами");

                            Console.WriteLine("Введите фамилию");
                            surname = Console.ReadLine();
                            Console.WriteLine("Введите имя");
                            name = Console.ReadLine();
                            Console.WriteLine("Введите отчество");
                            string patronym = Console.ReadLine();
                            Name name_3 = new(surname, name, patronym);
                            Console.WriteLine("Объект задан тремя параметрами");

                            Console.WriteLine("Созданные имена:");
                            Console.WriteLine(name_1.ToString());
                            Console.WriteLine(name_2.ToString());
                            Console.WriteLine(name_3.ToString());
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Дроби");
                            Console.WriteLine("Введите числитель первой дроби");
                            int numerator_1;

                            while (!int.TryParse(Console.ReadLine(), out numerator_1))
                            {
                                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                            }
                            
                            Console.WriteLine("Введите знаменатель первой дроби");
                            int denominator_1;

                            while (!int.TryParse(Console.ReadLine(), out denominator_1))
                            {
                                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                            }

                            Fraction fract_1 = new(numerator_1, denominator_1);

                            Console.WriteLine("Введите числитель второй дроби");
                            int numerator_2;

                            while (!int.TryParse(Console.ReadLine(), out numerator_2))
                            {
                                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                            }

                            Console.WriteLine("Введите знаменатель второй дроби");
                            int denominator_2;

                            while (!int.TryParse(Console.ReadLine(), out denominator_2))
                            {
                                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                            }

                            Fraction fract_2 = new(numerator_2, denominator_2);

                            Console.WriteLine("Операции");

                            Console.WriteLine($"{fract_1.ToString()} + {fract_2.ToString()} = {fract_1.sum(fract_2).ToString()}");
                            Console.WriteLine($"{fract_1.ToString()} - {fract_2.ToString()} = {fract_1.minus(fract_2).ToString()}");
                            Console.WriteLine($"{fract_1.ToString()} * {fract_2.ToString()} = {fract_1.multiply(fract_2).ToString()}");
                            Console.WriteLine($"{fract_1.ToString()} / {fract_2.ToString()} = {fract_1.div(fract_2).ToString()}");

                            Console.WriteLine("Введите числитель третьей дроби");
                            int numerator_3;

                            while (!int.TryParse(Console.ReadLine(), out numerator_3))
                            {
                                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                            }

                            Console.WriteLine("Введите знаменатель второй дроби");
                            int denominator_3;

                            while (!int.TryParse(Console.ReadLine(), out denominator_3))
                            {
                                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                            }

                            Fraction fract_3 = new(numerator_3, denominator_3);
                            Fraction fract_4 = new(5);

                            Console.WriteLine("Сложное выражение:");
                            Console.WriteLine($"({fract_1.ToString()} + {fract_2.ToString()}) / {fract_3.ToString()} - 5 = {fract_1.sum(fract_2).div(fract_3).minus(fract_4).ToString()}");

                            break;

                        }
                    default: break;
                }
            }


        }

        
    }
}
