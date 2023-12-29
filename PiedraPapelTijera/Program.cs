using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("¡Bienvenido al Juego de Piedra, Papel o Tijera!");

        string[] opciones = { "Piedra", "Papel", "Tijera" };

        while (true)
        {
            Console.WriteLine("Elige tu jugada:");
            Console.WriteLine("1. Piedra");
            Console.WriteLine("2. Papel");
            Console.WriteLine("3. Tijera");
            Console.WriteLine("0. Salir");

            int eleccionUsuario;

            // Validar la entrada del usuario
            while (!int.TryParse(Console.ReadLine(), out eleccionUsuario) || eleccionUsuario < 0 || eleccionUsuario > 3)
            {
                Console.WriteLine("Por favor, elige una opción válida.");
            }

            if (eleccionUsuario == 0)
            {
                break; // Salir del bucle si el usuario elige salir
            }

            string jugadaUsuario = opciones[eleccionUsuario - 1];
            Console.WriteLine($"Has elegido: {jugadaUsuario}");

            // Generar jugada aleatoria de la computadora
            Random random = new Random();
            int jugadaComputadora = random.Next(0, 3);
            string jugadaComputadoraTexto = opciones[jugadaComputadora];
            Console.WriteLine($"La computadora elige: {jugadaComputadoraTexto}");

            // Determinar el resultado del juego
            DeterminarGanador(jugadaUsuario, jugadaComputadoraTexto);
        }

        Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
    }

    static void DeterminarGanador(string jugador, string computadora)
    {
        if (jugador == computadora)
        {
            Console.WriteLine("¡Es un empate!");
        }
        else if ((jugador == "Piedra" && computadora == "Tijera") ||
                 (jugador == "Papel" && computadora == "Piedra") ||
                 (jugador == "Tijera" && computadora == "Papel"))
        {
            Console.WriteLine("¡Ganaste!");
        }
        else
        {
            Console.WriteLine("¡La computadora gana!");
        }
    }
}
