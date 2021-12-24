using UnityEngine;

public static class GameObjectUtils
{
	/// <summary>
	/// Tries to get a component on a GameObject and add it if it wasn't found
	/// </summary>
	public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
	{
		var result = gameObject.GetComponent<T>();

		if (result == null)
		{
			result = gameObject.AddComponent<T>();
		}

		return result;
	}

	/// <summary>
	/// Tries to get a component on a GameObject and add it if it wasn't found
	/// </summary>
	public static bool HasComponent<T>(this GameObject gameObject) where T : Component
	{
		return gameObject.GetComponent<T>() != null;
	}
}