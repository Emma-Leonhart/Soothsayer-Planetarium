using System;

namespace Planetarium
{
	/// <summary>
	/// 
	/// </summary>
	public class AngularDistances
	{
		public PlanetData pd = PlanetData.GetInstance();

		public AngularDistances(){}

		public double AngularDistance (string planets)
		{
			pd.PlanetPositions();
			switch (planets){
				case "MerVen": return Calculation(pd.planets["Mercury"].skyPosition.RA, pd.planets["Mercury"].skyPosition.decl, pd.planets["Venus"].skyPosition.RA, pd.planets["Venus"].skyPosition.decl);
				case "MerMar": return Calculation(pd.planets["Mercury"].skyPosition.RA, pd.planets["Mercury"].skyPosition.decl, pd.planets["Mars"].skyPosition.RA,    pd.planets["Mars"].skyPosition.decl);
				case "MerJup": return Calculation(pd.planets["Mercury"].skyPosition.RA, pd.planets["Mercury"].skyPosition.decl, pd.planets["Jupiter"].skyPosition.RA, pd.planets["Jupiter"].skyPosition.decl);
				case "MerSat": return Calculation(pd.planets["Mercury"].skyPosition.RA, pd.planets["Mercury"].skyPosition.decl, pd.planets["Saturn"].skyPosition.RA,  pd.planets["Saturn"].skyPosition.decl);
				case "MerUra": return Calculation(pd.planets["Mercury"].skyPosition.RA, pd.planets["Mercury"].skyPosition.decl, pd.planets["Uranus"].skyPosition.RA,  pd.planets["Uranus"].skyPosition.decl);
				case "MerNep": return Calculation(pd.planets["Mercury"].skyPosition.RA, pd.planets["Mercury"].skyPosition.decl, pd.planets["Neptune"].skyPosition.RA, pd.planets["Neptune"].skyPosition.decl);
				case "MerPlu": return Calculation(pd.planets["Mercury"].skyPosition.RA, pd.planets["Mercury"].skyPosition.decl, pd.planets["Pluto"].skyPosition.RA,   pd.planets["Pluto"].skyPosition.decl);
				case "MerMoo": return Calculation(pd.planets["Mercury"].skyPosition.RA, pd.planets["Mercury"].skyPosition.decl, pd.planets["Moon"].skyPosition.RA,    pd.planets["Moon"].skyPosition.decl);

				case "VenMar": return Calculation(pd.planets["Venus"].skyPosition.RA, pd.planets["Venus"].skyPosition.decl, pd.planets["Mars"].skyPosition.RA,    pd.planets["Mars"].skyPosition.decl);
				case "VenJup": return Calculation(pd.planets["Venus"].skyPosition.RA, pd.planets["Venus"].skyPosition.decl, pd.planets["Jupiter"].skyPosition.RA, pd.planets["Jupiter"].skyPosition.decl);
				case "VenSat": return Calculation(pd.planets["Venus"].skyPosition.RA, pd.planets["Venus"].skyPosition.decl, pd.planets["Saturn"].skyPosition.RA,  pd.planets["Saturn"].skyPosition.decl);
				case "VenUra": return Calculation(pd.planets["Venus"].skyPosition.RA, pd.planets["Venus"].skyPosition.decl, pd.planets["Uranus"].skyPosition.RA,  pd.planets["Uranus"].skyPosition.decl);
				case "VenNep": return Calculation(pd.planets["Venus"].skyPosition.RA, pd.planets["Venus"].skyPosition.decl, pd.planets["Neptune"].skyPosition.RA, pd.planets["Neptune"].skyPosition.decl);
				case "VenPlu": return Calculation(pd.planets["Venus"].skyPosition.RA, pd.planets["Venus"].skyPosition.decl, pd.planets["Pluto"].skyPosition.RA,   pd.planets["Pluto"].skyPosition.decl);
				case "VenMoo": return Calculation(pd.planets["Venus"].skyPosition.RA, pd.planets["Venus"].skyPosition.decl, pd.planets["Moon"].skyPosition.RA,    pd.planets["Moon"].skyPosition.decl);
				
				case "MarJup": return Calculation(pd.planets["Mars"].skyPosition.RA, pd.planets["Mars"].skyPosition.decl, pd.planets["Jupiter"].skyPosition.RA, pd.planets["Jupiter"].skyPosition.decl);
				case "MarSat": return Calculation(pd.planets["Mars"].skyPosition.RA, pd.planets["Mars"].skyPosition.decl, pd.planets["Saturn"].skyPosition.RA,  pd.planets["Saturn"].skyPosition.decl);
				case "MarUra": return Calculation(pd.planets["Mars"].skyPosition.RA, pd.planets["Mars"].skyPosition.decl, pd.planets["Uranus"].skyPosition.RA,  pd.planets["Uranus"].skyPosition.decl);
				case "MarNep": return Calculation(pd.planets["Mars"].skyPosition.RA, pd.planets["Mars"].skyPosition.decl, pd.planets["Neptune"].skyPosition.RA, pd.planets["Neptune"].skyPosition.decl);
				case "MarPlu": return Calculation(pd.planets["Mars"].skyPosition.RA, pd.planets["Mars"].skyPosition.decl, pd.planets["Pluto"].skyPosition.RA,   pd.planets["Pluto"].skyPosition.decl);
				case "MarMoo": return Calculation(pd.planets["Mars"].skyPosition.RA, pd.planets["Mars"].skyPosition.decl, pd.planets["Moon"].skyPosition.RA,    pd.planets["Moon"].skyPosition.decl);
				
				case "JupSat": return Calculation(pd.planets["Jupiter"].skyPosition.RA, pd.planets["Jupiter"].skyPosition.decl, pd.planets["Saturn"].skyPosition.RA,  pd.planets["Saturn"].skyPosition.decl);
				case "JupUra": return Calculation(pd.planets["Jupiter"].skyPosition.RA, pd.planets["Jupiter"].skyPosition.decl, pd.planets["Uranus"].skyPosition.RA,  pd.planets["Uranus"].skyPosition.decl);
				case "JupNep": return Calculation(pd.planets["Jupiter"].skyPosition.RA, pd.planets["Jupiter"].skyPosition.decl, pd.planets["Neptune"].skyPosition.RA, pd.planets["Neptune"].skyPosition.decl);
				case "JupPlu": return Calculation(pd.planets["Jupiter"].skyPosition.RA, pd.planets["Jupiter"].skyPosition.decl, pd.planets["Pluto"].skyPosition.RA,   pd.planets["Pluto"].skyPosition.decl);
				case "JupMoo": return Calculation(pd.planets["Jupiter"].skyPosition.RA, pd.planets["Jupiter"].skyPosition.decl, pd.planets["Moon"].skyPosition.RA,    pd.planets["Moon"].skyPosition.decl);
				
				case "SatUra": return Calculation(pd.planets["Saturn"].skyPosition.RA, pd.planets["Saturn"].skyPosition.decl, pd.planets["Uranus"].skyPosition.RA,  pd.planets["Uranus"].skyPosition.decl);
				case "SatNep": return Calculation(pd.planets["Saturn"].skyPosition.RA, pd.planets["Saturn"].skyPosition.decl, pd.planets["Neptune"].skyPosition.RA, pd.planets["Neptune"].skyPosition.decl);
				case "SatPlu": return Calculation(pd.planets["Saturn"].skyPosition.RA, pd.planets["Saturn"].skyPosition.decl, pd.planets["Pluto"].skyPosition.RA,   pd.planets["Pluto"].skyPosition.decl);
				case "SatMoo": return Calculation(pd.planets["Saturn"].skyPosition.RA, pd.planets["Saturn"].skyPosition.decl, pd.planets["Moon"].skyPosition.RA,    pd.planets["Moon"].skyPosition.decl);
				
				case "UraNep": return Calculation(pd.planets["Uranus"].skyPosition.RA, pd.planets["Uranus"].skyPosition.decl, pd.planets["Neptune"].skyPosition.RA, pd.planets["Neptune"].skyPosition.decl);
				case "UraPlu": return Calculation(pd.planets["Uranus"].skyPosition.RA, pd.planets["Uranus"].skyPosition.decl, pd.planets["Pluto"].skyPosition.RA,   pd.planets["Pluto"].skyPosition.decl);
				case "UraMoo": return Calculation(pd.planets["Uranus"].skyPosition.RA, pd.planets["Uranus"].skyPosition.decl, pd.planets["Moon"].skyPosition.RA,    pd.planets["Moon"].skyPosition.decl);
				
				case "NepPlu": return Calculation(pd.planets["Neptune"].skyPosition.RA, pd.planets["Neptune"].skyPosition.decl, pd.planets["Pluto"].skyPosition.RA, pd.planets["Pluto"].skyPosition.decl);
				case "NepMoo": return Calculation(pd.planets["Neptune"].skyPosition.RA, pd.planets["Neptune"].skyPosition.decl, pd.planets["Moon"].skyPosition.RA,  pd.planets["Moon"].skyPosition.decl);
				
				case "PluMoo": return Calculation(pd.planets["Pluto"].skyPosition.RA, pd.planets["Pluto"].skyPosition.decl, pd.planets["Moon"].skyPosition.RA, pd.planets["Moon"].skyPosition.decl);

				case "SunMoo": return Calculation(pd.planets["Sun"].skyPosition.RA, pd.planets["Sun"].skyPosition.decl, pd.planets["Moon"].skyPosition.RA, pd.planets["Moon"].skyPosition.decl);
			}
			return 0;
		}

		public double Calculation (double RA1, double decl1, double RA2, double decl2)
		{
			return Math.Acos(
				Math.Sin(decl1*Math.PI/180)*Math.Sin(decl2*Math.PI/180)+
				Math.Cos(decl1*Math.PI/180)*Math.Cos(decl2*Math.PI/180)*Math.Cos((RA1-RA2)*Math.PI/180))*180/Math.PI;
		}
	}
}
