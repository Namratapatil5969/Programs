//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programs
//{
//    public class Employee
//    {
//        public string EmpName { get;set; }
//        public int EmpID { get;set; }

//    }
//    public class Department
//    {
//        public string DeptName { get;set; }
//        public string Location { get;set; }
//        public Employee[] employees { get; set; }

//    }
//    public class program
//    {
//        static void Main(string[] args)
//        {
//            Employee[] emp1 = new Employee[]
//            {
//                new Employee { EmpName = "Ram", EmpID = 1 },
//                new Employee { EmpName = "Shirish", EmpID = 2 },
//                new Employee { EmpName = "Karan", EmpID = 3 }
//            };
//            Employee[] emp2 = new Employee[]
//            {
//                new Employee { EmpName = "Nayan", EmpID = 4 },
//                new Employee { EmpName = "Kunal", EmpID = 5 },
//                new Employee { EmpName = "Rohan", EmpID = 6 }
//            };

//            Employee[] emp3 = new Employee[]
//            {
//                new Employee { EmpName = "Jay", EmpID = 7 },
//                new Employee { EmpName = "Raj", EmpID = 8 },
//                new Employee { EmpName = "Karan", EmpID = 9 }
//            };

//            Department[] departments = new Department[]
//            {
//                new Department{DeptName="IT",Location="Pune",employees=emp1},
//                new Department{DeptName="Electrical",Location="Mumbai",employees=emp2 },
//                new Department{DeptName="Mechanical",Location="Banglore",employees=emp3}
//            };
//            foreach(Department de in departments)
//            {
//                Console.WriteLine($"{de.DeptName} {de.Location}");
//                foreach(Employee e in de.employees)
//                {
//                    Console.WriteLine($"\t {e.EmpName}= {e.EmpID}");
//                }
//            }
//        }
//    }
//}
