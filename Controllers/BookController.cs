using LibraryManagerApi.Communication.Requests;
using LibraryManagerApi.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagerApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : LibraryManagerApiBaseController
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book),StatusCodes.Status200OK)]
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new Book()
        {
            Id = id,
            Title = "Book Name",
            Genre = BookGenre.Mystery,
            Author = "Book Author",
            Price = 50.00,
            Quantity = 12
        };

        return Ok(response);
    }


    [HttpGet("all")]
    [ProducesResponseType(StatusCodes.Status200OK)] 
    public IActionResult GetAllBooks()
    {
        var response = new List<Book>()
        {
            new Book() { Id = 1, Title = "The Four Winds", Genre = BookGenre.Fiction, Author = "Kristin Hannah", Price = 20, Quantity = 25 },
            new Book() { Id = 2, Title = "Klara and the Sun", Genre = BookGenre.Mystery, Author = "Kazuo Ishiguro", Price = 30, Quantity = 10 },
            new Book() { Id = 3, Title = "The Invisible Life of Addie LaRue", Genre = BookGenre.Fantasy, Author = "V.E. Schwab", Price = 50, Quantity = 40 }
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredBookJson), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult RegisterBook([FromBody] RequestRegisterBookJson request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var response = new ResponseRegisteredBookJson()
        {
            Title = request.Title,
            Genre = request.Genre,
            Author = request.Author,
            Price = request.Price,
            Quantity = request.Quantity,
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)] 
    public IActionResult Update([FromRoute] int id, [FromBody] RequestChangeBookJson request)
    {
        if(!ModelState.IsValid)
            return BadRequest();

        return NoContent(); 
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }

}
