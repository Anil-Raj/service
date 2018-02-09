using Microsoft.EntityFrameworkCore;

namespace service.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }
        //   public TodoContext() : base("DefaultConnection")
        // {

        // }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TransactionItem> TransactionItems { get; set; }
    }
}