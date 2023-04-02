using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

[ApiController]
[Route("Api/v1/Person")]
public class PersonController : ControllerBase
{

[HttpGet]
public async Task<IActionResult> Get(){

    var person = new Person{
        Id = 1,
        Name = "Rafael",
        Address = "Rua Antonio Rodrigues da Costa - Casa Branca"
      };

    return Ok(person);
}

[HttpPost]
[ProducesResponseType(typeof(Person),204)]
public async Task<IActionResult> Post([FromBody] Person person){

    if(person is null) return BadRequest();

    IList<Person> persons = new List<Person>();
    persons.Add(person);

    return Ok(person);
}

}