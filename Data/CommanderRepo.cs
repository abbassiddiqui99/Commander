using System.Collections.Generic;
using Models;

namespace Data
{
    public class CommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command{Id=0, HowTo="Boil an egg",Line="Boil water",Platform="Kitchwen"},
                new Command{Id=1, HowTo="Boil a potato",Line="Boil water",Platform="Kitchwen"},
                new Command{Id=2, HowTo="Boil an cake",Line="Boil water",Platform="Kitchwen"},
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg",Line="Boil water",Platform="Kitchwen"};
        }
    }
} 