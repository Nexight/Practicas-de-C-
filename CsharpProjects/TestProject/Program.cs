using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");
#region TryParse
//El método int.TryParse() devuelve true si se ha convertido con éxito la variable stringvalue en una int; en caso contrario, devuelve false.
// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }

// if (result > 0)
//    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

/*  Ejercicio de TryParse

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// decimal total = 0m;
// string message ="";

// for(int i = 0; i < values.Length; i++)
// {
//     decimal result = 0m;
//     if(decimal.TryParse(values[i], out result))
//     {     
//         total += result;
//     }
//     else
//     {
//         message += values [i];
//     }
// }
// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");
*/
/*Practica de conversion
    // int value1 = 11;
    // decimal value2 = 6.2m;
    // float value3 = 4.3f;

    // int result1 = (int)Math.Round((decimal)value1 / value2);
    // // convert.ToInt32(value1 / value2) redondea el resultado
    // Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

    // decimal result2 = value2 / (decimal)value3;
    // Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

    // float result3 = value3 / value1;
    // Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/ 
#endregion
#region Metodos para matrices
/* Array.Clear():
Este método se utiliza para establecer un rango de elementos en un arreglo a su valor predeterminado.
Por ejemplo, si el arreglo es de tipo int, los elementos se establecerán en 0. Si es de tipo string, se establecerán en null.

int[] numeros = { 1, 2, 3, 4, 5 };
Array.Clear(numeros, 1, 3); // Borra los elementos en las posiciones 1 a 3 (inclusive)

// El arreglo 'numeros' ahora será: { 1, 0, 0, 0, 5 }

*/
/*Array.Resize():
Array.Resize(): Este método se utiliza para cambiar el tamaño de un arreglo.
Si el nuevo tamaño es mayor que el tamaño actual, se crea un nuevo arreglo y los elementos existentes se copian a este nuevo arreglo. 
Si el nuevo tamaño es menor, los elementos excedentes se descartan.

int[] numeros = { 1, 2, 3, 4, 5 };
Array.Resize(ref numeros, 7); // Redimensiona el arreglo a un tamaño de 7

// El arreglo 'numeros' ahora será: { 1, 2, 3, 4, 5, 0, 0 }

Array.Resize(ref numeros, 3); // Redimensiona el arreglo a un tamaño de 3

// El arreglo 'numeros' ahora será: { 1, 2, 3 }

*/
/*Array.Sort():
Este método se utiliza para ordenar los elementos de un arreglo o una lista en orden ascendente.
Si necesitas ordenar en orden descendente, puedes usar el método Array.Reverse() después de ordenar.

int[] numeros = { 5, 3, 1, 4, 2 };
Array.Sort(numeros); // Ordena los elementos en orden ascendente

// El arreglo 'numeros' ahora será: { 1, 2, 3, 4, 5 }
*/
/*Array.Reverse():
.Reverse(): Este método se utiliza para invertir el orden de los elementos en un arreglo o una lista.

int[] numeros = { 1, 2, 3, 4, 5 };
Array.Reverse(numeros); // Invierte el orden de los elementos

// El arreglo 'numeros' ahora será: { 5, 4, 3, 2, 1 }

*/
/*Array.Split():
Este método se utiliza para dividir un arreglo en subarreglos más pequeños.
Puedes especificar el tamaño de los subarreglos o utilizar un delimitador para dividir el arreglo.

string texto = "Hola,Mundo,C#";
string[] palabras = texto.Split(','); // Divide la cadena en subcadenas usando ',' como delimitador

// El arreglo 'palabras' ahora será: { "Hola", "Mundo", "C#" }

*/
/*Array.Join():
Este método se utiliza para combinar los elementos de un arreglo o una lista en una sola cadena.
Puedes especificar un delimitador opcional para separar los elementos en la cadena resultante.

string[] palabras = { "Hola", "Mundo", "C#" };
string texto = string.Join(" ", palabras); // Une las subcadenas en una sola cadena usando ' ' como delimitador

// La cadena 'texto' ahora será: "Hola Mundo C#"

*/
/*ToCharArray():
El método ToCharArray() en C# se utiliza para convertir una cadena (string) en un arreglo de caracteres (char). 
Esto te permite trabajar con cada carácter de la cadena individualmente.

string texto = "Hola Mundo";
char[] caracteres = texto.ToCharArray(); // Convierte la cadena en un arreglo de caracteres

// El arreglo 'caracteres' ahora será: { 'H', 'o', 'l', 'a', ' ', 'M', 'u', 'n', 'd', 'o' }


*/
#endregion
#region Formato de cadenas

