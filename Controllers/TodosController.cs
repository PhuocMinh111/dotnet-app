using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using dotnet_app.Models;


[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase 
{
    private DataContext _context;
    public TodoController (DataContext context) 
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<DataContext>> Post (Todos item) 
    {
        _context.Db.Add(item);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(Post), item);
    }


    [HttpGet("id")]

    public async Task<ActionResult<Todos>> GetToDoById (int id)
    {
        var todo = await _context.Db.FindAsync(id);
        if (todo == null)
        {
            return NotFound();
        }
        return todo;
    }
    [HttpDelete]
    public async Task<ActionResult<Todos>> Delete (int id)
    {
        var todo = await _context.Db.FindAsync(id);
        if (todo == null)
        {
            return NotFound();
        }
        _context.Db.Remove(todo);
        await _context.SaveChangesAsync();
        return Accepted();


    }
    // [HttpPut("id")]

   






}