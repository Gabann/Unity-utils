using UnityEngine;

public static class TransformUtils
{
	/// <summary>
	/// Destroy all childs in transform
	/// </summary>
	public static void DestroyAllChildrens(this Transform t)
	{
		foreach (Transform child in t)
		{
			Object.Destroy(child.gameObject);
		}
	}

	/// <summary>
	/// Sets transform position
	/// </summary>
	public static void SetPosition(this Transform transform, float x = float.NaN, float y = float.NaN, float z = float.NaN)
	{
		var pos = transform.position;

		if (!float.IsNaN(x))
		{
			pos.x = x;
		}

		if (!float.IsNaN(y))
		{
			pos.y = y;
		}

		if (!float.IsNaN(z))
		{
			pos.z = z;
		}

		transform.position = pos;
	}

	/// <summary>
	/// Reset transform position and rotation to 0 and reset transform scale to 1 <br/>
	/// Similar to the editor transform reset button
	/// </summary>
	/// <param name="t"></param>
	public static void Reset(this Transform t)
	{
		t.position = Vector3.zero;
		t.rotation = Quaternion.identity;
		t.localScale = Vector3.one;
	}

	/// <summary>
	/// Reset transform local position and rotation to 0 and reset transform local scale to 1 <br/>
	/// </summary>
	/// <param name="t"></param>
	public static void LocalReset(this Transform t)
	{
		t.localPosition = Vector3.zero;
		t.localRotation = Quaternion.identity;
		t.localScale = Vector3.one;
	}
}