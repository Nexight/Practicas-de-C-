#region challenge Array/For each
/*
string [] pedidos = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach (string item in pedidos)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine($"Posible pedido fraudulento : {item}");
    }
}
*/
#endregion
#region challenge Legibilidad del código

/*
This code reverses a message, counts the number of times 
a particular character appears, then prints the results
to the console window
*/
/*
string story = "The quick brown fox jumps over the lazy dog.";

char[] message = story.ToCharArray();
Array.Reverse(message);

int letterCount  = 0;

foreach (char i in charMessage) 
{
    if (i == 'o') 
    {
        letterCount++; 
    } 
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
*/
#endregion
#region challenge Operadores condicionales- moneda, cara o cruz.

// Random random = new Random();

// int valorMoneda = random.Next(0,2);

// Console.WriteLine($"Resultado:{ (valorMoneda==1? "cara":"cruz")}" );

#endregion
#region challenge desfio logica de decisiones

// User juan = new User("Administrador",60);
// User lucas = new User ("Administrador",55);
// User francisco = new User ("Director",40);
// User franco = new User ("Director",18);
// User marcos = new User("Empleado",5);

// juan.AdminCheck();
// lucas.AdminCheck();
// francisco.AdminCheck();
// franco.AdminCheck();
// marcos.AdminCheck();

// public class User
// {
//     public string Permission {get; private set;}
//     public int Level {get;private set;}

//     public User (string permission, int level )
//     {
//         Permission = permission;
//         Level=level;
//     }
//     public void AdminCheck()
//     {
//         Console.WriteLine
//         (
//             $"{(Permission.Contains("Admin") ? Level > 55 ? "Welcome, Super Admin user.":"Welcome, Admin user.":
//                 Permission.Contains("Director")? Level > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.":"You do not have sufficient privileges.")}"
//         );
//     }
// }
#endregion
#region Challenge reescritura de if-elseif-else usando switch

// // SKU = Stock Keeping Unit. 
// // SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch(product[0])
// {
//     case "01":
//         type ="Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat Pants";
//         break;
//     default:
//         type="Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color="White";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//         size="Small";
//         break;
//     case "M":
//         size="Medium";
//         break;
//     case "L":
//         size="Large";
//         break;
//     default:
//         size="One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

#endregion
#region Challenge ambito de variables

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;

// foreach (int number in numbers)
// {
//     total += number;

//     if (number == 42)
//     {
//        Console.WriteLine("Set contains 42");
//     }
// }
// Console.WriteLine($"Total: {total}");

#endregion
#region Challenge FizzBuzz (uso de for e if)

// for( int i = 1 ; i <= 100 ; i++)
// {
//     if(i % 3 == 0 && i % 5 != 0)
//     {
//         Console.WriteLine($"{i} - Fizz");
//     }else if(i % 5 == 0 && i % 3 != 0)
//     {
//         Console.WriteLine($"{i} - Buzz");
//     }else if(i % 5 == 0 && i % 3 == 0)
//     {
//         Console.WriteLine($"{i} - FizzBuzz");
//     }else
//     {
//         Console.WriteLine(i);
//     }

// }

#endregion
#region  minijuego batalla usando while y do-while
/*
    Estas son las reglas para el juego de batalla que necesita implementar en el proyecto de código:

    * Debes usar la instrucción do-while o la instrucción while como un bucle de juego externo.
    * El héroe y el monstruo comenzarán con 10 puntos de salud.
    * Todos los ataques tendrán un valor comprendido entre 1 y 10.
    * El héroe ataca primero.
    * Imprima la cantidad de salud que ha perdido el monstruo y su salud restante.
    * Si la salud del monstruo es mayor que 0, puede atacar al héroe.
    * Imprima la cantidad de salud que ha perdido el héroe y su salud restante.
    * Continúe con esta secuencia de ataque hasta que la salud del monstruo o del héroe sea cero o menos.
    * Imprima el ganador.
*/
// Personaje Nico = new Personaje("Nicolás",10,0);
// Personaje monstruo = new Personaje ("Manticora",10,0);
// do
// {
//     Nico.Atacar();
//     monstruo.RecibirDaño(Nico.Ataque);
//     monstruo.VidaCheck();

//     if (monstruo.Vida <= 0) {continue;}

//     monstruo.Atacar();
//     Nico.RecibirDaño(monstruo.Ataque);
//     Nico.VidaCheck();

// } while (Nico.Vida > 0 && monstruo.Vida > 0);

// if(Nico.Vida>0)
//     Console.WriteLine($"{Nico.Nombre} ha triunfado sobre {monstruo.Nombre}!");

// else if (monstruo.Vida > 0)

//     Console.WriteLine($"El monstruo {monstruo.Nombre} ha derrotado a {Nico.Nombre}!");

