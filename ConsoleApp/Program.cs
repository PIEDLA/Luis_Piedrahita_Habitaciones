<<<<<<< HEAD
﻿Console.WriteLine("Hello, World!");
=======
﻿Console.WriteLine("Hello, World!");
>>>>>>> e5ae53ad7aa8a555f624b53071da3280709b15fb

public class ConjuntoReci
{
    public decimal id;
    public String? NombreConjunto;
}

public class Torres
{
    public decimal id;
    public String? NombreTorre;
    public List<ConjuntoReci>? Conjunto;
}

public class Habitaciones
{
    public decimal id;
    public String? Nombre;
    public Torres? Torre;
}

public class Tipos
{
    public decimal id;
    public String? NombreTipo;
    public List<Habitaciones>? Habitacion;
}
