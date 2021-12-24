using System;
using Random = UnityEngine.Random;

public static class EnumUtils
{
	/// <summary>
	/// Returns a random enum value
	/// </summary>
	public static T GetRandom<T>()
	{
		var values = Enum.GetValues(typeof(T));
		return (T)values.GetValue(Random.Range(0, values.Length));
	}
}