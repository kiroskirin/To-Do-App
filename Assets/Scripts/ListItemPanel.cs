using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ListItemPanel : MonoBehaviour
{
	public Text todoText;

	public void SetText (string text)
	{
		this.todoText.text = text;
	}
}
