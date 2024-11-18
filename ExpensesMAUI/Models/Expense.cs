using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesMAUI.Models
{
    public class Expense
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public float Amount { get; set; }
        [MaxLength(25)]
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        //TODO: This is the reason the Expense Service is unable to generate the table
        public Category Category { get; set; }
    }
}
