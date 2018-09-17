using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpRUsInc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee dave = new Employee("David", "Agaybi", 762);
            Console.WriteLine("Employee:\t{0}", dave.ToString());
            Employee three = Employee.parse("David Peterson", 666);
            Console.WriteLine("Employee:\t{0}", three.ToString());
            Console.WriteLine("Employee firstname: {0}", dave.FirstName);
            Console.WriteLine("Employee lastname: {0}", dave.LastName);
            Console.WriteLine("Employee full name: {0}", dave.FullName);
            Console.WriteLine("Employee ID: {0}", dave.Id);

            Console.WriteLine(Employee.CompanyName);





        }
    }

    class Employee
    {
        private static string _firstName, _lastName;
        public const string CompanyName = "SharpRUsInc";
        private readonly int ID;

        public Employee(int id)
        {
            ID = id;
        }

        public Employee(string f, string l, int id)
        {
            _firstName = f;
            _lastName = l;
            ID = id;

        }

        public int Id
        {
            get
            {
                return this.ID;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }


        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return (_firstName + " " + _lastName);
            }
        }

        public static Employee parse(string name, int id)
        {
            Employee one = new Employee(id);
            one.FirstName = name.Split()[0];
            one.LastName = name.Split()[1];
            return one;
            
        }

        public override string ToString()
        {
            string employee = _firstName + " " + _lastName + " " + ID;
            return employee.ToString();
        }
    }
}
