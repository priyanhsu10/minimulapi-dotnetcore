using System;
using Microsoft.EntityFrameworkCore;
using minialapi2.Requests;

namespace minialapi2.Repositories
{
    public class TodoCotext:DbContext
    {
        public TodoCotext(DbContextOptions<TodoCotext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Todo> Todos { get; set; }
    }
}

