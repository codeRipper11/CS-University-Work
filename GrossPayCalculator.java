import java.util.Scanner;

public class GrossPayCalculator 
{
	public static double rate = 17.00;
	public static double hours;
	public static double fedIncTax = .14;
	public static double stateIncTax = .06;
	public static double socSecTax = .05;
	public static double unionDues = 10;
	public static double dependents = 0;
	public static double grossPay;
	public static double netPay;
	
	public static void main(String [] args)
	{
		setHours();
		grossPay();
		fedIncomeTax();
		stateIncomeTax();
		socSecurityTax();
		dependentsFee();
		netPay();
		displayNetPay();
	}
	public static void setHours()
	{
		Scanner input = new Scanner(System.in);
		System.out.print("Enter the number of hours worked this week:");
		hours = input.nextInt();
	}
	public static void grossPay()
	{
		grossPay = rate* hours;
	}
	public static void fedIncomeTax()
	{
		fedIncTax = fedIncTax * grossPay;
	}
	public static void stateIncomeTax()
	{
		stateIncTax = stateIncTax * grossPay;
	}
	public static void socSecurityTax()
	{
		socSecTax = socSecTax * grossPay;
	}
	public static void dependentsFee()
	{
		Scanner input = new Scanner(System.in);
		System.out.print("Enter the number of dependents within the household:");
		dependents = input.nextInt();
		
		if(dependents >= 3)
		{
			grossPay = grossPay - 35;
		}
		else
		{
			return;
		}
	}
	public static void netPay()
	{
		netPay = grossPay - fedIncTax - stateIncTax - socSecTax - unionDues;
	}
	public static void displayNetPay()
	{
		System.out.print("Your net pay for the week is:$" + netPay);
	}
}
