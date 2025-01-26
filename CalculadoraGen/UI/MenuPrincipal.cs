using CalculadoraGen.Services;


namespace CalculadoraGen.UI
{
    public class MenuPrincipal
    {

        #region MENU PRINCIPAL
        /// <summary>
        /// ADMINISTRA LA INTECCION CON EL USUARIO
        /// </summary>
        public void MenPrincipal()
        {
            
            // LISTA PARA ALMACENAR LOS NUMEROS
            var listaNumeros = new List<string>();
            var servicio = new CalculadoraService();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("========== Calculadora ==========\n");
                Console.WriteLine("[1]. Ingresar números");
                Console.WriteLine("[2]. Realizar operaciones");
                Console.Write("\nElige una opción: ");
                string opcion = Console.ReadLine();

                try
                {
                    switch (opcion)
                    {
                        case "1":
                            SolicitarNumeros(listaNumeros);
                            break;
                        case "2":
                            if (listaNumeros.Count < 2)
                            {
                                Console.WriteLine("Se necesitan al menos 2 números para realizar una operación.");
                                Console.ReadKey();
                                break;
                            }
                            servicio.DeterminarTipo(listaNumeros);
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intenta de nuevo.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                }

                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
            }
            
        }

        #endregion

        #region SOLICITAR NÚMEROS
        /// <summary>
        /// SOLICITA LOS NUMEROS Y LOS ALMACENA
        /// </summary>
        static void SolicitarNumeros(List<string> listaNumeros)
        {
            try
            {
                Console.Write("\n¿Cuántos números deseas ingresar? ");
                if (!int.TryParse(Console.ReadLine(), out int cantidad) || cantidad <= 0)
                {
                    throw new FormatException("La cantidad ingresada no es válida. Debe ser un número entero mayor a 0.");
                }

                for (int i = 0; i < cantidad; i++)
                {
                    bool numeroValido = false;

                    while (!numeroValido)
                    {
                        Console.Write($"Ingresa el número {i + 1}: ");
                        string entrada = Console.ReadLine();

                        // VERIFICA SI SE ESTA INGRESANDO UN NUMERO VALIDO
                        if (int.TryParse(entrada, out _) ||
                            float.TryParse(entrada, out _) ||
                            double.TryParse(entrada, out _) ||
                            decimal.TryParse(entrada, out _))
                        {
                            // ALMACENA LOS NUMEROS
                            listaNumeros.Add(entrada);
                            numeroValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Error: Solo se permiten números. Intenta de nuevo.");
                        }
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error de formato: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al ingresar números: {ex.Message}");
            }
        }
        #endregion

    }
}
