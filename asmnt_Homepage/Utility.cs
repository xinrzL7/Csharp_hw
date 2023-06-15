using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asmnt_Homepage
{
    public class Utility
    {
    }
    public struct stuStruct
    {
        public string Name;
        public int CN;
        public int EN;
        public int MA;
    }
    public class HelloHi
    {
        public string Name;
        public string enName;
        public string Gender;
        public string Sign;
    }

    public class LoanClass
    {
        public double Loan;
        public double Period;
        public double InterestRate;
        public double DownPay;
        public double monthMethod()
        {
            double monthInterest =
                (Math.Pow((1 + InterestRate / 1200), Period * 12) * InterestRate / 1200) /
                (Math.Pow((1 + InterestRate / 1200), Period * 12) - 1);
            double monthback = Math.Round((Loan - DownPay) * monthInterest);
            return monthback;
        }
        public double totalloanMethod() 
        {
            double totalmonth = Period * 12;
            double totalpay = monthMethod() * totalmonth;
            return totalpay;
        }

    }

    




}

