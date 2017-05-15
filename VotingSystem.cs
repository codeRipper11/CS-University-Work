using System;

namespace VotingSystem
{
	class MainClass
	{
		string [] politicalParty = new string[10];
		string [] presidentCandidate = new string [10];
		string [] vicePresCandidate = new string[10];

		string poliParty;

		string presidentCandidateName;
		string vicePresCandidateName;

		string voterName;
		string voterID;

		int repubCounter = 0;
		int demoCounter = 0;
		int indyCounter = 0;

		int userInput = 0;

		int i, j, x;

		public void PoliticalParty(string party)
		{
			PoliParty = party;
		}
		public string PoliParty
		{ 
			set { poliParty = value; }
			get { return poliParty; }
		}
		public void PresidentCandidate(string presName)
		{
			PresCandidate = presName;
		}
		public string PresCandidate
		{ 
			set { presidentCandidateName = value; }
			get { return presidentCandidateName; }
 		}
		public void VicePresidentCandidate(string viceName)
		{
			VicePresCandidate = viceName;
		}
		public string VicePresCandidate
		{
			set { vicePresCandidateName = value; }
			get { return vicePresCandidateName; }
		}
		public void Voter(string vName, string vID)
		{
			VoterName = vName;
			VoterId = vID;
		}
		public string VoterName
		{
			set { voterName = value; }
			get { return voterName; }
		}
		public string VoterId
		{
			set { voterID = value; }
			get { return voterID; }
		}
		public void SystemConfiguration()
		{
			Console.WriteLine("Welcome to Presidential Candidate Configuration");
			Console.WriteLine("Please follow instructions accordingly");
			Console.WriteLine();

			PoliticalPartyConfiguration();
			PresidentCandidateConfiguration();
			VicePresidentCandidateConfiguration();
		}
		public void PoliticalPartyConfiguration()
		{
			Console.WriteLine("Enter the candidate's political party:");
			Console.WriteLine("Enter -1 to end");

			userInput = Convert.ToInt32(Console.ReadLine());

			while (userInput != -1)
			{
				for (i = 0; i < politicalParty.Length; i++)
				{
					Console.WriteLine("Enter the candidate's political party:");
					PoliParty = Convert.ToString(Console.ReadLine());
					politicalParty[i] = PoliParty;
				}
			}
		}
		public void PresidentCandidateConfiguration()
		{
			Console.WriteLine("Enter the President candidate's name:");
			Console.WriteLine("Enter -1 to end");

			userInput = Convert.ToInt32(Console.ReadLine());

			while (userInput != -1)
			{
				for (j = 0; j < presidentCandidate.Length; j++)
				{
					Console.WriteLine("Enter the President candidate's name:");
					PresCandidate = Convert.ToString(Console.ReadLine());
					presidentCandidate[j] = PresCandidate;
				}
			}
		}
		public void VicePresidentCandidateConfiguration()
		{
			Console.WriteLine("Enter the Vice President candidate's name:");
			Console.WriteLine("Enter -1 to end");

			userInput = Convert.ToInt32(Console.ReadLine());

			while (userInput != -1)
			{
				for (int x = 0; x < vicePresCandidate.Length; x++)
				{
					Console.WriteLine("Enter the Vice President candidate's name:");
					VicePresCandidate = Convert.ToString(Console.ReadLine());
					vicePresCandidate[x] = VicePresCandidate;
				}
			}
		}
		public void SystemOutputDisplay()
		{
			WelcomeMessage();
			DisplayPresidentCadidates();
			DisplayVicePresCandidates();
		} 
		public void WelcomeMessage()
		{
			Console.WriteLine("Welcome to the United States Voting Registry");
			Console.WriteLine("Please follow instructions carefully and complete ballot accurately");
			Console.WriteLine("Please select the number given next to the candidate's name");
			Console.WriteLine("Example - Select 1 for | 1. George Washington |");
		}
		public void DisplayPresidentCadidates()
		{
			for (j = 0; j <= presidentCandidate.Length; j++)
				Console.WriteLine("{0}", j + presidentCandidate[j]);
		}
		public void DisplayVicePresCandidates()
		{
			for (x = 0; x <= vicePresCandidate.Length; x++)
				Console.WriteLine("{0}", x + vicePresCandidate[x]);
		}
		public void Voting()
		{
			PromptVoter();
		}
		public void PromptVoter()
		{
			Console.WriteLine("Welcome proud citizen of the United States");

			Console.WriteLine("Please enter your first and last name:");
			VoterName =Console.ReadLine();

			Console.WriteLine("Please enter your social security number:");
			VoterId = Console.ReadLine();
		}
	}
}
