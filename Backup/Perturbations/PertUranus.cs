using System;

namespace Planetarium
{
	/// <summary>
	/// 
	/// </summary>
	public class PertUranus : APerturbations
	{
		public PertUranus(){}

		public override double PertInLon()
		{
			double lon1 = 0.04*Math.Sin((pert.Msat-2*pert.Mu+6)*PI/180); 
			double lon2 = 0.035*Math.Sin((pert.Msat-3*pert.Mu+33)*PI/180); 
			double lon3 = -0.015*Math.Sin((pert.Mj-pert.Mu+20)*PI/180);  
			double lon = lon1 + lon2 + lon3;
			return lon;
		}

		public override double PertInLat()
		{
			return 0;
		}

		public override double PertInDist()
		{
			return 0;
		}

		private double PI = Math.PI;
	}
}
