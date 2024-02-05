using Array.Logic;
using static System.Console;

var array = new ArrayNew(25);
array.Fill(1,50);
WriteLine("\t\tArreglo Inicial\n");
WriteLine(array);
WriteLine("\n\t\tNúmeros Primos en el Arreglo\n"); 
array.Prime();
WriteLine("\n\t\tNúmeros que no se repiten en el Arreglo\n"); 
array.NoRepeated();
WriteLine("\n\t\tLos números se repiten de la siguiente forma:\n"); 
array.Repeated();