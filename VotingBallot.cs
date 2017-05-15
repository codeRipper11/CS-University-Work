using System;

public class PresidentialCampaign
{
	public string republicanPresidentCandidate = "Donald Trump";
	public string democraticPresidentCandidate = "Hilary Clinton";
	public string republicanViceCandidate = "Ted Cruz";
	public string democraticViceCandidate = "Bernie Sanders";
	
	public int demoPresCounter = 0;
	public int repubPresCounter = 0;
	public int demoViceCounter = 0;
	public int repubViceCounter = 0;

	public string voterName;
	public string voterID;

	public int userInput = 0;

	public void DisplayCandidates()
	{
		Console.WriteLine("Presidential Political Party")
		Console.WriteLine("1. Democratic Party - {0}", democraticPresidentCandidate);
		Console.WriteLine("2. Republican Party - {0}", republicanPresidentCandidate);
		Console.WriteLine();
		Console.WriteLine("Vice Presidential Political Party")
		Console.WriteLine("1. Democratic Party - {0}", democraticViceCandidate);
		Console.WriteLine("2. Republican Party - {0}", republicanViceCandidate);
		Console.WriteLine();

	}
	public void VoterRegister()
	{
		Console.WriteLine("Please enter your name and ID number");
			voterName = Console.ReadLine();
			voterID  = Console.ReadLine();
	}
	public void VotePresidentProcess()
	{
		while(userVote != -1)
		{

			Console.WriteLine("Welcome to the voting process");

			VoterRegister();

			Console.WriteLine("Please make your Presidential selection");	
			Console.WriteLine("Enter 1 for the Democratic party and 2 for the Republican party");
			Console.WriteLine("Enter -1 to end");

			userInput = Convert.ToInt32(Console.ReadLine());

			if(userInput == 1)
			{
				Console.WriteLine("You have selected the Democratic Party");
				demoPresCounter++;
			}
			if else(userInput == 2)
			{
				Console.WriteLine("You have selected the Republican Party");
				repubPresCounter++;
			}
			else
			{
				Console.WriteLine("Please select 1 or 2");
			}
		}
	}
	public void VoteViceProcess()
	{
		while(userInput != -1)
		{
			Console.WriteLine("Please make your Vice Presidential selection");	
			Console.WriteLine("Enter 1 for the Democratic party and 2 for the Republican party");
			Console.WriteLine("Enter -1 to end");

			if(userInput == 1)
			{
				Console.WriteLine("You have selected the Democratic Party");
				demoViceCounter++;
			}
			if else(userInput == 2)
			{
				Console.WriteLine("You have selected the Republican Party");
				repubViceCounter++;
			}
			else
			{
				Console.WriteLine("Please select 1 or 2")
			}
		}
	}
	public void DisplayPresidentResults()
	{
		if(demoPresCounter < repubPresCounter)
		{
			Console.WriteLine("The President is {0}", republicanPresidentCandidate);
			Console.WriteLine("The number of republican votes are {0}", repubPresCounter);
			Console.WriteLine("The number of democratic votes are {0}", demoPresCounter;);
		}
		else		
		{
			Console.WriteLine("The President is {0}", democraticPresidentCandidate);
			Console.WriteLine("The number of democratic votes are {0}", demoPresCounter;);
			Console.WriteLine("The number of republican votes are {0}", repubPresCounter);
		}
	}
	public void DisplayViceResults();
	{
		if(demoViceCounter < repubViceCounter)
		{
			Console.WriteLine("The Vice-President is {0}", republicanViceCandidate);
			Console.WriteLine("The number of republican votes are {0}", repubViceCounter);
			Console.WriteLine("The number of democratic votes are {0}", demoViceCounter);

		}
		if else
		{
			Console>WriteLine("The Vice-President is {0}", democraticViceCandidate);
			Console.WriteLine("The number of democratic votes are {0}", demoViceCounter);
			Console.WriteLine("The number of republican votes are {0}", repubViceCounter);
		}
	}
	public void DisplayResults()
	{
		if(userInput == -1)
		{
			DisplayPresidentResults();
			DisplayViceResults();
		}
	}
}