/*Formato Compuesto
El formato compuesto es una forma de formatear cadenas en C# utilizando marcadores de posición y argumentos adicionales.
Puedes utilizar el método string.Format() para aplicar el formato compuesto a una cadena.
marcadores de posicion: {0}, {1}, {2}, etc.

Ejemplo:

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
-
Output:
Hello World!
-
Los tipos de datos y las variables de un tipo de datos determinado tienen "métodos auxiliares" integrados para facilitar tareas concretas.
La cadena literal "{0} {1}!" forma una plantilla, y algunos de sus elementos se reemplazarán en tiempo de ejecución.
El token {0} se reemplaza por el primer argumento después de la plantilla de cadena, es decir, el valor de la variable first.
El token {1} se reemplaza por el segundo argumento después de la plantilla de cadena, es decir, el valor de la variable second.
*/

/*Interpolación de Cadenas
La interpolación de cadenas es una forma más sencilla y legible de formatear cadenas en C#.
Puedes utilizar el prefijo $ antes de una cadena para habilitar la interpolación de cadenas.
En lugar de usar marcadores de posición, puedes insertar directamente variables o expresiones dentro de la cadena.

Ejemplo:

string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
-
Output:
Hello World!
World Hello!
Hello Hello Hello!
*/
/*Formato moneda
El formato de moneda en C# se puede aplicar utilizando el especificador de formato ":C".
Puedes utilizar el especificador de formato ":C" con el método string.Format() o la interpolación de cadenas.
El resultado varia segun la configuracion regional del sistema.

Ejemplo:

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
-
Output:
Price: $123.45 (Save $50.00)
*/
/*Aplicación de formato numérico
El formato numérico en C# se puede aplicar utilizando especificadores de formato como "N" para números con separadores de miles y decimales.
El especificador de formato numérico N hace que los números se lean mejor.

Ejemplo:

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
-
Output:
Measurement: 123,456.789 units

Si se quiere mas precisión, se puede agregar un número después de la N, como en {measurement:N5}.
*/
/*Aplicación de formato a porcentajes
El formato de porcentaje en C# se puede aplicar utilizando el especificador de formato ":P".
Puedes utilizar el especificador de formato ":P" con el método string.Format() o la interpolación de cadenas.

Ejemplo:

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
-
Output:
Tax rate: 36.79%
*/
/*Combinación de enfoques de formato
Puedes combinar diferentes enfoques de formato en una sola cadena en C#.
Por ejemplo, puedes aplicar el formato de moneda y el formato de porcentaje a diferentes partes de la cadena.

Ejemplo:
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);
-
Output:
You saved $7.56 off the regular $67.55 price. A discount of 11.18%!
*/

#endregion
#region Bonus! Metodos de string utiles
/*Metodos
    Métodos que convierten una cadena en mayúsculas o minúsculas (ToUpper(), ToLower())
    Métodos que reemplazan o eliminan espacios en blanco (Replace(), Remove())
    Métodos que agregan espacios en blanco para fines de formato (PadLeft(), PadRight())
    Métodos que comparan dos cadenas o facilitan la comparación (Trim(), TrimStart(), TrimEnd(), GetHashcode(), la propiedad Length)
    Métodos que ayudan a determinar lo que está dentro de una cadena, o incluso a recuperar solo una parte de la cadena (Contains(), StartsWith(), EndsWith(), Substring())
    Métodos que cambian el contenido de la cadena mediante el reemplazo, la inserción o la eliminación de elementos (Replace(), Insert(), Remove())
    Métodos que convierten una cadena en una matriz de cadenas o caracteres (Split(), ToCharArray())
*/
#endregion
#region Métodos sobrecargados
/*Métodos sobrecargados
Los métodos sobrecargados son métodos que tienen el mismo nombre pero diferentes parámetros.
Esto permite a los desarrolladores utilizar el mismo nombre de método para realizar tareas similares con diferentes tipos de datos o argumentos.
En C#, un método sobrecargado es otra versión de un método con argumentos distintos o adicionales que modifican ligeramente la funcionalidad del método.
*/
#endregion
