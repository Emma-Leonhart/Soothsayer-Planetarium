using System;

namespace Planetarium
{
	/// <summary>
	/// 
	/// </summary>
	interface IPerturbations
	{
		double PertInLon();
		double PertInLat();
		double PertInDist();
	}
}
