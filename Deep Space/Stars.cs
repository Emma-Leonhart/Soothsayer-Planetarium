using System;

namespace Planetarium
{
	/// <summary>
	/// Summary description for Stars.
	/// </summary>
	public class Star : ADSObject
	{
		public Star(){}

		public Star(string designation, string name, double RA, double decl, double magnitude, string spectrum)
		{
			this.designation = designation;
			this.name = name;
			this.skyPosition.RA = RA; //Right Ascension
			this.skyPosition.decl = decl; //declination
			this.magnitude = magnitude; //magnitude
			this.spectrum = spectrum; //color and type
			//new StarGod(string designation, string name, double RA, double decl, double magnitude, string spectrum)
		}

		public string spectrum
		{
			get {return v_spectrum;}
			set {v_spectrum = value;}
		}

		public double magnitude
		{
			get {return v_magnitude;}
			set {v_magnitude = value;}
		}

		private string v_spectrum;
		private double v_magnitude;
	}
}
