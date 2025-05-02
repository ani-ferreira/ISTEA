using System.Threading;
/*
1 - Una pequeña despensa desea calcular los sueldos de sus empleados. Los puestos de los mismos
pueden tener 3 categorías: 1 - repositor, 2 - cajero y 3-supervisor.
a. Los repositores cobran $32.335.
b. Los cajeros cobran $38.630,89.
c. Los supervisores cobran $45.560,20.
Todos son sueldos en bruto, para cada uno de ellos hay que calcular las deducciones del 11% de
jubilación y 3% de Obra Social.
- Se necesita un algoritmo que, dependiendo el tipo de empleado del que se trate, calcule y muestre en
pantalla el correspondiente Sueldo Neto (Con las deducciones) e informe también los descuentos por
jubilación y obra social. Informar que para los repositores hay un bono en compras que equivale al 8%
del sueldo (Mostrar por pantalla a cuánto equivale el bono).


int categoria;
double sueldo = 0;
double sueldoNeto = 0;
double jubilacion = 0;
double obraSocial = 0;
double bono=0;

Console.WriteLine("Ingrese categoria");
categoria = Convert.ToInt32(Console.ReadLine());

switch (categoria)
{
    case 1:
        sueldo = 32335;
        jubilacion = sueldo * 0.11;
        obraSocial = sueldo * 0.03;
        sueldoNeto = sueldo - jubilacion - obraSocial;
        bono = sueldo * 0.08;
        break;
    case 2:
        sueldo = 38630.89;
        jubilacion = sueldo * 0.11;
        obraSocial = sueldo * 0.03;
        sueldoNeto = sueldo - jubilacion - obraSocial; 
        break;
    case 3:
        sueldo = 45560.20;
        jubilacion = sueldo * 0.11;
        obraSocial = sueldo * 0.03;
        sueldoNeto = sueldo - jubilacion - obraSocial;
        break;

       
} 
        Console.WriteLine($"El sueldo bruto es ${sueldo}");
        Console.WriteLine($"El sueldo neto es ${sueldoNeto}");
        Console.WriteLine($"La deduccion por jubilacion es ${jubilacion}");
        Console.WriteLine($"La deduccion por obra social es ${obraSocial}");
        Console.WriteLine($"El bono es de ${bono}");


    
2 - Una mercería vende canutillos y mostacillas al por mayor mediante su página web. Como se trata de
una mercería mayorista, solicita la cantidad de paquetes en cada venta y dependiendo de esta realiza
los siguientes controles:
a.Si la cantidad de productos es menor a 5: Se debe emitir un mensaje indicando que no se permiten
compras inferiores a 5 productos.
b. Si la cantidad de productos es mayor o igual a 5 pero menor o igual a 15: Se debe emitir un
mensaje que el costo de envío es de $200.
c. Si la cantidad de productos es mayor a 15: Se debe emitir un mensaje de que el envío es gratuito.
-Realizar el algoritmo necesario para llevar a cabo los 3 controles citados.



int cantidad;
Console.WriteLine("Ingresar la cantidad de la compra");
cantidad = Convert.ToInt32(Console.ReadLine());

if (cantidad < 5)
{
    Console.WriteLine("No se permiten compras inferiores a 5 productos");
}
if (cantidad >= 5 && cantidad <= 15)
{
    Console.WriteLine("El costo de envío es de $200");
}
if (cantidad > 15)
{
    Console.WriteLine("El envío es gratuito");
}


3- Realizar un algoritmo que, al ingresar por teclado el precio por Kg y la cantidad en Kg adquirida por el
cliente de tres productos (6 variables) muestre:
a.- El monto total en pesos correspondiente a la compra de cada producto.
b.- El total en pesos de la compra realizada por el cliente.
c.- Si el total es superior a $100, hacer un descuento del 10%. Informar el nuevo monto.




double precioPorKgProducto1, precioPorKgProducto2, precioPorKgProducto3, cantidadKgProducto1, cantidadKgProducto2 , cantidadKgProducto3;
double precioCompraProducto1, precioCompraProducto2 , precioCompraProducto3,precioTotalCompra, precioConDescuento,descuento ;

Console.WriteLine("Ingrese el precio por kg del producto 1:");
precioPorKgProducto1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el precio por kg del producto 2:");
precioPorKgProducto2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el precio por kg del producto 3:");
precioPorKgProducto3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad en Kg adquirida del producto 1:");
cantidadKgProducto1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad en Kg adquirida del producto 2:");
cantidadKgProducto2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad en Kg adquirida del producto 3:");
cantidadKgProducto3 = Convert.ToInt32(Console.ReadLine());

precioCompraProducto1 = precioPorKgProducto1 * cantidadKgProducto1;
precioCompraProducto2 = precioPorKgProducto2 * cantidadKgProducto2;
precioCompraProducto3 = precioPorKgProducto3 * cantidadKgProducto3;
precioTotalCompra = precioCompraProducto1 + precioCompraProducto2 + precioCompraProducto3;

Console.WriteLine($"El precio de la compra del producto 1 es:{precioCompraProducto1}");
Console.WriteLine($"El precio de la compra del producto 2 es:{precioCompraProducto2}");
Console.WriteLine($"El precio de la compra del producto 3 es:{precioCompraProducto3}");
Console.WriteLine($"El precio total de la compra es:{precioTotalCompra}");

if (precioTotalCompra > 100)
{
    descuento = precioTotalCompra * 0.10;
    precioConDescuento = precioTotalCompra - descuento;
    Console.WriteLine($"El valor del descuento es:{descuento}");
    Console.WriteLine($"El total a pagar es es:{precioConDescuento}");
}

/*
4- Realizar un algoritmo que permita calcular el sueldo de un determinado empleado de una empresa. Se
debe permitir ingresar por teclado el DNI del empleado y la categoría a la que pertenece; el programa
deberá mostrar el sueldo NETO (el bruto menos todos los descuentos) del empleado, su DNI y la
categoría a la que pertenece (Debe imprimir el nombre de la categoría a la que pertenece). Tener en
cuenta que las categorías tienen las siguientes cuestiones:

a.Categoría 0: Maestranza.Sueldo Bruto de $23600. Descuento de jubilación 11%.
Descuento de Obra Social 3%.

b. Categoría 1: Administración.Sueldo Bruto de $35800. Descuento de Jubilación 11 %.
Descuento de Obra social 5%.

c. Categoría 2: Gerencia.Sueldo Bruto de $60420. Descuento de Jubilación 11%. Descuento
de Obra Social 5%. Descuento de club 4%.
*/

