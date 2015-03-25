namespace _02.StudentsWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;
        private int workDayForWeek;

        public Worker(string fistName, string lastName, decimal weekSalary, int workHoursePerDay, int workDayForWeek)
            : base(fistName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursePerDay;
            this.WorkDayForWeek = workDayForWeek;
        }
        public decimal WeekSalary
        {
            get 
            { 
                return this.weekSalary; 
            }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }

                this.weekSalary = value; 
            }
        }

        public int WorkHoursPerDay 
        {
            get 
            { 
                return workHoursPerDay; 
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work hourse cannot be negative!");
                }

                workHoursPerDay = value; 
            }
        }

        public int WorkDayForWeek
        {
            get
            {
                return this.workDayForWeek;
            }

            set
            {
                if (value < 0 && value > 7)
                {
                    throw new ArgumentException("Work day cannot be negative or bigger then 7!");
                }

                this.workDayForWeek = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal money = weekSalary / (workDayForWeek * workHoursPerDay);

            return money;
        }
    }
}
