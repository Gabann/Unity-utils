public static class StringUtils
{
	/// <summary>
	/// Returns true if the string is null or empty
	/// </summary>
	public static bool IsNullOrEmpty(this string input)
	{
		return string.IsNullOrEmpty(input);
	}

	/// <summary>
	/// Truncate a string to max size
	/// </summary>
	public static string Truncate(this string input, int maxLength)
	{
		if (input.IsNullOrEmpty())
		{
			return input;
		}
		else
		{
			return input.Length <= maxLength ? input : input.Substring(0, maxLength);
		}
	}
}