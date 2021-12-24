using UnityEngine;

public static class RandomUtils
{
	/// <summary>
	/// Return a random bool
	/// </summary>
	/// <param name="oddsTrue">The odds (between 0 and 1) to return true</param>
	public static bool RandomBool(float oddsTrue = 0.5f)
	{
		return Random.value <= oddsTrue;
	}
}