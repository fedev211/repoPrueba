using PersonaNamespace;
using AutoNamespace;
using AnimalNamespace;
using PerroNamespace;

Persona persona1 = new Persona("Juan", 30);
Console.WriteLine($"Nombre: {persona1.Nombre}, Edad: {persona1.Edad}");

Auto auto1 = new Auto("Toyota", "JKU183", 2026, "Rojo", 40000000f);

Console.WriteLine($"Marca: {auto1.Marca}, Patente: {auto1.Patente}, Año: {auto1.Año}, Color: {auto1.Color}, Precio: {auto1.Precio}");

string input;

do
{

    Console.WriteLine("1- Crear un animal");
    Console.WriteLine("2- Crear un perro");
    Console.WriteLine("3- Salir ");


    Console.WriteLine("\nSeleccione una opción: ");
    input = Console.ReadLine();


    switch (input)
    {
        case "1":
            Console.WriteLine("Ingrese la especie: ");
            string especie = Console.ReadLine();
            Console.WriteLine("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el peso: ");
            float peso = float.Parse(Console.ReadLine());
            
            Animal animalNuevo = new Animal(especie, edad, peso);

            Console.WriteLine($"Animal creado: Especie - {animalNuevo.Especie}, Edad - {animalNuevo.Edad}, Peso - {animalNuevo.Peso}");
            animalNuevo.HacerSonido();
            break;
        case "2":

            Console.WriteLine("Ingrese la raza: ");
            string raza = Console.ReadLine();
            Console.WriteLine("Ingrese la edad: ");
            int edadPerro = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el peso: ");
            float pesoPerro = float.Parse(Console.ReadLine());

            Perro perroNuevo = new Perro(raza, edadPerro, pesoPerro);

            Console.WriteLine($"Perro creado: Raza - {perroNuevo.Raza}, Edad - {perroNuevo.Edad}, Peso - {perroNuevo.Peso} y su especie es {perroNuevo.Especie}");
            perroNuevo.HacerSonido();

            break;
        default:
            Console.WriteLine("Opción no válida.\n");
            break;
    }

}while(input != "3");
