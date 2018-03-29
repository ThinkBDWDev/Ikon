using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Toggle_SpriteFade : MonoBehaviour {


	private Color a = new Vector4 (1,1,1,1);
	private Color b = new Vector4 (1,1,1,0);

	public void spriteswap()
	{
		if (gameObject.GetComponent<Toggle>().isOn == true) 
		{
			gameObject.GetComponent<Image>().color = b;
			gameObject.GetComponentInParent<ToggleGroup>().allowSwitchOff = false;
		} else 
		{
			gameObject.GetComponent<Image>().color = a;
			gameObject.GetComponentInParent<ToggleGroup>().allowSwitchOff = false;
		}
	}
}
