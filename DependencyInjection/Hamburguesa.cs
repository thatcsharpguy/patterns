using System;
namespace DependencyInjection
{
	// Implementación de un servicio
	public class Hamburguesa : IAlimento
	{
		public string Tipo { get; set; }

		public string Nombre
		{
			get
			{
				return "Hamburguesa " + Tipo;
			}
		}
	}
}

