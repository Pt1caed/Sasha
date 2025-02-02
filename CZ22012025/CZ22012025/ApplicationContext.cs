using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ22012025
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public ApplicationContext()
        : base()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                            .AddJsonFile("settings.json") // json файл находится в корневой папке
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
