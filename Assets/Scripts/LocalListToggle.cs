using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LocalListToggle : MonoBehaviour {

	public GameObject panel;
	public ToggleGroup tggrp;

	private Toggle tg;
	private Component[] tgle;

	public void ListToggle()
	{
		tg = gameObject.GetComponent<Toggle>();

		if(tg.isOn == true)
		{
			panel.SetActive(true);
		}else{
			panel.SetActive(false);
			StartCoroutine (resetToggles());
		}

	}

	IEnumerator resetToggles()
	{
		tggrp.allowSwitchOff = true;
		tgle = tggrp.GetComponentsInChildren<Toggle>();

		foreach(Toggle t in tgle)
		{ 
			t.isOn = (false);
			Debug.Log("tgle_OFF");
		}
		yield return null;
	}



}
