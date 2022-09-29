//using System;
//using System.Collections.Generic;


//namespace Programs
//{
//    public class Product
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Price { get; set; }


//    }
//        //public class Employee
//        //{
//        //    public string Name { get; set; }
//        //}
//        public class Test<T>
//        {
//            T data;



//            public void Accept(T data)
//            {
//                this.data = data;
//            }
//            public T Print()
//            {
//                return data;
//            }
//        }
    
//        public class Program
//        {
//            static void Main(string[] args)
//            {
//                Test<int> obj1 = new Test<int>();
//                obj1.Accept(10);

//                Test<string> obj2 = new Test<string>();
//                obj2.Accept("Hello");

                 
//                 Test<Product> obj3 = new Test<Product>();
//                 obj3.Accept(new Product { Id = 1, Name = "Mobile", Price = 9999 });
                


//                //Test<Employee> obj4 = new Test<Employee>();
//                //obj3.Accept(new Employee("Test", 34000, 200));

//                Console.WriteLine(obj1.Print());
//                Console.WriteLine(obj2.Print());
//                Console.WriteLine(obj3.Print());
//            }

//        }
    

//}

