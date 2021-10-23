using System;
using expense_tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace expense_tracker.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):
            base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
    }


}
