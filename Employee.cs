using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Employee
    {
        protected string lastName;
        protected string firstName;
        protected double p;
        protected double k;

        // конструктор с параметрами
        public Employee(string lastName, string firstName, double p, double k)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.p = p;
            this.k = k;
        }

        
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Фамилия: {lastName}\nИмя: {firstName}\nДоход: {CalculateIncome()}\n");
        }

        
        public double CalculateIncome()
        {
            return k * p;
        }
    }

    
    class Engineer : Employee
    {
        private int n; 

        
        public Engineer(string lastName, string firstName, double p, double k, int n) : base(lastName, firstName, p, k)
        {
            this.n = n;
        }

        
        public override void DisplayInfo()
        {
            Console.WriteLine($"Фамилия: {lastName}\nИмя: {firstName}\nДоход: {CalculateIncome()}\nКоличество проектов: {n}\n");
        }

        
        public new double CalculateIncome()
        {
            
            if (n > 10)
                return base.CalculateIncome() * (n / 10.0);
            else
                return base.CalculateIncome();
        }
    }
}

