Console.Write("Ingrese su dia de nacimiento (1-31): ");
int dia = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese su mes de nacimiento (1-12): ");
int mes = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n--- SU RESULTADO ---");

if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
{
    Console.WriteLine("Signo: Acuario");
    Console.WriteLine("Horoscopo: Tu creatividad e innovacion te abriran nuevas puertas hoy.");
}
else if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
{
    Console.WriteLine("Signo: Piscis");
    Console.WriteLine("Horoscopo: Confia en tu intuicion, te guiara por el camino correcto.");
}
else if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
{
    Console.WriteLine("Signo: Aries");
    Console.WriteLine("Horoscopo: Tu energia y dinamismo te ayudaran a superar cualquier reto.");
}
else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
{
    Console.WriteLine("Signo: Tauro");
    Console.WriteLine("Horoscopo: La paciencia y perseverancia seran tus mejores aliadas.");
}
else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
{
    Console.WriteLine("Signo: Geminis");
    Console.WriteLine("Horoscopo: Excelente dia para comunicarse y compartir ideas.");
}
else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
{
    Console.WriteLine("Signo: Cancer");
    Console.WriteLine("Horoscopo: Conecta con tus seres queridos y disfruta de la armonia.");
}
else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
{
    Console.WriteLine("Signo: Leo");
    Console.WriteLine("Horoscopo: Tu liderazgo natural brillara en cada proyecto.");
}
else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
{
    Console.WriteLine("Signo: Virgo");
    Console.WriteLine("Horoscopo: La organizacion te llevara a alcanzar tus metas.");
}
else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
{
    Console.WriteLine("Signo: Libra");
    Console.WriteLine("Horoscopo: Busca el equilibrio y la paz en tus relaciones.");
}
else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
{
    Console.WriteLine("Signo: Escorpio");
    Console.WriteLine("Horoscopo: Tu determinacion te permitira vencer cualquier obstaculo.");
}
else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
{
    Console.WriteLine("Signo: Sagitario");
    Console.WriteLine("Horoscopo: Un espiritu aventurero te llevara a vivir nuevas experiencias.");
}
else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
{
    Console.WriteLine("Signo: Capricornio");
    Console.WriteLine("Horoscopo: Tu disciplina dara frutos muy pronto.");
}
else
{
    Console.WriteLine("Fecha no valida.");
}