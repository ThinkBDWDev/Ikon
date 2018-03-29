using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button_Support : MonoBehaviour {

	public void eventreset()
	{
		EventSystem es = GameObject.Find("EventSystem").GetComponent<EventSystem>();
		es.SetSelectedGameObject(null);
		es.SetSelectedGameObject(es.firstSelectedGameObject);
	}


}
