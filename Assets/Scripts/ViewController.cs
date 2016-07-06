using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ViewController : MonoBehaviour
{

	public float itemCount;
	public ListItemPanel todoItem;
	public Canvas canvas;

	void Start ()
	{
		GameObject itemObject = GameObject.FindWithTag ("ItemPanel");
		if (itemObject != null) {
			todoItem = itemObject.GetComponent<ListItemPanel> ();
			GenerateItem ();
		}
		if (todoItem == null) {
			Debug.Log ("Cannot find 'ListItemPanel' script");
		}
	}

	void GenerateItem ()
	{

		for (int i = 0; i < itemCount; i++) {

			Vector3 position = new Vector3 (0, 10, 0);

			ListItemPanel item = Instantiate(todoItem);
			item.transform.parent = canvas.transform;

			RectTransform transform = item.GetComponent<RectTransform>();
			item.todoText.text = "---" + i + "---";
			transform.position = canvas.GetComponent<RectTransform>().position;
//transform.position = position;
//transform.offsetMin = new Vector2(0, 1);
//transform.offsetMax = new Vector2(0, 1);
//			transform.anchorMax = new Vector2(1, 1);
//			transform.anchorMin = new Vector2(0,1);
		}	

	}
	
}
