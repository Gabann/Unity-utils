using System.Collections.Generic;
using UnityEngine;

public static class ListUtils
{
	/// <summary>
	/// Returns a random element from a list
	/// </summary>
	public static T GetRandom<T>(this List<T> list)
	{
		if (list.Count == 0) throw new System.IndexOutOfRangeException("Cannot ");
		var random = Random.Range(0, list.Count);
		return list[random];
	}

	/// <summary>
	/// Removes a random element from a list
	/// </summary>
	public static void RemoveRandom<T>(this List<T> list)
	{
		var random = Random.Range(0, list.Count);
		list.RemoveAt(random);
	}

	/// <summary>
	/// Returns and removes a random element from a list
	/// </summary>
	public static T TakeRandom<T>(this List<T> list)
	{
		var random = Random.Range(0, list.Count);
		list.RemoveAt(random);
		return list[random];
	}

	/// <summary>
	/// Randomly shuffle a list
	/// </summary>
	public static List<T> Shuffle<T>(this List<T> list)
	{
		for (var i = 0; i < list.Count; i++)
		{
			var temp = list[i];
			var rand = Random.Range(i, list.Count);
			list[i] = list[rand];
			list[rand] = temp;
		}

		return list;
	}

	/// <summary>
	/// Print list values to the console
	/// </summary>
	public static void Print<T>(this List<T> list)
	{
		Debug.Log(string.Join(", ", list));
	}
}