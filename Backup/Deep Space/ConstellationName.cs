using System;

namespace Planetarium
{
	/// <summary>
	/// Summary description for ConstellationName.
	/// </summary>
	public class ConstellationName
	{
		public string name;
		public SkyPos skyPos = new SkyPos();

		public ConstellationName(string name, SkyPos sp)
		{
			this.name = name;
			this.skyPos = sp;
		}
	}
}
