using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using TodoItem;
using TodoDB;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TodoDBContext>(options => options.UseInMemoryDatabase("Todos"));
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

await app.RunAsync();

[ApiController]
[Route("/")]
public class TodoController : ControllerBase {
    private readonly TodoDBContext _db;

    public TodoController(TodoDBContext db) {
        _db = db;
    }

    [HttpGet()]
    public TodoDBContext<TodoItem> GetItems() {
        return _db;
    }
}