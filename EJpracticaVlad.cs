/*
Practica con for Vladysalv Vender, que pida al usuario el alto
y me dibuje triangulo
*/

using System;
public class EJpractica
{
	public static void Main()
	{
		int numeros, nu1, numeros1, numeros2;
		int asteriscos=1;
		Console.Write("Dime un numero y te dibujo triangulo ");
		nu1 = Convert.ToInt32(Console.ReadLine());
		int espacios=nu1-1;
		for (numeros=0; numeros<nu1; numeros++) 
		{
	        for (numeros1=0; numeros1<espacios; numeros1++)
	        {
				Console.Write(" ");
			}
			for (numeros2=0; numeros2<asteriscos; numeros2++)
			{
				Console.Write("*");
			}
			Console.WriteLine(); // mete enter 
				
			
			asteriscos = asteriscos+2;
			espacios = espacios-1;
		}
		
	}
	
}

