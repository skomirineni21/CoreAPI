using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreAPI.DB
{
    public class CommanderContext: DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }
        public DbSet<Command> Commands { get; set; }
    }
}
