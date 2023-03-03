using System; 

namespace planYourHeist {
    public class TeamMember {
        public string Name {get; set;} //make sure to make these public so rest of app can access them

        public int Level {get; set;}

        public double Courage {get; set;}

//CONSTRUCTOR
        public TeamMember(string name, int level, double courage){
            Name = name;
            Level = level;
            Courage = courage;
        }

        //get description type method from adventurer thing

         public string GetDescription(){
       return $"Team Member: {Name} has a skill level of: {Level} and a courage level of: {Courage}";
    }
    }
}