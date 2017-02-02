/*
Justin Sprinkle
2.2.17
Gross Pay Calculator
CSCI 1301 Dr. Alberto De La Cruz
*/
using System;

workspace Calculator
{
	class GrossPayCalculator
	{
		public static void Main(string [] args)
		{
			public double grossPay;
			public double hours = 0;
			public double rate = 16.78;
			public double fedIncomeTax = .14;
			public double finalFedIncomeTax;
			public double socSecurityTax = .06;
			public double finalSocSecurityTax;
			public double stateIncomeTax = .05;
			public double finalStateTax;
			public double unionDues = 10;
			public double overtime;
			public double netPay;
			public int dependents;

			HoursWorked();
			displayNetPay();
		}	

			public HoursWorked()
			{
				Console.WriteLine("Enter the number of hours worked: ")
				hours = Convert.ToInt32(Console.ReadLine());
			}
			public void GrossPay() 
			{
				grossPay = hours * rate;
			}
			public void OverTime(double overtime)
			{
				if (hours > 40)
				{
					overtime = (hours - 40) * (rate * 1.5);
				}
			}
			public void DependentsFee()
			{
				if(dependents >= 3)
				{
					grossPay = grossPay - 35;
				}
			}
			public void FederalIncomeTax(double finalFedIncomeTax)
			{
				finalFedIncomeTax = fedIncomeTax * grossPay;
			}
			public void SocialSecurityTax(double finalSocSecurityTax)
			{
				finalSocSecurityTax = socSecurityTax * grossPay;
			}
			public void StateIncomeTax(double finalStateTax)
			{
				finalStateTax = stateIncomeTax * grossPay;
			}
			public void UnionDues()
			{
				grossPay = grossPay - 10;
			}
			public void NetPay()
			{
				netPay = GrossPay() + OverTime() - FederalIncomeTax() - SocialSecurityTax() - StateIncomeTax() - DependentsFee() - UnionDues();
			}
			public void DisplayNetPay()
			{
				Console.WriteLine("Your netpay is {0}", NetPay());
			}
	}
}