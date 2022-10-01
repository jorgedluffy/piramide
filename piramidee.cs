using System;
class ej
{
	static void Main()
	{
		int ancho = 0;
		int espacios = 0;
		do
		{
			Console.WriteLine("Ingrese el ancho");
			ancho = Convert.ToInt32(Console.ReadLine());
		}
		while (ancho % 2 ==0);
		do
		{
			for(int j = 0;j<espacios;j++)
			{
				Console.Write(" ");
			}
			for(int i = 1 ;i<=ancho;i++)
			{
				Console.Write("*");
			}
			ancho-=2;
			espacios++;
			Console.WriteLine();
			
		}
		while(ancho >= 1);
		
	}
}
