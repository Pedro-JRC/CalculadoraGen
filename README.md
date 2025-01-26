Calculadora Genérica

Descripción General

Esta aplicación es una calculadora genérica que permite al usuario realizar operaciones matemáticas básicas 
(suma, resta, multiplicación y división) sobre una lista de números ingresados. El programa es capaz de manejar 
diferentes tipos de datos numéricos (int, float, double y decimal) y determina automáticamente el tipo más adecuado 
según los números ingresados por el usuario.

El diseño del programa está orientado a la modularidad, utilizando clases específicas para cada funcionalidad, y hace 
uso extensivo de genéricos y delegados para garantizar flexibilidad y escalabilidad.


Métodos Principales

1. Métodos de la Clase ListaNum​
NumAgregar: Agrega un número a la lista.
NumObtener: Devuelve todos los números almacenados en la lista.
RealizaOperacion: Aplica una operación matemática (definida como delegado) sobre los elementos de la lista.

2. Métodos de la Clase Operaciones​
Suma: Realiza la suma de dos números.
Resta: Calcula la diferencia entre dos números.
Multiplica: Calcula el producto de dos números.
Divide: Realiza la división de dos números, lanzando una excepción si el divisor es cero.

3. Métodos de la Clase CalculadoraService​
DeterminarTipo: Identifica el tipo de dato más adecuado para la lista de números y llama a la calculadora correspondiente.
EjecutarCalculadora: Crea una instancia de ListaNum, agrega los números y ejecuta el menú de operaciones.

4. Métodos de la Clase MenuOperaciones​
MenOperaciones: Presenta un menú que permite al usuario seleccionar una operación matemática y ejecutarla.
MostrarResultado: Muestra los números de la lista y el resultado de la operación seleccionada.

5. Métodos de la Clase MenuPrincipal​
MenPrincipal: Administra el flujo principal del programa, permitiendo ingresar números y realizar operaciones.
SolicitarNumeros: Solicita y valida los números ingresados por el usuario.

6. Métodos de la Clase TipoDato​
TipoDatoNombre: Devuelve un nombre amigable para el tipo de dato genérico.

7. Método Principal en Program​
Main: Punto de entrada del programa, que inicia el menú principal.


Excepciones Manejadas

Formato Inválido:

Excepción: FormatException.
Métodos Involucrados: SolicitarNumeros, DeterminarTipo.
Causa: Se ingresa un valor no numérico o fuera de rango.
Manejo: Muestra un mensaje indicando que solo se permiten números válidos.
División por Cero:

Excepción: DivideByZeroException.
Método Involucrado: Divide.
Causa: Intento de dividir por cero.
Manejo: Muestra un mensaje de error indicando que no se puede dividir por cero.
Operaciones con Lista Insuficiente:

Excepción: InvalidOperationException.
Método Involucrado: RealizaOperacion.
Causa: Intento de realizar una operación con menos de dos elementos en la lista.
Manejo: Muestra un mensaje indicando que se necesitan al menos dos números.
Errores Inesperados:

Excepción: Exception.
Métodos Involucrados: MenPrincipal, MenOperaciones, MostrarResultado.
Causa: Error desconocido durante la ejecución.
Manejo: Muestra un mensaje genérico con el detalle del error.
Uso de Genéricos y Delegados


Genéricos:

La clase ListaNum<T> permite manejar diferentes tipos de datos numéricos (int, float, double, decimal), garantizando flexibilidad.
Los métodos en Operaciones también son genéricos, adaptándose al tipo de dato definido en tiempo de ejecución.


Delegados:

La clase Operaciones define un delegado Operacion<T> que representa una operación matemática entre dos números. 
Este delegado se utiliza en el método RealizaOperacion de ListaNum para aplicar dinámicamente la operación seleccionada.
