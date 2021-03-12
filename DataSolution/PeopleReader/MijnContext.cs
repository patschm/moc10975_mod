using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleReader
{
    class MijnContext : DbContext
    {
        public MijnContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
