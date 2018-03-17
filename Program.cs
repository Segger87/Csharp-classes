﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Staff
    {
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;

        public int HoursWorked
        {
            get{
                return hWorked;
            }
            set 
            {
                if (value > 0) //value is a keyword if used inside a setter - refers to the value on the right side of the assignment statement
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }

        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }

        public int CalculatePay()
        {
            PrintMessage();

            int staffPay = hWorked * hourlyRate;

            if(hWorked > 0)
                return staffPay;
            else
                return 0;  
        }

        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }

		public override string ToString() //override indicates this method overrides the default method, ToString returns the int variables into a string
		{
            return "Name of staff = " + nameOfStaff + ", hourlyRate = " + hourlyRate + ", hWorked = " + hWorked;
		}

        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("--------------------------");
        }

        public Staff(string firstName, string lastName)
        {
            nameOfStaff = firstName + " " + lastName;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("--------------------------");
        }
	}

    class Program
    {
        static void Main(string[] args)
        {
            int pay;

            //syntax for creating object: ClassName objectName = new ClassName(arguments);
            Staff staff1 = new Staff("Sam");
            staff1.HoursWorked = 160;
            pay = staff1.CalculatePay(100, 400);
            Console.WriteLine("Pay = {0}", pay);

            Staff staff2 = new Staff("Bill", "Withers");
            staff2.HoursWorked = 180;
            pay = staff2.CalculatePay(200, 0);
            Console.WriteLine("Pay = {0}", pay);

            Staff staff3 = new Staff("Carol");
            staff3.HoursWorked = -10;
            pay = staff3.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);

            Console.Read();
        }
    }
}
