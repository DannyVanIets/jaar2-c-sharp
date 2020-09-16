using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huiswerkWeek2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(09, 04, 1998);
            Date date2 = new Date(05, 12, 1998);
            Date date3 = new Date(06, 07, 1998);

            var emp1 = new SalariedEmployee("Danny", "van Iets", "12345", date1, 500);
            var emp2 = new SalariedEmployee("Danny", "van Iets", "12345", date2, 400);
            var emp3 = new SalariedEmployee("Danny", "van Iets", "12345", date3, 400);
        }
    }

    public abstract class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
        public Date BirthDate { get; }
        

        public Employee(string firstName, string lastName, string socialSecurityNumber, Date birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            BirthDate = birthDate;
        }

        public override string ToString() => $"{FirstName} {LastName}\n " +
            $"social security number: {SocialSecurityNumber}";

        public abstract decimal Earnings();
    }

    public class Date
    {
        private int month;
        private int day;
        public int Year { get; private set; }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
            Console.WriteLine($"Date object constructor for date {this}");
        }

        public int Month
        {
            get
            {
                return month;
            }
            private set
            {
                if(value <= 0 || value > 12)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Month)} must be 1 - 12");
                }
                month = value;
            }
        }

        public int Day
        {
            get
            {
                return day;
            }
            private set
            {
                int[] dayPerMonth = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                if(value <= 0 || value > dayPerMonth[Month])
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Day)} out of range for current month/year");
                }

                if(Month == 2 && value == 29 && !(Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0))) {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Day)} out of range for current month/year");
                }
                day = value;
            }
        }
        public override string ToString() => $"{Day}/{Month}/{Year}";
    }

    class SalariedEmployee : Employee
    {
        private decimal weeklySalaray;

        public SalariedEmployee(string firstName, string lastName, string socialSecurityNumber, Date birthDate, decimal weeklySalaray) : base(firstName, lastName, socialSecurityNumber, birthDate)
        {
            WeeklySalaray = weeklySalaray;
        }

        public decimal WeeklySalaray
        {
            get
            {
                return WeeklySalaray;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(WeeklySalaray)} must be >= 0");
                }
                weeklySalaray = value;
            }
        }

        public override decimal Earnings() => WeeklySalaray;

        public override string ToString() => $"Salaried employee: {base.ToString()}\n" +
            $"weekly salaray: {WeeklySalaray:C}";

    }
}
