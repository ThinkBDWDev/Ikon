using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResetButtons : MonoBehaviour {

	private Component[] tgle;
	private ToggleGroup[] tglegrp;

	public void ToggleReset()
	{
		tglegrp = gameObject.GetComponentsInChildren<ToggleGroup> ();
		foreach (ToggleGroup tg in tglegrp) 
		{

			tg.allowSwitchOff = true;
			Debug.Log("tglegrp_OFF");

		}
		tgle = gameObject.GetComponentsInChildren<Toggle>();
		foreach(Toggle t in tgle)
		{
			t.IsInteractable();
			t.isOn = false;
			}
		}

}
