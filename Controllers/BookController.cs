using Library.Communication.Requests;
using Library.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        Book book = new Book()
        {
            Id = 1,
            Title = "Test",
            Author = "Test",
            Gender = Gender.COMEDIA
        };
        if (book != null)
        {
            return Ok(book);
        }
        else
        {
            return NoContent();
        }
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] string id)
    {
        Book book = new Book()
        {
            Id = 1,
            Title = "Test",
            Author = "Test",
            Gender = Gender.COMEDIA
        };
        if (book != null)
        {
            return Ok(book);
        } else 
        {
            return NotFound();
        }        
    }

    [HttpPost]
    [ProducesResponseType(typeof(Book), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Add([FromBody] RequestAddBook request)
    {
        if (request is null || request.Title is null || request.price <= 0)
        {
            return BadRequest();
        }
        Book book = new Book()
        {
            Id= 1,
            Title = request.Title,
            Author = request.Author,
            Gender = request.Gender,
                    
        };
        return Created(string.Empty, book);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] string id, [FromBody] RequestUpdateBook book)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] string id)
    {
        return NoContent();
    }
}
