using System;

namespace Planetarium
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class APerturbations : IPerturbations
	{
		public PertElements pert = PertElements.GetInstance();

		public APerturbations(){}

		#region IPerturbations Members

		abstract public double PertInLon();
		abstract public double PertInLat();
		abstract public double PertInDist();

		#endregion
	}
}
