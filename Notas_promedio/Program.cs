Datos[] estudiante = new Datos[5];
for (int i = 0; i <= 2; i++)
{
    Console.WriteLine("--------------------------------------------");
    Console.Write("Nombre del estudiante: ");
    estudiante[i].nombre = Console.ReadLine();
    Console.Write("Apellido del estudiante: ");
    estudiante[i].apellido = Console.ReadLine();
    Console.Write("Nota examen parcial: ");
    estudiante[i].ep = double.Parse(Console.ReadLine());
    Console.Write("Nota examen oral: ");
    estudiante[i].eo = double.Parse(Console.ReadLine());
    Console.Write("Nota examen final: ");
    estudiante[i].ef = double.Parse(Console.ReadLine());
    Console.WriteLine("--------------------------------------------");
    estudiante[i].Calfinal = (estudiante[i].ep + estudiante[i].eo + estudiante[i].ef) / 3;
}

for (int i = 0; i <= 2; i++)
{
    Console.WriteLine("");

    if (estudiante[i].Calfinal >= 7)
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Nombre: " + estudiante[i].nombre);
        Console.WriteLine("Apellido: " + estudiante[i].apellido);
        Console.WriteLine("Tu calificacion es aprobatoria: " + estudiante[i].Calfinal);
        Console.WriteLine("--------------------------------------------");
    }
    else
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Nombre: " + estudiante[i].nombre);
        Console.WriteLine("Apellido: " + estudiante[i].apellido);
        Console.WriteLine("Tu calificacion es reprobatoria: " + estudiante[i].Calfinal);
        Console.WriteLine("--------------------------------------------");
    }
}

struct Datos { 
public string nombre;
public string apellido;
public double ep;
public double eo;
public double ef;
public double Calfinal;
}
