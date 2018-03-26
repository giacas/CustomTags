using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Custom tags manager
/// </summary>
public class CustomTags : MonoBehaviour
{
	[SerializeField] string[] tags;

	/// <summary>
	/// Return string[] array
	/// </summary>
	/// <returns></returns>
	public string[] Tags()
	{
		return tags;
	}

	/// <summary>
	/// Return List<string> container
	/// </summary>
	/// <returns></returns>
	public List<string> ToList ()
	{
		if (tags == null) return null;

		List<string> tagsList = new List<string> (tags.Length);
		for (int i = 0; i < tags.Length; i++)
		{
			tagsList.Add (tags[i]);
		}
		return tagsList;
	}

	/// <summary>
	/// Check if a value exists in tag list
	/// </summary>
	/// <param name="value"></param>
	/// <returns></returns>
	public bool Contains(string value)
	{
		for (int i = 0; i < tags.Length; i++)
		{
			if (tags[i].ToLower().Equals(value.ToLower())) {
				return true;
			}
		}
		return false;
	}
}