// Console.WriteLine( Nico.Vida > monstruo.Vida ? $"{Nico.Nombre} ha derrotado a {monstruo.Nombre}!!": $"El enemigo {monstruo.Nombre} ha derrotado a {Nico.Nombre}!");
// public class Personaje
// {
//     public string Nombre {get ; private set;}
//     Random random = new Random();
//     public int Vida {get ; private set;}
//     public int Ataque{get ; private set;}
//     public Personaje (string nombre,int vida, int ataque)
//     {
//         Nombre=nombre;
//         Vida=vida;
//         Ataque=ataque;
//     }
//     public void Atacar()
//     {
//         Ataque = random.Next(1,10);
//     }
//     public void RecibirDaño(int daño)
//     {
//         Vida -= daño;
//         Console.WriteLine($"{Nombre} ha perdido {daño} de vida!");
//     }
//     public void VidaCheck()
//     {
//         if(Vida < 0)
//             Vida=0;
//         Console.WriteLine($"La vida actual de {Nombre} es : {Vida}. ");
//     }
// }
#endregion
#region while, do-while projects.

/*                                                          Proyecto 1: escritura de código que valida la entradad de enteros 

Estas son las condiciones que el primer proyecto de codificación debe implementar:

    La solución debe incluir una iteración do-while o while.

    Antes del bloque de iteración: la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor de enteros entre 5 y 10.

    Dentro del bloque de iteración:

        La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
        La solución debe asegurarse de que la entrada es una representación válida de un entero.
        Si el valor del entero no está comprendido entre 5 y 10, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor del entero entre 5 y 10.
        La solución debe garantizar que el valor de enteros está comprendido entre 5 y 10 antes de salir de la iteración.
        Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.
*/
/*
string? valorEscrito;
int valorNumerico = 0;

bool esEntero = false;
bool numeroValido = false;

Console.WriteLine($"Por favor ingrese un numero entero entre 5 y 10.");

do
{
    valorEscrito = Console.ReadLine();
    
    esEntero = int.TryParse(valorEscrito, out valorNumerico); 
    if(esEntero)
    {
      if(valorNumerico>=5 && valorNumerico<=10)
      {
        numeroValido=true;
      }else 
        Console.WriteLine("El numero ingresado no se encuentra dentro del rango valido. Intentelo nuevamente.");

    }else
        Console.WriteLine($"El valor ingresado no es valido, intentelo nuevamente.");

}
while(!numeroValido);

Console.WriteLine($"El número ingresado ({valorNumerico}) ha sido aceptado.");
*/
/*            --------------------------------------------------------------------------------------------------------------------------------------------------------------------     
                                                             Proyecto de código 2: escritura de código que valida la entrada de cadena

Estas son las condiciones que el segundo proyecto de codificación debe implementar:

    La solución debe incluir una iteración do-while o while.

    Antes del bloque de iteración, la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario uno de los tres nombres de rol: Administrador, Director o Usuario.

    Dentro del bloque de iteración:

        La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
        La solución debe garantizar que el valor especificado coincide con una de las tres opciones de rol.
        La solución debe usar el método Trim() en el valor de entrada para omitir los caracteres de espacio iniciales y finales.
        La solución debe usar el método ToLower() en el valor de entrada para omitir el caso.
        Si el valor especificado no coincide con una de las opciones de rol, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario una entrada válida.
        Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.

*/

// string? rolIngresado ="";
// string [] roles = {"administrador","director","usuario"};

// bool permisoValido = false;

// Console.WriteLine($"Ingrese su rol.(Administrador,Manager, o Usuario)");
// while(!permisoValido)
// {
//     rolIngresado = Console.ReadLine();
//     if(rolIngresado != null)
//     {
//         foreach (string rol in roles)
//         {
//             if(rolIngresado.Trim().ToLower() == rol)
//             {
//                 Console.WriteLine($"Rol ingresado correctamente.");
//                 permisoValido = true;
//                 break;
//             }
//         }
//         Console.WriteLine($"El rol ingresado no tiene acceso.");
//     }else 
//         Console.WriteLine("Por favor ingrese un rol valido.");
// }
// Console.WriteLine($"Bienvenido {rolIngresado}.");
/*            --------------------------------------------------------------------------------------------------------------------------------------------------------------------   
                                                                Proyecto de código 3: escritura de código que procesa el contenido de una matriz de cadenas
                                                
La solución debe usar la siguiente matriz de cadenas para representar la entrada en la lógica de codificación:   

    string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

La solución debe declarar una variable de enteros denominada periodLocation que se pueda usar para contener la ubicación del carácter de punto dentro de una cadena.

La solución debe incluir un bucle externo foreach o for que se pueda usar para procesar cada elemento de cadena de la matriz. La variable de cadena que procesará dentro de los bucles debe denominarse myString.

En el bucle externo, la solución debe usar el método IndexOf() de la clase String para obtener la ubicación del primer carácter de punto de la variable myString. La llamada al método debe ser similar a myString.IndexOf("."). Si no hay ningún carácter de punto en la cadena, se devolverá un valor de -1.

La solución debe incluir un bucle interno do-while o while que se pueda usar para procesar la variable myString.

En el bucle interno, la solución debe extraer y mostrar (escribir en la consola) cada frase contenida en cada una de las cadenas que se procesan.

En el bucle interno, la solución no debe mostrar el carácter de punto.

En el bucle interno, la solución debe usar los métodos Remove(), Substring() y TrimStart() para procesar la información de cadena.
*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation = 0;

string myString ="";

foreach(string sentence in myStrings)
{
    myString = sentence;
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while(periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation +1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine($"{mySentence}");
    }
    mySentence=myString.Trim();
    Console.WriteLine(mySentence);
}
#endregion
//Console.WriteLine($"Fin.");