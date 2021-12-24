using UnityEngine;

public static class Rigidbody2DUtils
{
	/// <summary>
	/// Freezes the rigidbody
	/// </summary>
	public static void Freeze(this Rigidbody2D rb)
	{
		rb.velocity = Vector2.zero;
		rb.angularVelocity = 0;
		rb.isKinematic = true;
	}
}