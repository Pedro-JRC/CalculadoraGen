namespace CalculadoraGen.Base
{
    #region CLASE OPERACIONES
    public class Operaciones
    {
        #region DELEGADOS
        /// <summary>
        /// DELEGADO PARA INDICAR OPERACION ENTRE DOS NUMEROS
        /// </summary>
        /// <param name="a">PRIMERO NUMERO</param>
        /// <param name="b">SEGUNDO NUMERO</param>
        /// <returns>RESULTADO</returns>
        public delegate T Operacion<T>(T a, T b) where T : struct;

        #endregion

        #region OPERACIONES

        /// <summary>
        /// SUMA DOS NUMEROS
        /// </summary>
        public static T Suma<T>(T a, T b) where T : struct
        {
            return (dynamic)a + (dynamic)b;
        }

        /// <summary>
        /// RESTA DOS NUMEROS
        /// </summary>
        public static T Resta<T>(T a, T b) where T : struct
        {
            return (dynamic)a - (dynamic)b;
        }

        /// <summary>
        /// MULTIPLICA DOS NUMERO
        /// </summary>
        public static T Multiplica<T>(T a, T b) where T : struct
        {
            return (dynamic)a * (dynamic)b;
        }

        /// <summary>
        /// DIVIDE DOS NUMEROS
        /// </summary>
        public static T Divide<T>(T a, T b) where T : struct
        {
            if ((dynamic)b == 0)
                throw new DivideByZeroException("Error: No se pueden realizar diviciones entre cero");
            return (dynamic)a / (dynamic)b;
        }

        #endregion
    }
    #endregion
}
