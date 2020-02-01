using System;

namespace Planetarium
{
	/// <summary>
	/// 
	/// </summary>
	public class Sun : APlanet
	{
		public Sun(string name){this.name = name;}

		public override void OrbitalElements()
		{
			N=0; i=0; a=1;
			w = 282.9404 + 4.70935E-5 * location.dayNumber();
			ec = 0.016709 - 1.151E-9 * location.dayNumber();
			M = 356.047 + 0.9856002585 * location.dayNumber();
			M += ((int)Math.Abs(M/360)+1)*360;

			location.oblecl = 23.4393 - 3.563E-7 * location.dayNumber();

			pert.Msun = M;
		}

		public override void GeocentricPos()
		{
			double L = (w + M)%360; 
			double E = M + (180/Math.PI * ec * Math.Sin(M*PI/180) * (1 + ec * Math.Cos(M*PI/180)));
			double x1 = Math.Cos(E*PI/180) - ec;
			double y1 = Math.Sin(E*PI/180)*Math.Sqrt(1-ec*ec);
			double r = Math.Sqrt(x1*x1+y1*y1);
			double v = Math.Atan2(y1,x1) * 180/PI;
			double lon = v + w;
			position.x = r * Math.Cos(lon*PI/180);
			position.y = r * Math.Sin(lon*PI/180);
			position.z = 0.0;
			double xeq = position.x;
			double yeq = position.y * Math.Cos(location.oblecl*PI/180) - position.z * Math.Sin(location.oblecl*PI/180);
			double zeq = position.y * Math.Sin(location.oblecl*PI/180) + position.z * Math.Cos(location.oblecl*PI/180);
			dist = Math.Sqrt(xeq*xeq + yeq*yeq + zeq*zeq);
			name = "Sun";

			skyPosition.RA = (360+(Math.Atan2(yeq,xeq) * 180/PI))%360;
			skyPosition.decl = Math.Asin(zeq/dist) * 180/PI;

			pert.Ls = L; 
			location.xs = position.x;
			location.ys = position.y;
			location.zs = position.z;
			location.slon = lon;
			location.sRA = skyPosition.RA;
			location.sDecl = skyPosition.decl;
		}

		public override void Ephemerides()
		{
			diam = 1919.26;
			magnitude = -24;
		}

		private PertElements pert = PertElements.GetInstance();
	}
}
