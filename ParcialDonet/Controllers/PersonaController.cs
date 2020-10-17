using Microsoft.AspNetCore.Mvc;
using Bll;
using Entity;
using Microsoft.Extensions.Configuration;
using System.Linq;


[Route("api/[controller]")]
[ApiController]
public class PersonaController:ControllerBase{
   
   private readonly PersonaService service;
   public IConfiguration Configuration{
       get;
   }

  public PersonaController(IConfiguration configuration)
  {
      Configuration=configuration;
      string conectionString= Configuration["ConnectionStrings:DefaultConnection"];
      service = new PersonaService(conectionString);


  }


  private Persona MapearPersona(PersonaInputModels personaInput){

      var persona = new Persona{
          Identificacion=personaInput.Identificacion,
          Nombres=personaInput.Nombres,
          Sexo=personaInput.Sexo,
          Edad=personaInput.Edad,
         Departamento=personaInput.Departamento,
         Ciudad=personaInput.Ciudad,
         Modalidad=personaInput.Modalidad,
         Valor=personaInput.Valor,
        Fecha=personaInput.Fecha,
      };
      return persona;

  }
  // post : api/persona
   
   [HttpPost]
  public ActionResult<PersonaViewModel> Post(PersonaInputModels personaInput){


        Persona persona   =  MapearPersona(personaInput);
        var response = service.Guardar(persona);  
        if(response.Error){
            return BadRequest(response.Mensaje);
        } 
        return Ok(response.Persona);
  }
}


