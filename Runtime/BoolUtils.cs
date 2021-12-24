using UnityEngine;

public static class BoolUtils
{
	/// <summary>
	/// Randomize a bool value 
	/// </summary>
	/// <param name="input"></param>
	/// <param name="oddsTrue">The odds (between 0 and 1) to return true</param>
	public static void Randomize(this ref bool input, float oddsTrue = 0.5f)
	{
		input = Random.value <= oddsTrue;
	}
}