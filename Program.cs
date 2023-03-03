using System;
using System.Collections.Generic;

namespace planYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
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
             Console.WriteLine(skillLevelSum);

        //phase 3 
            Bank wellsFargo = new();
            wellsFargo.BanksDifficulty= 100;

        // Compare the number with the bank's difficulty level. 
        // If the team's skill level is greater than or equal to the bank's difficulty level, 
        // Display a success message, otherwise display a failure message.

        if(skillLevelSum > wellsFargo.BanksDifficulty)
        {
            Console.WriteLine("Congrats!!!, you can break in safely");
        }
        else {
            Console.WriteLine("Your screwed don't break in");
        }

        //phase 1

            TeamMember CreateNewTeamMember()
            {
            //console write plan your hesit
            Console.WriteLine("Plan Your Heist");
            Console.WriteLine("What is your name: ");
             string Username= Console.ReadLine().Trim();
             if(Username == "")
             {
                return null;
             }
             //write a conditional if username is blank 
             //if username is eual blank string, return null
            Console.WriteLine("What is your skill level: ");
             string SkillLevel = Console.ReadLine().Trim();
             int numAnswer;
             bool isNumber = int.TryParse(SkillLevel, out numAnswer);
              Console.WriteLine("What is your courage level: ");
             string CourageLevel = Console.ReadLine().Trim();
              double numAnswerTwo;
             bool isNumberTwo = double.TryParse(CourageLevel, out numAnswerTwo);
               
            
         TeamMember teamMember = new TeamMember(Username, numAnswer, numAnswerTwo);
            
            return teamMember;  
        }
    }
  }
}