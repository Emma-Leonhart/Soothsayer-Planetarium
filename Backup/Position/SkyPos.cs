using System;

namespace Planetarium
{
	/// <summary>
	/// 
	/// </summary>
	public struct SkyPos
	{
		public double RA, decl, a, A;

		public void eqToaA (double SIDTIME, double LAT)
		{
			double ZPX = SIDTIME*15-RA;
			double pi = Math.PI;
			double AA=0, Atemp=0;

			a = Math.Asin(
				Math.Sin(decl*pi/180)*Math.Sin(LAT*pi/180)+
				Math.Cos(decl*pi/180)*Math.Cos(LAT*pi/180)*Math.Cos(ZPX*pi/180)
				         )*180/pi;

			Atemp = (-Math.Sin(decl*pi/180)*Math.Cos(LAT*pi/180)+
				     Math.Sin(LAT*pi/180)*Math.Cos(decl*pi/180)*Math.Cos(ZPX*pi/180))/
				     Math.Sin((90-a+0.0000001)*pi/180);
			if (Atemp > 1) Atemp=1;
			if (Atemp < -1) Atemp=-1;
			A = Math.Acos(Atemp)*180/pi;

			Atemp = Math.Sin(ZPX*pi/180)*Math.Cos(decl*pi/180)/Math.Sin((90-a)*pi/180);
			if (Atemp > 1) Atemp=1;
			if (Atemp < -1) Atemp=-1;
			AA = Math.Asin(Atemp)*180/pi;
			
			if (Math.Round(A-AA,3) == 180) { A = (-AA); return;}
			if (Math.Round(AA+A,0) == 0) { A=180+AA; return;}
			if (Math.Round(AA-A,0) == 0) { A=180+A; return;}
			if (Math.Round(AA+A,0) == 180) A=360-AA;
		}

		public void aAToeq (double SIDTIME, double LAT)
		{
			SIDTIME *= 15;
			double pi = Math.PI;
			double RR=0, Rtemp=0;
			LAT += 0.0001;

			Rtemp = Math.Cos((a-90)*pi/180)*Math.Sin(LAT*pi/180)-
				    Math.Sin((a-90)*pi/180)*Math.Cos(LAT*pi/180)*Math.Cos(A*pi/180);
			if (Rtemp > 1) Rtemp=1;
			if (Rtemp <-1) Rtemp=-1;
			decl = Math.Asin(Rtemp)*180/pi;

			Rtemp = Math.Sin((a-90)*pi/180)*Math.Sin(A*pi/180)/
				    Math.Cos(decl*pi/180);
			if (Rtemp > 1) Rtemp=1;
			if (Rtemp <-1) Rtemp=-1;
			RR = (SIDTIME - Math.Asin(Rtemp)*180/pi + 360)%360;

			Rtemp = (Math.Cos(A*pi/180)*Math.Sin((a-90)*pi/180)+
				     Math.Sin(decl*pi/180)*Math.Cos(LAT*pi/180))/
				    (Math.Sin(LAT*pi/180)*Math.Cos((decl)*pi/180));
			if (Rtemp > 1) Rtemp=1;
			if (Rtemp <-1) Rtemp=-1;
			RA = SIDTIME - Math.Acos(Rtemp)*180/pi;

			double RRR = (RR - RA + 360)%360;
			if ((Math.Round((RA+RR)-((2*SIDTIME+360)%360),0))%360==0 && (RRR<179.8 || Math.Round(RRR,1)==360)){
				RA = RR; return;
			}
			if (Math.Round(RRR,0)==180){RA=(180+2*SIDTIME-RR+360)%360; ;return;}
			if (Math.Round((RA+RR)-(2*SIDTIME),0) != 0){RA=(RR-RRR+360)%360;return;}
		}
	}
}
