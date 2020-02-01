using System;

namespace Planetarium
{
	/// <summary>
	/// 
	/// </summary>
	public class PertJupiter : APerturbations
	{
		public PertJupiter(){}

		public override double PertInLon()
		{
			double lon1 = -0.332*(Math.Sin((2*pert.Mj-5*pert.Msat-67.6)*PI/180)); 
			double lon2 = -0.056*Math.Sin((2*pert.Mj-2*pert.Msat+21)*PI/180); 
			double lon3 = 0.042*Math.Sin((3*pert.Mj-5*pert.Msat+21)*PI/180); 
			double lon4 = -0.036*Math.Sin((pert.Mj-2*pert.Msat)*PI/180); 
			double lon5 = 0.022*Math.Cos((pert.Mj-pert.Msat)*PI/180); 
			double lon6 = 0.023*Math.Sin((2*pert.Mj-3*pert.Msat+52)*PI/180); 
			double lon7 = -0.016*Math.Sin((pert.Mj-5*pert.Msat-69)*PI/180); 
			double lon = lon1 + lon2 + lon3 + lon4 + lon5 + lon6 + lon7;
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
