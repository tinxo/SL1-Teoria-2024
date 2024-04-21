// See https://aka.ms/new-console-template for more information
Console.WriteLine("Datos de un estudiante:");

// Declaración de variables
string nombrePersona = "Cosme Fulanito";
string nroDocumento = "77822943";
int anioIngreso = 2023;
int cantidadMateriasAprobadas = 3;
double promedioSA = 8.25;

// Imprimo los valores
Console.WriteLine($"Datos cargados de {nombrePersona} DNI: {nroDocumento}");
Console.WriteLine($"Año de ingreso: {anioIngreso} - Materias aprobadas: {cantidadMateriasAprobadas}");
Console.WriteLine($"Promedio hasta ahora sin aplazos: {promedioSA}");

// Ingreso de datos
string respuesta;
Console.WriteLine($"Ingrese la nota de un examen para {nombrePersona}:");
respuesta = Console.ReadLine();
double nota;
if (double.TryParse(respuesta, out nota)) {
    if (nota >= 6) {
        Console.WriteLine($"La persona, {nombrePersona}, aprobó el examen con nota: {nota}");
    } else {
        Console.WriteLine($"La persona, {nombrePersona}, no aprobó el examen");
    }
} else {
    Console.WriteLine("No se ingresó un valor válido para la nota.");
}



// Evaluación de la nota