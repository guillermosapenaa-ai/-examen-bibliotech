using System.IO;
using System.Collections.Generic;


List<Libro> libros = new List<Libro>();

libros.Add(new Libro("1984", "George Orwell", 1949, true));
libros.Add(new Libro("Rebelión en la granja", "George Orwell", 1945, false));
libros.Add(new Libro("El Quijote", "Miguel de Cervantes", 1605, false));


Console.WriteLine("--- Todos los libros ---");
foreach (Libro l in libros)
{
	Console.WriteLine(l.ToString());
}


Console.WriteLine("--- Libros de Orwell ---");
foreach (Libro l in libros)
{
	if (l.getAutor().Contains("Orwell"))
	{
		Console.WriteLine(l.ToString());
	}
}


Console.WriteLine("--- Fecha de registro ---");
Console.WriteLine(DateTime.Now.ToShortDateString());



StreamWriter writer = File.CreateText("libros.txt");

foreach (Libro l in libros)
{
	writer.WriteLine(l.getTitulo() + ";" + l.getAutor() + ";" + l.getAnyo() + ";" + l.isDisponible());
}

writer.Close();



Console.WriteLine("Fichero guardado correctamente.");



Console.WriteLine(Directory.GetCurrentDirectory());


// Ejercicio 3
GestorBD gestor = new GestorBD();

// Insertar un libro
gestor.Insertar(new Libro("1984", "George Orwell", 1949, true));
Console.WriteLine("Libro insertado correctamente.");

// Leer todos
List<Libro> librosDB = gestor.ObtenerTodos();
Console.WriteLine("--- Libros en la base de datos ---");
foreach (Libro l in librosDB)
{
	Console.WriteLine(l.ToString());
}