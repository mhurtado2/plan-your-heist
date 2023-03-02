using System;

namespace planYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamMember CreateNewTeamMember()
            {
            //console write plan your hesit
            Console.WriteLine("Plan Your Heist");
            Console.WriteLine("What is your name: ");
             string Username= Console.ReadLine().Trim();
            Console.WriteLine("What is your skill level: ");
             string SkillLevel = Console.ReadLine().Trim();
             int numAnswer;
             bool isNumber = int.TryParse(SkillLevel, out numAnswer);
              Console.WriteLine("What is your courage level: ");
             string CourageLevel = Console.ReadLine().Trim();
              double numAnswerTwo;
             bool isNumberTwo = double.TryParse(CourageLevel, out numAnswerTwo);
             
            
            // TeamMember teamMember = new TeamMember(Username, numAnswer, numAnswerTwo);

            //create instance of team member

       
            
         TeamMember teamMember = new TeamMember(Username, numAnswer, numAnswerTwo);

        Console.WriteLine(teamMember.GetDescription());
                
            return teamMember;  
        }
        CreateNewTeamMember();   
    }
  }
}