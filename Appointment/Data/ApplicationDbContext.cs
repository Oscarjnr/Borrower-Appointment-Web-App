using Appointment.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Appointment.Data
{
    public class ApplicationDbContext : DbContext 
    {
        internal IEnumerable<Expense> expense;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
         
        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public IEnumerable<Expense> Expense { get; internal set; }
    }
}
