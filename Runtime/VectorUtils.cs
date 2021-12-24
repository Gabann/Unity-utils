using UnityEngine;

public static class VectorUtils
{
	/// <summary>
	/// Transform a vector 3 into a vector 2
	/// </summary>
	public static Vector2 ToVector2(this Vector3 input)
	{
		return new Vector2(input.x, input.y);
	}

	// /// <summary>
	// /// Change a Vector2 x value
	// /// </summary>
	// public static void SetX(ref this Vector2 input, float x)
	// {
	// 	input = new Vector2(x, input.y);
	// }
	//
	// /// <summary>
	// /// Change a Vector2 y value
	// /// </summary>
	// public static void SetY(ref this Vector2 input, float y)
	// {
	// 	input = new Vector2(input.x, y);
	// }

	/// <summary>
	/// Add a value to a Vector2 x value
	/// </summary>
	public static void AddX(ref this Vector2 input, float x)
	{
		input = new Vector2(input.x + x, input.y);
	}

	/// <summary>
	/// Add a value to a Vector2 y value
	/// </summary>
	public static void AddY(ref this Vector2 input, float y)
	{
		input = new Vector2(input.x, input.y + y);
	}

	// /// <summary>
	// /// Change a Vector3 x value
	// /// </summary>
	// public static void SetX(ref this Vector3 input, float x)
	// {
	// 	input = new Vector3(x, input.y, input.z);
	// }
	//
	// /// <summary>
	// /// Change a Vector3 y value
	// /// </summary>
	// public static void SetY(ref this Vector3 input, float y)
	// {
	// 	input = new Vector3(input.x, y, input.z);
	// }	
	//
	// /// <summary>
	// /// Change a Vector3 z value
	// /// </summary>
	// public static void SetZ(ref this Vector3 input, float z)
	// {
	// 	input = new Vector3(input.x, input.y, z);
	// }

	/// <summary>
	/// Add a value to a Vector3 x value
	/// </summary>
	public static void AddX(ref this Vector3 input, float x)
	{
		input = new Vector3(input.x + x, input.y, input.z);
	}

	/// <summary>
	/// Add a value to a Vector3 y value
	/// </summary>
	public static void AddY(ref this Vector3 input, float y)
	{
		input = new Vector3(input.x, input.y + y, input.z);
	}

	/// <summary>
	/// Add a value to a Vector3 z value
	/// </summary>
	public static void AddZ(ref this Vector3 input, float z)
	{
		input = new Vector3(input.x, input.y, input.z + z);
	}

	// Returns the distance between two vector 2
	public static float DistanceFrom(this Vector2 current, Vector2 other)
	{
		return Vector2.Distance(current, other);
	}

	// Returns the distance between two vector 3
	public static float DistanceFrom(this Vector3 current, Vector3 other)
	{
		return Vector3.Distance(current, other);
	}
}