using DeepRack.Data;
using DeepRack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DeepRack.API_Collection.NotesAPI;

[Route("api/[controller]")]
[ApiController]
public class NotesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public NotesController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Notes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Notes>>> GetNotes()
    {
        return await _context.Notes.ToListAsync();
    }

    // GET: api/Notes/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Notes>> GetNotes(int id)
    {
        var notes = await _context.Notes.FindAsync(id);

        if (notes == null) return NotFound();

        return notes;
    }

    // PUT: api/Notes/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutNotes(int id, Notes notes)
    {
        if (id != notes.Id) return BadRequest();

        _context.Entry(notes).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!NotesExists(id)) return NotFound();

            throw;
        }

        return NoContent();
    }

    // POST: api/Notes
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Notes>> PostNotes(Notes notes)
    {
        _context.Notes.Add(notes);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetNotes", new { id = notes.Id }, notes);
    }

    // DELETE: api/Notes/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteNotes(int id)
    {
        var notes = await _context.Notes.FindAsync(id);
        if (notes == null) return NotFound();

        _context.Notes.Remove(notes);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool NotesExists(int id)
    {
        return _context.Notes.Any(e => e.Id == id);
    }
}