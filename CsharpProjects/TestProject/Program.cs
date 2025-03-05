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