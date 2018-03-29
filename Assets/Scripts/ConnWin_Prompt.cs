using UnityEngine;
using System.Collections;

public class ConnWin_Prompt : MonoBehaviour {

	public GameObject headsetConn;
	public GameObject enterIp;
	public float timer = 2.0f;


void Start()
	{
		enterIp.transform.localPosition = new Vector2(700,-100);		
	}


public void ConnWinPrompt()
	{
		StartCoroutine(EnterIPWindow());
	}

public IEnumerator EnterIPWindow()
	{
		yield return new WaitForSeconds(timer);
		headsetConn.SetActive (false);
		enterIp.transform.localPosition = new Vector2(0,-100);		

				
	}
		
}

