
string empleado;
ushort horasTrabajadas;
decimal pagoHora;

while (true)
{
    Console.WriteLine("====================================");
    Console.WriteLine("=== SISTEMA DE CÁLCULO DE NÓMINA ===");
    Console.WriteLine("====================================");

    Console.Write("Ingrese el nombre del empleado: ");
    empleado = Console.ReadLine();

    Console.Write("Ingrese las horas trabajadas: ");
    if (!ushort.TryParse(Console.ReadLine(), out horasTrabajadas))
    {
        Console.WriteLine("Valor inválido. Presione una tecla para reintentar...");
        Console.ReadKey();
        Console.Clear();
        continue;
    }

    Console.Clear();
    Console.WriteLine("====================================");
    Console.WriteLine("=== SISTEMA DE CÁLCULO DE NÓMINA ===");
    Console.WriteLine("====================================");

    Console.Write("Ingrese el pago por hora en RD$: ");
    if (!decimal.TryParse(Console.ReadLine(), out pagoHora))
    {
        Console.WriteLine("Valor inválido. Presione una tecla para reintentar...");
        Console.ReadKey();
        Console.Clear();
        continue;
    }

    decimal salarioBruto = horasTrabajadas * pagoHora;

    Console.WriteLine();
    Console.WriteLine("=== RESUMEN ===");
    Console.WriteLine($"El Empleado {empleado} tiene:");
    Console.WriteLine($"Horas Trabajadas: {horasTrabajadas} horas");
    Console.WriteLine($"Pago por hora: RD${pagoHora}");
    Console.WriteLine($"Salario Bruto de RD${salarioBruto}");

    break;

}





