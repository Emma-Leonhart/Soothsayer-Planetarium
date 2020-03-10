using System;

namespace Planetarium
{
	/// <summary>
	/// Summary description for Messier.
	/// Messier Objects are various Nebulae and Galaxies that are visible to the naked eye but not stars
	/// </summary>
	public class Messier : ADSObject
	{
		public Messier(){}

		public Messier(string designation, double RA, double decl, string type, string name)
		{
			if (designation != "")
				this.designation = "M"+designation;
			else this.designation = name;
			this.name = name;
			this.skyPosition.RA = RA;
			this.skyPosition.decl = decl;
			this.type = type;
			// new MessierGod(string designation, double RA, double decl, string type, string name)
		}

		public string type
		{
			get {return v_type;}
			set {v_type = value;}
		}

		private string v_type;
	}
}
