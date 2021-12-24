using UnityEngine;

public static class ArrayUtils
{
	/// <summary>
	/// Returns a random element from an array
	/// </summary>
	public static T GetRandom<T>(this T[] array)
	{
		return array[Random.Range(0, array.Length)];
	}

	/// <summary>
	/// Randomly shuffle an array
	/// </summary>
	public static T[] Shuffle<T>(this T[] array)
	{
		for (var i = 0; i < array.Length; i++)
		{
			var temp = array[i];
			var rand = Random.Range(i, array.Length);
			array[i] = array[rand];
			array[rand] = temp;
		}

		return array;
	}

	/// <summary>
	/// Print array values to the console
	/// </summary>
	public static void Print<T>(this T[] array)
	{
		Debug.Log(string.Join(", ", array));
	}
}