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
            var commands = new List<Command>{
                 new Command{Id=0, HowTo="Boil The Egg", Line="Boil the water", Platform="Kettle & pan"},
                 new Command{Id=1, HowTo="Boil The Egg", Line="Boil the water", Platform="Kettle & pan"},
                 new Command{Id=2, HowTo="Boil The Egg", Line="Boil the water", Platform="Kettle & pan"},
                 new Command{Id=3, HowTo="Boil The Egg", Line="Boil the water", Platform="Kettle & pan"},
                 new Command{Id=4, HowTo="Boil The Egg", Line="Boil the water", Platform="Kettle & pan"},
                 new Command{Id=5, HowTo="Boil The Egg", Line="Boil the water", Platform="Kettle & pan"}
            };

            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command{Id=0, HowTo="Boil The Egg", Line="Boil the water", Platform="Kettle & pan"};
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