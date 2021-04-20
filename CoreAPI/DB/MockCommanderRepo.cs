using CoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPI.DB
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var Commands = new List<Command>
            {
                new Command {   Id = 0, HowTo = "boil an egg", Line ="boil water", Platform= "Kettle & Water" },
                new Command {   Id = 1, HowTo = "Cut a bread", Line ="Get a knife", Platform= "Knife and choppingboard" },
                new Command {   Id = 2, HowTo = "Fill water", Line ="get the water", Platform= "Can and water" },
                new Command {   Id = 3, HowTo = "Clean Car", Line ="Spray the car", Platform= "Towel and cleaners" }
            };
            return Commands;
        }
        

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo = "boil an egg",
                Line ="boil water",
                Platform= "Kettle & Water"
            };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
