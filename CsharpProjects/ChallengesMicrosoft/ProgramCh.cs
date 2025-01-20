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
Personaje Nico = new Personaje("Nicolás",10,0);
Personaje monstruo = new Personaje ("Manticora",10,0);
do
{
    Nico.Atacar();
    monstruo.RecibirDaño(Nico.Ataque);
    monstruo.VidaCheck();

    if (monstruo.Vida <= 0) {continue;}
    
    monstruo.Atacar();
    Nico.RecibirDaño(monstruo.Ataque);
    Nico.VidaCheck();

} while (Nico.Vida > 0 && monstruo.Vida > 0);

// if(Nico.Vida>0)
//     Console.WriteLine($"{Nico.Nombre} ha triunfado sobre {monstruo.Nombre}!");

// else if (monstruo.Vida > 0)

//     Console.WriteLine($"El monstruo {monstruo.Nombre} ha derrotado a {Nico.Nombre}!");

Console.WriteLine( Nico.Vida > monstruo.Vida ? $"{Nico.Nombre} ha derrotado a {monstruo.Nombre}!!": $"El enemigo {monstruo.Nombre} ha derrotado a {Nico.Nombre}!");
public class Personaje
{
    public string Nombre {get ; private set;}
    Random random = new Random();
    public int Vida {get ; private set;}
    public int Ataque{get ; private set;}
    public Personaje (string nombre,int vida, int ataque)
    {
        Nombre=nombre;
        Vida=vida;
        Ataque=ataque;
    }
    public void Atacar()
    {
        Ataque = random.Next(1,10);
    }
    public void RecibirDaño(int daño)
    {
        Vida -= daño;
        Console.WriteLine($"{Nombre} ha perdido {daño} de vida!");
    }
    public void VidaCheck()
    {
        if(Vida < 0)
            Vida=0;
        Console.WriteLine($"La vida actual de {Nombre} es : {Vida}. ");
    }
}
#endregion
//Console.WriteLine($"Fin.");