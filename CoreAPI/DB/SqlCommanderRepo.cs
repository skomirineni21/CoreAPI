using CoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPI.DB
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;
        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentException(nameof(cmd));
            }
            _context.Commands.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentException(nameof(cmd));
            }
            _context.Commands.Remove(cmd);
        }

        public bool SaveChanges()
        {
           return(_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command cmd)
        {
            //nothing
        }

        IEnumerable<Command> ICommanderRepo.GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        Command ICommanderRepo.GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(i => i.Id == id);
        }
    }
}
