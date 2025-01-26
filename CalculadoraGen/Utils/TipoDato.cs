
namespace CalculadoraGen.Utils
{
    public static class TipoDato
    {

        #region NOMBRE TIPO DE DATO
        /// <summary>
        /// ASIGNA UN NOMBRE AMIGABLE A CADA TIPO DE DATO 
        /// </summary>
        public static string TipoDatoNombre<T>()
        {
            if (typeof(T) == typeof(int))
                return "int";
            else if (typeof(T) == typeof(float))
                return "float";
            else if (typeof(T) == typeof(double))
                return "double";
            else if (typeof(T) == typeof(decimal))
                return "decimal";
            else
                return typeof(T).Name;
        }
        #endregion

    }
}
