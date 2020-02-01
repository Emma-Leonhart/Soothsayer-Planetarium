using System;

namespace Planetarium
{
	/// <summary>
	/// Summary description for ADSObject.
	/// </summary>
	public abstract class ADSObject : IDSObject
	{
		public SkyPos skyPosition = new SkyPos();

		public ADSObject(){}

		#region IDSObject Members

		public string designation{
			get {return v_designation;}
			set {v_designation = value;}
		}
		public string name{
			get {return v_name;}
			set {v_name = value;}
		}
	
		private string v_designation, v_name;
 
		#endregion
	}
}
