// See https://aka.ms/new-console-template for more information
int numeroEntero =0;
/*Mensaje en Pantalla*/
Console.WriteLine("Ejercicio 1");
Console.WriteLine("Numero Entero");
/*Siguiente Instrucción recibe y almacena el numero*/
numeroEntero = Convert.ToInt32(Console.ReadLine());
if(numeroEntero<0)
{
  Console.WriteLine("Número Negativo");
}else if(numeroEntero>1)
{ Console.WriteLine("Número Positivo");
}