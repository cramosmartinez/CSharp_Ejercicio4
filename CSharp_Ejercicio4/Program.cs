//Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado).
Console.WriteLine("Ingrese el precio del producto:");
double precio = Convert.ToDouble(Console.ReadLine());
if (precio < 0)
{
    Console.WriteLine("El precio ingresado no es válido.");
}
else
{
    Console.WriteLine("Ingrese la forma de pago (efectivo o tarjeta):");
    string formaDePago = Console.ReadLine().ToLower();
    if (formaDePago == "tarjeta")
    {
        Console.WriteLine("Ingrese el número de cuenta:");
        string numeroDeCuenta = Console.ReadLine();
        Console.WriteLine("El precio del producto es de $" + precio + " y se pagará con tarjeta. Número de cuenta: " + numeroDeCuenta);
    }
    else if (formaDePago == "efectivo")
    {
        Console.WriteLine("El precio del producto es de $" + precio + " y se pagará en efectivo.");
    }
    else
    {
        Console.WriteLine("La forma de pago ingresada no es válida.");
    }
}