using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main()
        {
            CEO a1 = new CEO("parag",5,12.65M,"peon","holiday");
            CEO a2 = new CEO("akash", 4, 36.34M, "GM", "Bonus");
            CEO a3 = new CEO("Harish", 9, 26.43M, "Director", "Hike");
            GeneralManager a5 = new GeneralManager("Omkar",3 , 42.25M,"Instructor", "Leave");
            a1.CalNetSalary();
            a5.CalNetSalary();
            Console.WriteLine(a1.EmpNo);
            Console.WriteLine(a2.EmpNo);
            Console.WriteLine(a3.EmpNo);
            Console.WriteLine(a1.Name);
            Console.WriteLine(a2.Designation);
        }
    }
    
    

    public abstract class Employee
    {
        private String name;
        private decimal basic;
        public String Name
        {
            set
            {
                if (value != null)
                    Name = value;
                else
                    Console.WriteLine("Blank name");

            }
            get
            {
                return name;
            }
        }

        private static int lastempNo = 0;
        private int empNo;
        public int EmpNo
        {
            get { return empNo; }
            set { empNo = value; }   
        }

        private short deptNo;

        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Dept number is zero or less than");
            }
        }

        public abstract decimal Basic { get; set; }


        
        public Employee(String name,short deptNo,decimal basic)
        {
            this.name = name;
            empNo = ++lastempNo;
            this.deptNo = deptNo;
            this.basic = basic;

        }

        public abstract void CalNetSalary();
        


    }



    public class Manager : Employee
    {
        private String designation;

        public override decimal Basic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void CalNetSalary()
        {
            Console.WriteLine("calnet called");
           
        }

        public Manager(String designation,String name,short deptNo,decimal basic) : base(name ,deptNo,basic)
        {
            this.designation = designation;
        }

        public String Designation
        {
            set
            {
                if (value != null)
                    designation = value;
                else
                    Console.WriteLine("cannot be blank");
            }
            get
            {
                return designation;
            }
        }
    }

    public class GeneralManager : Manager
    {
        private String perks;
        public override void CalNetSalary()
        {
            Console.WriteLine("calnet clled from GeneralManager");
        }

        public GeneralManager( String name, short deptNo, decimal basic,String designation ,String perks)  : base  (designation,name, deptNo, basic)
        {
            this.perks = perks;
        }

    }

    public class CEO : GeneralManager
    {
        public sealed override void CalNetSalary()
        {
            Console.WriteLine("calnet called++");
        }

        public CEO(String name, short deptNo, decimal basic, String designation, String perks) : base( name, deptNo, basic,designation,perks)
        {
           
        }
    }
}
