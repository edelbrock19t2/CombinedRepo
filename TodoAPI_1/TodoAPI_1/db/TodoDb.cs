using Microsoft.EntityFrameworkCore;
using TodoAPI_1.model;

namespace TodoAPI_1.db
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options) : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
