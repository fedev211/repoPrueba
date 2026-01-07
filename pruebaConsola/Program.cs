using PersonaNamespace;
using AutoNamespace;

Persona persona1 = new Persona("Juan", 30);
Console.WriteLine($"Nombre: {persona1.Nombre}, Edad: {persona1.Edad}");

Auto auto1 = new Auto("Toyota", "JKU183", 2026, "Rojo", 40000000f);

Console.WriteLine($"Marca: {auto1.Marca}, Patente: {auto1.Patente}, Año: {auto1.Año}, Color: {auto1.Color}, Precio: {auto1.Precio}");

