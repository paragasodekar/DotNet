using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 12346, 10);
            Employee o2 = new Employee("Amol", 12346);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            Console.WriteLine(o1.Name);
            Console.WriteLine(o1.Basic);
            Console.WriteLine(o1.DeptNo);
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);
            Console.ReadLine();
        }

        public class Employee
        {

            public Employee(String name = null, decimal basic = 0, short deptNo = 0)
            {

                empNo = ++eNo;
                Name = name;
                Basic = basic;
                DeptNo = deptNo;
            }
            private String name;

            public String Name
            {
                set
                {
                    if (value != null)
                    {
                        name = value;
                    }
                    else
                        Console.WriteLine("Invalid  name");
                }

            
                get
                {
                    return name;
                }

            }


            private int empNo;

            public int EmpNo
            {
                get
                {
                    return empNo;
                }
            }

            private static int eNo;
            public static int ENo
            {
                set
                {
                    eNo = 0;
                }
                get
                {
                    return eNo;
                }
            }



            private short deptNo;

            public short DeptNo
            {
                set
                {
                    if (value <= 0)
                        Console.WriteLine("dept No is invalid");
                    
                    else
                        deptNo = value;
                }
                get
                {
                    return deptNo;
                }
            }

            private decimal basic;

            public decimal Basic
            {
                set
                {
                    if (value < 150000 && value > 0)
                    {
                        basic = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Basic");
                    }
                }
                get
                {
                    return basic;
                }
            }

            public decimal GetNetSalary()
            {
                return basic + 2000 + 5000;
            }
        }
        }
}
