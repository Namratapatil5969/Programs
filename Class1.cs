//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programs
//{
//    internal class Class1
//    {
//        public interface Istudent
//        {
//            string DisplayDetails();
//        }
//        public interface ITeacher
//        {
//            string DisplayDetails();
//        }

//        public class Transaction : Istudent, ITeacher
//        {
//            string Istudent.DisplayDetails()
//            {
//                return "print 1";
//            }

//            string ITeacher.DisplayDetails()
//            {
//                return "print 2";
//            }
//        }



//        static void Main(string[] args)
//        {
//            Istudent print1 = new Transaction();
//            Console.WriteLine(print1.DisplayDetails());

//            ITeacher print2 = new Transaction();
//            Console.WriteLine(print2.DisplayDetails());
//        }


//    }
//}
