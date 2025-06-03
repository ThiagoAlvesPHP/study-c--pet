using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.GetAll;
using Petfolio.Application.UseCases.Pets.Register;
using Petfolio.Application.UseCases.Pets.Update;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : Controller
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestPetJson register)
    {
        var response = new RegisterPetUserCase().Execute(register);
        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
    {
        var useCase = new UpdatePetUserCase();
        useCase.Execute(id, request);
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllPetJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllPetsUseCase();
        var response = useCase.Execute();

        if (response.Pets.Any())
        {
            return Ok(response);
        }
        
        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseGetByIdJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)
    {
        var useCase = new GetByIdPetUseCase();
        var response = useCase.Execute(id);
        return Ok(response);
    }
}