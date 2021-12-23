using System.Collections.Generic;
using UnityEngine;

public static class ListUtils
{
	/// <summary>
	/// Returns a random element from a list
	/// </summary>
	public static T GetRandom<T>(this List<T> list)
	{
		var random = Random.Range(0, list.Count);
		return list[random];
	}
}