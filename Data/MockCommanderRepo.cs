using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id=0, HowTo = "Boil and egg", Line = "Boil water", Platform="Kettle & pan"},
                new Command {Id=1, HowTo = "cut bread", Line = "Get a knife", Platform="knife & chopping board"},
                new Command {Id=2, HowTo = "make a cup of tea", Line = "place teabag in cup", Platform="Kettle & pan"},
            
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id=0, HowTo = "Boil and egg", Line = "Boil water", Platform="Kettle & pan"};

        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}