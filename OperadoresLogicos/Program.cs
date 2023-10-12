// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//bool valor1 = true;
//bool valor2 = true;
//bool valor3 = false;

var (valor1, valor2, valor3) = (true, true,false);

bool resultAnd = valor1 && valor2 && valor3 ;
Console.WriteLine("El resultado de AND es: " + resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine("El resultado de OR es: " + resultOr);

bool resultAndOr = (valor1 && valor2) || valor3;
Console.WriteLine("El resultado de AND y OR es: " + resultAndOr);

bool resultNot = !valor2;
Console.WriteLine("El resultado de NOT es: " + resultNot);

bool resultXor = (valor1 ^ valor2) ^ valor3;
Console.WriteLine("El resultado de XOR es: " + resultXor);