int dniEmpleado, categoria;
double sueldoBruto, sueldoNeto,jubilacion, obraSocial, descuentoClub;
string nombreCategoria = "";

sueldoNeto = 0;
 

Console.WriteLine("Ingresar el dni del empleado:");
dniEmpleado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresar la categoria del empleado:");
categoria = Convert.ToInt32(Console.ReadLine());

switch (categoria)
{
    case 0:
        nombreCategoria = "Maestranza";
        sueldoBruto = 23600;
        jubilacion = sueldoBruto * 0.11;
        obraSocial = sueldoBruto * 0.03;
        sueldoNeto = sueldoBruto - jubilacion - obraSocial;

        break;
    case 1:
        nombreCategoria = "Administración";
       sueldoBruto = 35800;
        jubilacion = sueldoBruto * 0.11;
        obraSocial = sueldoBruto * 0.05;
        sueldoNeto = sueldoBruto - jubilacion - obraSocial;

        break;
    case 2:
        nombreCategoria = "Gerencia";
       sueldoBruto = 60420;
        jubilacion = sueldoBruto * 0.11;
        obraSocial = sueldoBruto * 0.05;
       descuentoClub= sueldoBruto * 0.04;
        sueldoNeto = sueldoBruto - jubilacion - obraSocial - descuentoClub;
        break;

}

        Console.WriteLine($"El dni del empleado es {dniEmpleado}");
Console.WriteLine($"Categoría: {nombreCategoria}");
Console.WriteLine($"El sueldo neto es {sueldoNeto}");

