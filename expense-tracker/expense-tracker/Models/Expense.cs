using System;
using System.ComponentModel.DataAnnotations;

namespace expense_tracker.Models
{
    public class Expense
    {
        public Expense()
        {
        }

        [Key]
        public int Id { get; set; }
        public string ExpenseName { get; set; }
        public decimal ExpenseAmount { get; set; }
        public DateTime ExpenseDate { get; set; }
        //TODO: Expense Category, SubCategory (Eg: HomeExpense - Internet)
    }
}
