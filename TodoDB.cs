using Microsoft.EntityFrameworkCore;

using TodoItem;

namespace TodoDB;

public class TodoDBContext : DbContext {
	public TodoDBContext(DbContextOptions<TodoDBContext> optons) {

	}

	public DbSet<TodoItem.TodoItem> Todos {get; set;}
}