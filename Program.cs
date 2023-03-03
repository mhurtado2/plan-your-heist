using System;
using System.Collections.Generic;

namespace planYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            //phase 5 
            // Run the scenario multiple times. {check}
            // After the user enters the team information, prompt them to enter the number of trial runs the program should perform.{check}
            // Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. 
            // Choose a new luck value each time.

        RunThis();
       
        void RunThis()
        {
    
            Console.WriteLine("Plan Your Heist");
            Console.WriteLine("----------------");

            //phase 6
            Console.WriteLine("Enter the difficulty level of the bank");
            string selectDifficulty = Console.ReadLine().Trim();
            int numAnswerFour;
            bool isNumberTwo = int.TryParse(selectDifficulty, out numAnswerFour);
            // Console.WriteLine(selectDifficulty);

            //phase 3 
            Bank wellsFargo = new();
            wellsFargo.BanksDifficulty= numAnswerFour;
            // Console.WriteLine(wellsFargo.BanksDifficulty);


            //phase 2 
            //make a blank list to add team members too
            List<TeamMember> Roster = new List<TeamMember> {};
            //add team members to list while making team is true
            bool makingTeam = true;
            while(makingTeam)
            {
                TeamMember teamMember = CreateNewTeamMember();
                if(teamMember != null)
                {
                    teamMember.GetDescription();
                    Roster.Add(teamMember);
                }
                else 
                {
                    makingTeam = false;
                }
            }
        
            //write out the stats for each member of the team
            //use a for loop

            int skillLevelSum = 0;
            for (int i = 0; i < Roster.Count; i++) 
            {
                skillLevelSum += Roster[i].Level;
            }
             Console.WriteLine($"Your Team's Skill level is: {skillLevelSum}");

        
    //59 - 80 wrap in function called run hesit, pass it bank difficulty and skill level 
    void RunHeist()
    {
        //phase 4
        // Create a random number between -10 and 10 for the heist's luck value. 
        // Compare the number with the bank's difficulty level. 
        // If the team's skill level is greater than or equal to the bank's difficulty level, 
        // Display a success message, otherwise display a failure message.

        int heistLuckValue = new Random().Next(-10, 10);
        int luckPlusBankDiff = heistLuckValue + wellsFargo.BanksDifficulty;
        Console.WriteLine($"The Banks current difficulty is: {luckPlusBankDiff}");

        // Before displaying the success or failure message, display a report that shows.
        // The team's combined skill level
        // The bank's difficulty level
        
        if(skillLevelSum > wellsFargo.BanksDifficulty)
            {
                Console.WriteLine("Congrats!!!, you can break in safely");
            }
            else {
                Console.WriteLine("Your screwed don't break in");
            }
        }

        //step 2 phase 5
        Console.WriteLine("How Many Times Would you like to run this program");
        string answer = Console.ReadLine().Trim();
        int numAnswerthree;
        bool isNumber = int.TryParse(answer, out numAnswerthree);

        //move above runheist
        for (int i = 0; i < numAnswerthree; i++)
        {
           //should iterate through the heist answer times
              RunHeist();
        }


        //phase 1

            TeamMember CreateNewTeamMember()
            {
            Console.WriteLine("Team Member's name: ");
             string Username= Console.ReadLine().Trim();
             if(Username == "")
             {
                return null;
             }
             //write a conditional if username is blank 
             //if username is eual blank string, return null
            Console.WriteLine("Team Member's skill level: ");
             string SkillLevel = Console.ReadLine().Trim();
             int numAnswer;
             bool isNumber = int.TryParse(SkillLevel, out numAnswer);
              Console.WriteLine("Team Member's courage level: ");
             string CourageLevel = Console.ReadLine().Trim();
              double numAnswerTwo;
             bool isNumberTwo = double.TryParse(CourageLevel, out numAnswerTwo);
               
               
         TeamMember teamMember = new TeamMember(Username, numAnswer, numAnswerTwo);
         return teamMember;

        }
      }
    }
  }
}