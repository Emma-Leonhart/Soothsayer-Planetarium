using System;

namespace Planetarium
{
	/// <summary>
	/// 
	/// </summary>
	public class PertMoon : APerturbations
	{
		public PertMoon(){}

		public override double PertInLon()
		{
			double lon1 = -1.274 * Math.Sin((pert.Mm-2*pert.D)*PI/180);
			double lon2 = 0.658 * Math.Sin((2*pert.D)*PI/180);
			double lon3 = -0.186 * Math.Sin((pert.Msun)*PI/180);
			double lon4 = -0.059 * Math.Sin((2*pert.Mm-2*pert.D)*PI/180);
			double lon5 = -0.057 * Math.Sin((pert.Mm-2*pert.D+pert.Msun)*PI/180);
			double lon6 = 0.053 * Math.Sin((pert.Mm+2*pert.D)*PI/180);
			double lon7 = 0.046 * Math.Sin((2*pert.D-pert.Msun)*PI/180);
			double lon8 = 0.041 * Math.Sin((pert.Mm-pert.Msun)*PI/180);
			double lon9 = -0.035 * Math.Sin((pert.D)*PI/180);
			double lon10 = -0.031 * Math.Sin((pert.Mm+pert.Msun)*PI/180);
			double lon11 = -0.015 * Math.Sin((2*pert.F-2*pert.D)*PI/180);
			double lon12 = +0.011 * Math.Sin((pert.Mm-4*pert.D)*PI/180);
			double lon = lon1 + lon2 + lon3 + lon4 + lon5 + lon6 + 
				         lon7 + lon8 + lon9 + lon10 + lon11 + lon12;
			return lon;
		}

		public override double PertInLat()
		{
			double lat1 = -0.173 * Math.Sin((pert.F-2*pert.D)*PI/180);
			double lat2 = -0.055 * Math.Sin((pert.Mm-pert.F-2*pert.D)*PI/180);
			double lat3 = -0.046 * Math.Sin((pert.Mm+pert.F-2*pert.D)*PI/180);
			double lat4 = 0.033 * Math.Sin((pert.F+2*pert.D)*PI/180);
			double lat5 = 0.017 * Math.Sin((2*pert.Mm+pert.F)*PI/180);
			double lat = lat1 + lat2 + lat3 + lat4 + lat5;
			return lat;
		}

		public override double PertInDist()
		{
			double d1 = -0.58 * Math.Cos((pert.Mm-2*pert.D)*PI/180);
			double d2 = -0.46 * Math.Cos((2*pert.D)*PI/180);
			double dist = d1 + d2;
			return dist;
		}

		private double PI = Math.PI;
	}
}
