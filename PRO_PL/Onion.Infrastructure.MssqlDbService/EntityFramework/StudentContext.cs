using Microsoft.EntityFrameworkCore;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Infrastructure.MssqlDbService.EntityFramework
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s16485;Integrated Security=True");
        }

        public DbSet<Student> Students { get; set; }
    }
}
