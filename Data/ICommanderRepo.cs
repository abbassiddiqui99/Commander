using System.Collections.Generic;
using Models;

namespace Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        bool SaveChanges();
        void CreateCommand(Command cmd);

    }
}