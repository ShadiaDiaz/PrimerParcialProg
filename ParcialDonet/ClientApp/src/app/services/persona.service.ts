import { Injectable } from '@angular/core';
import { Persona } from './../parcial/models/persona';

@Injectable({
  providedIn: 'root'
})
export class PersonaService {

  constructor() { }
  get(): Persona[] {
    return JSON.parse(localStorage.getItem('datos'));
}
post(persona: Persona) {
  let personas: Persona[] = [];
  if (this.get() != null) {
  personas = this.get();
  }
  
  if (personas.find (p=> p.identificacion ==persona.identificacion) == null ){
  personas.push(persona);
  localStorage.setItem('datos', JSON.stringify(personas));
  return "se ha guardado ";
  }
  else{
    "ya se encuentra registrado";
  }
}
total(){
  var total;
  let personas:Persona[]=[];
  if(this.get() != null){
    personas= this.get();
  }
  return personas;
}
} 