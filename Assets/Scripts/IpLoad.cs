using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IpLoad : MonoBehaviour {

	public InputField ipField;




void Start () 
	{
	string infoload = PlayerPrefs.GetString ("data","");
	GameObject.Find ("InputField").transform.FindChild ("Placeholder").GetComponent<Text>().text = infoload;
	ipField.text = infoload;
	Debug.Log ("Initial SavedIP = " +infoload);
	}
	
void OnLevelWasLoaded(int level)
	{
		if (level == 0)
		{
			StartCoroutine(iploading());
		}
	}

IEnumerator  iploading()	
	{
		yield return new WaitForSeconds (.3f);

		string infoload = PlayerPrefs.GetString ("data","");
		GameObject.Find ("InputField").transform.FindChild ("Placeholder").GetComponent<Text>().text = infoload;
		ipField.text = infoload;
		Debug.Log ("SavedIP = " +infoload);

	}

}
