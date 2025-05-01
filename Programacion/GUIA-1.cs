
using System.Runtime.Intrinsics.Arm;
/*a) Una persona decidió realizar un algoritmo para mostrar 3 números por pantalla. Decidió llamar a las
variables num1, num2 y num3 y colocarles los valores 5, 3 y 7. Sin embargo, no sabe de qué tipos
de datos deberían ser sus tres variables ni tampoco como asignar dichos valores. Realizar un
algoritmo que declare las variables, les asigne los valores que se necesitan y mostrar por pantalla.
*/
int num1, num2, num3;

num1 = 5;
num2 = 3;
num3 = 7;

Console.WriteLine($"Los numeros son los siguientes: {num1}, {num2} y {num3}");



/*

b) Escribir un algoritmo que permita ingresar por teclado dos números e imprima su suma.

int num1, num2,suma;

num1 = 0;
num2 = 0;
suma = 0;

Console.WriteLine("Ingrese el primero numero");

num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ingrese el segundo numero");

num2 = Convert.ToInt32(Console.ReadLine());

suma = num1 + num2;


Console.WriteLine("Resultado: "+suma);
Console.WriteLine(suma);

c) Realizar un algoritmo que permita a un usuario ingresar por teclado la BASE y el EXPONENTE de una potencia y que el resultado sea mostrado por pantalla.
//la palabra base es reservada del lenguaje

int numbase; 
int numexponente;
double resultado;

Console.WriteLine("Ingrese la base");
numbase = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el exponente");
numexponente = Convert.ToInt32(Console.ReadLine());

resultado = Math.Pow(numbase, numexponente);

Console.WriteLine($"El resultado es igual a: {resultado}");


d) Realizar un algoritmo que permita a un usuario ingresar por teclado un número del 1 al 100 y que determine si es un número par o impar.

int num;

Console.WriteLine("Ingrese un numero del 1 al 100");
num = Convert.ToInt32(Console.ReadLine());

if(num%2 == 0)
{
    Console.WriteLine("El numero es par");
}
else
{
    Console.WriteLine("El numero es impar");
}



e) Realizar un algoritmo que permita intercambiar el valor de dos variables. Por ejemplo, si la variable1 vale 5 y la variable2 vale 12, hacer que la variable1 valga 12 y la variable2 valga 5. (Tener en cuenta que al asignar un valor a una variable se sobrescribe el valor anterior).

int num1, num2, aux;

Console.WriteLine("Ingrese el primero numero");

num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ingrese el segundo numero");

num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ingresos");
Console.WriteLine(num1);
Console.WriteLine(num2);

aux = num1;

num1 = num2;
num2 = aux;
Console.WriteLine("cambio de orden");
Console.WriteLine(num1);
Console.WriteLine(num2);




f) Una clínica de obesidad necesita un programa que sea capaz de calcular el índice de masa corporal de una persona que requiera atención. Para ello, tener en cuenta que la fórmula para elIMC es:Peso/(Estatura) 2

double peso, altura, resultadoIMC;

Console.WriteLine("Indique su peso");
peso = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Indique su altura");
altura = Convert.ToDouble(Console.ReadLine());

resultadoIMC = peso/Math.Pow(altura, 2);

Console.WriteLine($"Su IMC es {resultadoIMC}" );


g) Una estudiante está dando sus primeros pasos en la programación y quiere realizar un algoritmo
que permita calcular cualquier porcentaje de un número. Para ello necesita que el usuario ingrese
por teclado el número a calcular el porcentaje (por ejemplo 2500) y también el porcentaje que se
desea calcular (por ejemplo, si quiere calcular 10% debería ingresar 0,10). A partir de estos valores,
necesita que el algoritmo calcule el porcentaje (multiplicar el primer número por el valor del
porcentaje), lo guarde en una variable y se muestre por pantalla. ¿Podrías ayudarla a realizar el
algoritmo?

int numbase;
double numPorcentaje;
double resultado;

Console.WriteLine("Ingrese la base");
numbase = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el pocentaje");
numPorcentaje = Convert.ToDouble(Console.ReadLine());

resultado = numbase * numPorcentaje;

Console.WriteLine($"El resultado es igual a: {resultado}");



h) Realizar un algoritmo que calcule el IVA de un producto. Para esto, el usuario debe poder ingresar
por teclado el valor del producto y el algoritmo debe informarle por pantalla qué monto equivale al
IVA. Recordar que el IVA es igual al 21% (0,21).


double valor;
double resultadoIVA;

Console.WriteLine("Ingrese el valor del producto");
valor = Convert.ToDouble(Console.ReadLine());

resultadoIVA = valor * 0.21;

Console.WriteLine($"El monto del IVA es {resultadoIVA} ");



i) Realizar un algoritmo que permita a un profesor calcular el promedio de un alumno. Para esto, el
algoritmo debe permitir ingresar las 4 notas de un alumno (por ejemplo, 8, 7, 9.50 y 10), luego
calcular el promedio de las mismas y mostrar el resultado por pantalla.


double nota1, nota2, nota3, nota4, promedio;

Console.Write("Ingrese la primera nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la tercera nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la cuarta nota: ");
nota4 = Convert.ToDouble(Console.ReadLine());


promedio = (nota1 + nota2 + nota3 + nota4) / 4;


Console.WriteLine($"El promedio del alumno es: {promedio}");


j) Realizar un algoritmo que permita calcular el área de un triángulo. Se recuerda que la fórmula para
calcular el área de un triángulo es: (base * altura) / 2. Se debe permitir al usuario ingresar la base y
la altura, mientras que el algoritmo debe calcular el área y mostrar el resultado por pantalla.


double baseT, alturaT, resultadoArea;

Console.WriteLine("Indique la base del triangulo");

baseT = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Indique la altura del triangulo");

alturaT = Convert.ToDouble(Console.ReadLine());

resultadoArea = (baseT * alturaT) / 2;

Console.WriteLine($"El resultado es:{resultadoArea} ");*/