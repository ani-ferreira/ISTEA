

/*GUIA 3

1) Realizar un algoritmo que muestre en pantalla los números del 1 al 35 (uno abajo del otro). Utilizar
para esto alguna estructura repetitiva.


int numeroDo = 1;

do
{
Console.WriteLine(numeroDo);
numeroDo++;
} while (numeroDo <= 35);



int n = 1;

while (n <= 35)
{
Console.WriteLine(n);
n++;
}



for (int num = 1; num <= 35; num++)
{
Console.WriteLine(num);

}


2) Realizar un algoritmo que dado por teclado un límite numérico (por ejemplo 100) muestre en
pantalla todos los números hasta ese límite (empezando por 1).


int limite;
Console.WriteLine("Ingrese limite");
limite = Convert.ToInt32(Console.ReadLine());

int numero = 1;

while(numero <= limite)
{
Console.WriteLine(numero);
numero++;
}

do
{
Console.WriteLine(numero);
numero++;
} while (numero <=limite);


for(int i = 1; i <= limite; i++)
{
Console.WriteLine(i);
}


3) Realizar un algoritmo que muestre por pantalla los números del 200 al 250 saltando de 2 en dos. La
secuencia debería ser: 200...202...204...etc.


int n = 200;
while (n <= 250)
{
Console.WriteLine(n);
n = (n + 2);
}

for (int i = 200; i <= 250;i+=2 ) // i= i+2
{
Console.WriteLine(i);
}



4) Realizar un algoritmo que lleve a cabo la cuenta regresiva para el año nuevo. La cuenta debe
comenzar en 10 y terminar en 1.


int n = 10;

do
{
Console.WriteLine(n);
n--;
} while (n>=1);




5) Un gerente de una empresa prestadora de servicios de internet necesita un algoritmo que permita
realizar el cálculo del monto a pagar de la factura de consumo de internet de 5 clientes de una
empresa. Para ello, el algoritmo debe solicitar por teclado dos datos: DNI del cliente y tipo de
servicio. Los tipos de servicio son 3:
1.Internet 30 megas(El servicio cuesta: $750)
2.Internet 50 megas(El servicio cuesta: $1100)
3.Internet 100 megas(El servicio cuesta: $1500 – menos 5 % de descuento por promoción)
El algoritmo debe poder calcular el monto a pagar (dependiendo del tipo de servicio con el que
cuente el cliente) e informar por pantalla el dni del mismo junto con el monto a pagar y el número de
servicio con el que cuenta.



int dni = 0, tipoServicio = 0;
double precioConPromocion = 0,descuento =0;

for (int i = 0; i <= 5; i++)
{
    Console.WriteLine("Ingrese su DNI: ");
    dni = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese tipo de servicio: ");
    tipoServicio = Convert.ToInt32(Console.ReadLine());


    switch (tipoServicio)
    {
    case 1:
    Console.WriteLine($"El servicio {tipoServicio}para el cliente con dni { dni} cuesta: 750");
    break;
    case 2:
    Console.WriteLine($"El servicio { tipoServicio} para el cliente con dni {dni}  cuesta: 1100");
    break;
    case 3:
    descuento = 1500 * 5 / 100;
    precioConPromocion = 1500 - descuento;
    Console.WriteLine($"El servicio { tipoServicio}para el cliente con dni {dni} cuesta: {precioConPromocion }");
    break;
    }
}


6) En una carrera automovilística se desea calcular cuál es el menor tiempo realizado entre cada uno
de sus 12 competidores. Para ello, se pide un algoritmo que sea capaz de permitir el ingreso por
teclado del número de vehículo y el tiempo (en segundos) de cada participante. Una vez
encontrado el que realizó el mejor tiempo, se debe informar por pantalla tanto el número de
vehículo que utilizaba como el tiempo que llevó a cabo.


//variables de entrada: numero y el tiempo
//variables de proceso: no hay
//variables de salida: el que realizo el mejor tiempo, numero y tiempo

int mejorTiempo = 0;
int numeroCompetidorMejorTiempo = 0;
int numeroCompetidor = 0;
int tiempoCompetidor = 0;

for(int competidor = 1;competidor <= 12; competidor++)
{
    Console.WriteLine("Ingrese numero de competidor");
    numeroCompetidor = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese tiempo realizado por el competidor");
    tiempoCompetidor= Convert.ToInt32(Console.ReadLine());

    if(competidor == 1)
    {
        mejorTiempo = tiempoCompetidor;
        numeroCompetidorMejorTiempo = numeroCompetidor;
    }

    if(tiempoCompetidor < mejorTiempo)
    {
        mejorTiempo =tiempoCompetidor;
        numeroCompetidorMejorTiempo = numeroCompetidor;
    }
}

Console.WriteLine($"El competidor numero {numeroCompetidor} tuvo el mejor tiempo: {mejorTiempo}");



7) En un club se registran, entre otros datos, para cada uno de los socios: Número de socio, edad, tipo
de deporte que practica (1 tenis, 2 rugby, 3 voley, 4 hockey, 5 futbol). Realizar un algoritmo que
permita informar cuantos socios practican tenis y cuantos fútbol y el promedio de edad de los
jugadores por deporte.

int cantidadJugadoresTenis = 0;
int cantidadJugadoresFutbol = 0;
int cantidadJugadoresRugby = 0;
int cantidadJugadoresVoley = 0;
int cantidadJugadoresHockey = 0;

int sumaEdadJugadoresTenis = 0;
int sumaEdadJugadoresFutbol = 0;
int sumaEdadJugadoresRugby = 0;
int sumaEdadJugadoresVoley = 0;
int sumaEdadJugadoresHockey = 0;

double promedioEdadJugadoresTenis = 0;
double promedioEdadJugadoresFutbol = 0;
double promedioEdadJugadoresRugby = 0;
double promedioEdadJugadoresVoley = 0;
double promedioEdadJugadoresHockey = 0;

int nroSocio = 1;
int edad = 0;
int deporte = 0;

while (nroSocio != 0)
{
    Console.WriteLine("Ingrese el numero de socio: (si desea finalizar el proceso ingrese 0)");
    nroSocio = Convert.ToInt32(Console.ReadLine());

        if(nroSocio == 0)
    {
        break;
    }
    Console.WriteLine("Ingrese la edad del jugador");
    edad = Convert.ToInt32(Console.ReadLine());
   
    Console.WriteLine("Ingrese el deporte");
    deporte = Convert.ToInt32(Console.ReadLine());


    switch (deporte)
    {
        case 1:
            cantidadJugadoresTenis++;
            sumaEdadJugadoresTenis += edad;
            break;
        case 2:
            cantidadJugadoresRugby++;
            sumaEdadJugadoresRugby += edad;
            break;
        case 3:
            cantidadJugadoresVoley++;
            sumaEdadJugadoresVoley += edad;
            break;
        case 4:
            cantidadJugadoresHockey++;
            sumaEdadJugadoresHockey += edad;
        break;
            case 5:
            cantidadJugadoresFutbol++;
            sumaEdadJugadoresFutbol += edad;
            break;
        default:
            break;
    }
   
}
    Console.WriteLine($"La cantidad que juega futbol es {cantidadJugadoresFutbol}");
    Console.WriteLine($"La cantidad que juega tenis es {cantidadJugadoresTenis}");

if (cantidadJugadoresFutbol > 0)
{
    promedioEdadJugadoresFutbol = sumaEdadJugadoresFutbol / cantidadJugadoresFutbol;
    Console.WriteLine($"El promedio de edad de los jugadores de futbol es {promedioEdadJugadoresFutbol}");
}
else
{
    Console.WriteLine("No hay jugadores de futbol");
}

if (cantidadJugadoresTenis > 0)
{
    promedioEdadJugadoresTenis = sumaEdadJugadoresTenis / cantidadJugadoresTenis;
    Console.WriteLine($"El promedio de edad de los jugadores de tenis es {promedioEdadJugadoresTenis}");
}
else
{
    Console.WriteLine("No hay jugadores de tenis");
}

if (cantidadJugadoresVoley > 0)
{
    promedioEdadJugadoresVoley = sumaEdadJugadoresVoley / cantidadJugadoresVoley;
    Console.WriteLine($"El promedio de edad de los jugadores de voley es {promedioEdadJugadoresVoley}");
}
else
{
    Console.WriteLine("No hay jugadores de voley");
}

if (cantidadJugadoresHockey > 0)
{
    promedioEdadJugadoresHockey = sumaEdadJugadoresHockey / cantidadJugadoresHockey;
    Console.WriteLine($"El promedio de edad de los jugadores de hockey es {promedioEdadJugadoresHockey}");
}
else
{
    Console.WriteLine("No hay jugadores de hockey");
}

if (cantidadJugadoresRugby > 0)
{
    promedioEdadJugadoresRugby = sumaEdadJugadoresRugby / cantidadJugadoresRugby;
    Console.WriteLine($"El promedio de edad de los jugadores de rugby es {promedioEdadJugadoresRugby}");
}
else
{
    Console.WriteLine("No hay jugadores de rugby");
}


8) Se realizó un censo provincial y se desea procesar la información obtenida en dicho censo. De
cada una de las personas censadas se tiene la siguiente información: número de documento, edad
y sexo (‘F’ o ‘M’). Realizar un algoritmo que lea los datos de cada persona censada (para fin de
ingreso de datos, ingresar 0 (cero) como numero de documento) e informe: Cantidad total de
personas censadas, cantidad de varones y cantidad de mujeres, porcentaje de varones cuya edad
varía entre 16 y 65 años respecto del total de varones, mostrar datos de la persona que registra la
mayor edad.

int documento=1, edad=0;
string sexo="", sexoPersonaMayor="";
int totalPersonasCensadas = 0, cantidadVarones = 0, cantidadMujeres = 0;
int cantidadVaronesVotantes = 0;
int documentoPersonaMayor = 0, edadPersonaMayor = 0;
double porcentajeVaronesVotantes = 0;

while (documento != 0)
{
    Console.WriteLine("Ingrese el numero de documento: (si quiere cortar el proceso ingrese 0)");
    documento = Convert.ToInt32(Console.ReadLine());

    if (documento == 0)
    {
        break;
    }

    totalPersonasCensadas++;

    Console.WriteLine("Ingrese su edad");
    edad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese su sexo:");
    sexo = Console.ReadLine();

    if (edad > edadPersonaMayor)
    {
        documentoPersonaMayor = documento;
        edadPersonaMayor = edad;
        sexoPersonaMayor = sexo;
    };

   
    if (sexo == "M")
    {
        cantidadVarones++;

        if(edad >= 16 && edad <= 65)
        {
            cantidadVaronesVotantes++;
        }
      
    }
    else
    {
        cantidadMujeres++;
    }

}
if(cantidadVaronesVotantes > 0 && cantidadVarones >0) { 
porcentajeVaronesVotantes = (cantidadVaronesVotantes * 100) / cantidadVarones;
}


Console.WriteLine($"La cantidad de personas censadas es: {totalPersonasCensadas}");
Console.WriteLine($"La cantidad de mujeres es: {cantidadMujeres}");
Console.WriteLine($"La cantidad de varones es: {cantidadVarones}");
Console.WriteLine($"El porcentaje de varones cuya edad varía entre 16 y 65 años respecto del total de varones es: {porcentajeVaronesVotantes}");
Console.WriteLine($"La persona con mas edad tiene {edadPersonaMayor} años, su documento es: {documentoPersonaMayor}, su sexo es: {sexoPersonaMayor}");