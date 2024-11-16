using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooopsprogram1
{
    internal class Programm1cs
    {
        static void Main(string[] args)
        {
            //Bank bank = new Bank(5000);
            //bank.Deposit(2000);
            //Console.WriteLine(bank.Withdraw(3000));
            //Console.WriteLine(bank.GetBalance());

            //Product p = new Product("a1", "watch", 3000);
            //Console.WriteLine(p.Print());

            //Book book = new Book(11,"GOT","Mr.X",5000);
            //Console.WriteLine(book.Display());

            //BookProperties b = new BookProperties();
            //b.Bid = 1;
            //b.Name = "Name";
            //b.Author = "Author";
            //b.Price = 1000;
            //Console.WriteLine($"bid={b.Bid} name={b.Name} author={b.Author} price={b.Price}");

            //BookProperties b2 = new BookProperties {Bid=2,Name="hu",Author="dff",Price=323};
            //Console.WriteLine($"bid={b2.Bid} name={b2.Name} author={b2.Author} price={b2.Price}");

            //Console.WriteLine();
            //Console.WriteLine();

            //EmployeeProperties emp = new EmployeeProperties();
            //emp.Id = 1;
            //emp.Name = "Name";
            //emp.Salary = 1000;
            //Console.WriteLine($"EmpId ={emp.Id} EmpName={emp.Name} EmpSalary={emp.Salary}");

            //EmployeeProperties emp2 = new EmployeeProperties { Id = 2, Name = "ed", Salary = 1100 };
            //Console.WriteLine($"EmpId ={emp2.Id} EmpName={emp2.Name} EmpSalary={emp2.Salary}");

            //Console.WriteLine();
            //Console.WriteLine();

            //StudentProperties sp = new StudentProperties();
            //sp.Rollno = 11;
            //sp.Name = "ewfef";
            //sp.S1 = 100;
            //sp.S2 = 100;
            //sp.S3 = 90;
            //Console.WriteLine($"RollNo={sp.Rollno} Name={sp.Name} Sub1={sp.S1} Sub2={sp.S2} Sub3={sp.S3}");

            //StudentProperties sp2 = new StudentProperties { Rollno=12,Name="sdsw",S1=91,S2=98,S3=93};
            //Console.WriteLine($"RollNo={sp2.Rollno} Name={sp2.Name} Sub1={sp2.S1} Sub2={sp2.S2} Sub3={sp2.S3}");


            //Console.WriteLine("StudentCount " + Student.DisplayCount());
            //Student student = new Student("tejas", 99, 98, 98);
            //student.Calculate();
            //Console.WriteLine(student.Print());
            //Student student2 = new Student("user", 99, 97, 98);
            //student2.Calculate();
            //Console.WriteLine(student2.Print());
            //Console.WriteLine("StudentCount "+Student.DisplayCount());

            Calculator c = new Calculator();
            Console.WriteLine(c.Add(14, 9));
            //Console.WriteLine(c.Mul(2,3,3));
            //Console.WriteLine(c.Sub(10,2,3));
            //Console.WriteLine(c.Div(10.2,2));

            //Employee  e1 = new Employee();
            //Console.WriteLine(e1.Display());

            //Employee e2 = new Employee(id:1,name:"tejas",salary:10000);
            //Console.WriteLine(e2.Display());

            //Employee e3 = new Employee(name: "omkar", salary: 100000);
            //Console.WriteLine(e3.Display());

            //Console.WriteLine(Payment.PayBill(500));
            //Console.WriteLine(Payment.PayBill(500,"credit card"));

        }
    }
