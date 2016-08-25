using System;


namespace DependencyInjection
{
	
	// Implementación de un servicio
	public class Pizza : IAlimento
	{
		public Pizza(string ingrediente)
		{
			Nombre = "Pizza de " + ingrediente;
		}

		public string Nombre { get; private set; }
	}
}

