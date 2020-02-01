using System;

namespace Planetarium
{
	/// <summary>
	/// Summary description for Planets.
	/// </summary>
	public class Planets
	{
		private APlanet[] planets = new APlanet[12];
		private int counter = 0;

		public Planets (params APlanet[] initPlanets)
		{
			foreach (APlanet ap in initPlanets)
				planets[counter++] = ap;
		}

		public void Add (APlanet planet)
		{
			planets[counter++] = planet;
		}

		public APlanet this[int index]
		{
			get {return planets[index];}
			set {planets[index] = value;}
		}

		public APlanet this[string index]
		{
			get {return this[findString(index)];}
			set {planets[findString(index)] = value;}
		}

		private int findString (string searchString)
		{
			for (int i=0; i<planets.Length; i++){
				if (planets[i].name == searchString)
					return i;
			}
			return -1;
		}

		public int GetNumEntries()
		{
			return counter;
		}
	}
}
