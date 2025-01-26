namespace CalculadoraGen.Base
{
    #region LISTA GENERICA
    public class ListaNum<T> where T : struct
    {
        #region PROPIEDADES

        // LISTA QUE ALMACENA LOS DATOS
        private List<T> NumLista = new List<T>();

        #endregion

        #region METODOS DE LA LISTA

        /// <summary>
        /// AGREGA LOS NUMEROS A LA LISTA
        /// </summary>
        /// <param name="numero">NUMERO QUE SE AGREGA</param>
        public void NumAgregar(T numero)
        {
            NumLista.Add(numero);
        }

        /// <summary>
        /// OBTIENE LA LISTA DE NUMEROS COMPLETA
        /// </summary>
        /// <returns>LISTA DE LOS NUMEROS DIGITADOS</returns>
        public List<T> NumObtener()
        {
            return NumLista;
        }

        #endregion

        #region METODO DE OPERACION
        /// <summary>
        /// REALIZA LAS OPERACIONES EN LOS ELEMENTOS DE LA LISTA
        /// </summary>
        /// <param name="operacion">FUNCIONA DELEGADA QUE REPRESENTA LA OPERACION MATEMATICA</param>
        /// <returns>RESULTADO DE LA OPERACION</returns>
        public T RealizaOperacion(Operaciones.Operacion<T> operacion)
        {
            if (NumLista.Count < 2)
                throw new InvalidOperationException("Error: Se necesira al menos 2 numeros para realizar la operacion.");

            T resultado = NumLista[0];
            for (int i = 1; i < NumLista.Count; i++)
            {
                resultado = operacion(resultado, NumLista[i]);
            }
            return resultado;
        }

        #endregion


    }
    #endregion
}
