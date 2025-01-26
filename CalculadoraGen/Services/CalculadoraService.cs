using CalculadoraGen.Base;
using CalculadoraGen.UI;


namespace CalculadoraGen.Services
{
    public class CalculadoraService
    {
        #region DETERMINAR TIPOS DE DATOS
        /// <summary>
        /// DETERMINA EL TIPO DE DATO MAS ADECUADO PARA LOS CALCULOS
        /// </summary>
        public void DeterminarTipo(List<string> listaNumeros)
        {
            try
            {
                if (listaNumeros.TrueForAll(x => int.TryParse(x, out _)))
                {
                    EjecutarCalculadora(listaNumeros.ConvertAll(x => int.Parse(x)));
                }
                else if (listaNumeros.TrueForAll(x => float.TryParse(x, out _)))
                {
                    EjecutarCalculadora(listaNumeros.ConvertAll(x => float.Parse(x)));
                }
                else if (listaNumeros.TrueForAll(x => double.TryParse(x, out _)))
                {
                    EjecutarCalculadora(listaNumeros.ConvertAll(x => double.Parse(x)));
                }
                else
                {
                    EjecutarCalculadora(listaNumeros.ConvertAll(x => decimal.Parse(x)));
                }

                // LIMPIA LA LISTA AL VOLVER AL MENU PRINCIPAL
                listaNumeros.Clear();
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error de formato al determinar el tipo de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado al determinar el tipo de datos: {ex.Message}");
            }
        }
        #endregion



        #region EJECUTAR CALCULADORA
        /// <summary>
        /// EJECUTA LA CALCULADORA
        /// </summary>
        private void EjecutarCalculadora<T>(List<T> numeros) where T : struct
        {
            var lista = new ListaNum<T>();
            // AGREGA LOS NUMEROS A LA LISTA
            numeros.ForEach(num => lista.NumAgregar(num));

            var menuOperaciones = new MenuOperaciones<T>(lista);
            menuOperaciones.MenOperaciones();


        }
        #endregion
    }
}
