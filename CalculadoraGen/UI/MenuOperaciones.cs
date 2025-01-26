using CalculadoraGen.Base;
using CalculadoraGen.Utils;


namespace CalculadoraGen.UI
{
    #region MENU OPERACIONES
    /// <summary>
    /// ADMINISTRA LA INTECCION CON EL USUARIO
    /// </summary>
    public class MenuOperaciones<T> where T : struct
    {
        private readonly ListaNum<T> _lista;

        public MenuOperaciones(ListaNum<T> lista) => _lista = lista;

        public void MenOperaciones()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"========== Calculadora ==========\n");
                Console.WriteLine($"Tipo de dato: ({TipoDato.TipoDatoNombre<T>()})\n");
                Console.WriteLine("[1]. Sumar");
                Console.WriteLine("[2]. Restar");
                Console.WriteLine("[3]. Multiplicar");
                Console.WriteLine("[4]. Dividir");
                Console.WriteLine("[5]. Regresar al menú principal");
                Console.Write("\nElige una opción: ");
                string opcion = Console.ReadLine();

                try
                {
                    switch (opcion)
                    {
                        case "1":
                            MostrarResultado(_lista, Operaciones.Suma);
                            break;
                        case "2":
                            MostrarResultado(_lista, Operaciones.Resta);
                            break;
                        case "3":
                            MostrarResultado(_lista, Operaciones.Multiplica);
                            break;
                        case "4":
                            MostrarResultado(_lista, Operaciones.Divide);
                            break;
                        case "5":
                            return;
                        default:
                            Console.WriteLine("Opción no válida. Intenta de nuevo.");
                            break;
                    }
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                }

                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        #region MOSTRAR RESULTADO
        /// <summary>
        /// MUESTRA EL RESULTADO DE LA OPERACION
        /// </summary>
        private void MostrarResultado<T>(ListaNum<T> lista, Operaciones.Operacion<T> operacion) where T : struct
        {
            try
            {
                var resultado = lista.RealizaOperacion(operacion);
                int indice = 1;

                // MUESTRA EL RESULTADO DE LA OPERACION
                Console.WriteLine("-----------------------");
                Console.WriteLine("| Numeros en la lista |");
                Console.WriteLine("-----------------------");
                foreach (var numero in _lista.NumObtener())
                {
                    Console.WriteLine($"| [{indice++}] - {numero,-13} |");
                }
                Console.WriteLine("-----------------------");
                Console.WriteLine($"| Resultado: {resultado,-8} |");
                Console.WriteLine("-----------------------");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mostrar el resultado: {ex.Message}");
            }
        }
        #endregion
    }
    #endregion



}
