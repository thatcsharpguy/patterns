using System;
namespace DependencyInjection
{
	// Cliente que consume el servicio
	public class Persona
	{
		IAlimento _alimento;

		public Persona(IAlimento alimento)
		{
			_alimento = alimento;
		}

		public void Comer()
		{
			Console.WriteLine("Comiendo " + _alimento.Nombre);
		}
	}
}

