using System;

public static class Geometry
{

	// Explanation of PointInTriangle method:
	// youtu.be/KHuI9bXZS74?list=PLFt_AvWsXl0cD2LPxcjxVjWTQLxJqKpgZ
	 
	/// Determines whether point P is inside the triangle ABC
	public static bool PointInTriangle(Point A, Point B, Point C, Point P)
	{
			double s1 = C.y - A.y;
			double s2 = C.x - A.x;
			double s3 = B.y - A.y;
			double s4 = P.y - A.y;

			double w1 = (A.x * s1 + s4 * s2 - P.x * s1) / (s3 * s2 - (B.x-A.x) * s1);
			double w2 = (s4- w1 * s3) / s1;
			return w1 >= 0 && w2 >= 0 && (w1 + w2) <= 1;
	}
	
}

public struct Point
{
	public readonly double x;
	public readonly double y;

	public Point(double x, double y)
	{
		this.x = x;
		this.y = y;
	}
}