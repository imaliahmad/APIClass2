using _2ndClass.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2ndClass.Data
{
    public class MyDbContext:DbContext
    {
        //public MyDbContext()
        //{
        //    //Database.EnsureDeleted();
        //    //Database.EnsureCreated();
        //    //Database.Migrate();
        //}

        //connectionString
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-T90JGBG\SQLEXPRESS; Database=2ndClass;Trusted_Connection=True;");
        }


        //Dbset
        public DbSet<Departments> Departments { get; set; }
    }
}
