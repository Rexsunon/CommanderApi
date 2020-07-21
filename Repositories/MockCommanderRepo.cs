using System.Collections.Generic;
using Commander.Models;

namespace Commander.Repositories
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Start node.js app", Line = "node index", Platform = "Windows" };
        }

        public IEnumerable<Command> GetAllCommand()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Start node.js app", Line = "node index", Platform = "Windows" },
                new Command { Id = 1, HowTo = "How to clone git repo", Line = "git clone <repo name>", Platform = "Linux" },
                new Command { Id = 2, HowTo = "Update linux packages", Line = "apt-get update", Platform = "Linux" }
            };

            return commands;
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}