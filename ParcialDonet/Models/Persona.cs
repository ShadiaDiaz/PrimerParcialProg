using System;
using Entity;

public class PersonaInputModels
{
    public string Identificacion { get; set; }
    public string Nombres { get; set; }
    public string Sexo { get; set; }
    public int Edad { get; set; }
    public string Departamento { get; set; }
    public string Ciudad { get; set; }
    public string Modalidad { get; set; }
    public decimal Valor { get; set; }
    public DateTime Fecha { get; set; }
}
public class PersonaViewModel:PersonaInputModels{
    public PersonaViewModel(){
        
    }
    public PersonaViewModel(Persona persona){
     Identificacion=persona.Identificacion;
     Nombres=persona.Nombres;
     Sexo=persona.Sexo;
     Edad=persona.Edad;
     Departamento=persona.Departamento;
     Ciudad=persona.Ciudad;
     Modalidad=persona.Modalidad;
     Valor=persona.Valor;
     Fecha=persona.Fecha;
    }
}