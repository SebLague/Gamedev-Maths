using System;

public static class Geometry
{

	// Explanation of below methods:
	// youtu.be/KHuI9bXZS74?list=PLFt_AvWsXl0cD2LPxcjxVjWTQLxJqKpgZ
	 

	/// Distance of point C from the line passing through points A and B.
	public static double DistanceFromPointToLine(Point a, Point b, Point c)
	{
		double s1 = -b.y + a.y;
		double s2 = b.x - a.x;
		return Math.Abs((c.x - a.x) * s1 + (c.y - a.y) * s2) / Math.Sqrt(s1*s1 + s2*s2);
	}

	/// Psuedo distance of point C from the line passing through points A and B.
	/// This is not the actual distance value, but a further point will always have a higher value than a nearer point.
	/// Faster than calculating the actual distance. Useful for sorting.
	public static double PseudoDistanceFromPointToLine(Point a, Point b, Point c)
	{
		return Math.Abs((c.x - a.x) * (-b.y + a.y) + (c.y - a.y) * (b.x - a.x));
	}

	/// Determines which side point C lies of the line passing through points A and B
	/// Returns +1 if on one side of line, -1 if on the other, and 0 if it lies exactly on the line
	public static int SideOfLine(Point a, Point b, Point c)
	{
		return Math.Sign((c.x - a.x) * (-b.y + a.y) + (c.y - a.y) * (b.x - a.x));
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