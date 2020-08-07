using System;

namespace AngryBirds
{
	public static class AngryBirdsTask
	{
		/// <param name="v">Speed</param>
		/// <param name="distance">Distance</param>
		/// <returns>Aiming angle from 0 to Pi/2</returns>
		/// 
		public static double FindSightAngle(double v, double distance)
		{
			//Equation S = V^2 / G * Sin * 2a
			double gravity = 9.8;
			//Math.Pow can be used, but if we are looking 
			//for power 2 / power 3 more efficient to use multiplication
			double sin2A = distance / (v*v/gravity);
			double angle = Math.Asin(sin2A) / 2;
			return angle;
		}
	}
}