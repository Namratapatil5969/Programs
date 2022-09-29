//using Microsoft.SqlServer.Server;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programs
//{
//    public class Account
//    {
//        public  string Acc_type { get; set; }

//        public List<Customer> Customers = new List<Customer>();
//    }
//    public class Customer
//    {
//        public string CName { get; set; }
//        public int Acc_No { get; set; }
//        public string Loan_type { get; set; }


//    }
//    public class program
//    {
//        static void Main(string[] args)
//        {
//            List<Account> accounts = new List<Account>()

//            {
//                new Account
//                {
//                    Acc_type="Saving",
//                    Customers ={
//                        new Customer{CName="Ram",Acc_No=001,Loan_type="Home Loan"},
//                        new Customer{CName="Jay",Acc_No=002,Loan_type="Car Loan"},
//                    }
//                },
//                new Account
//                {
//                    Acc_type = "Current",
//                    Customers ={
//                        new Customer{CName="Nisha",Acc_No=003,Loan_type="Education Loan"},
//                        new Customer{CName="Raman",Acc_No=004,Loan_type="Gold Loan"},
//                    }
//                },

//            };
//            foreach (Account ac in accounts )
//            {
//                Console.WriteLine(ac.Acc_type);
//                foreach (Customer c in ac.Customers)
//                {
//                    Console.WriteLine( $"Acc_No:{c.Acc_No}  Name:{c.CName} Loan_type:{c.Loan_type}");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
