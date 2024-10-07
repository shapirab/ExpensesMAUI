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
        public string Name { get; set; }
        public float Amount { get; set; }
        [MaxLength(25)]
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; }
    }
}
