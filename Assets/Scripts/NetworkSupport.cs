using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;
using UnityEngine.EventSystems;
using UnityEngine.VR;

[System.Serializable]
public class NetworkSupport : NetworkManager {

	public GameObject headsetconn;
	public GameObject ipfields;
	public bool Handheld;
	public bool hidecursor;

public void RunServer()
	{
	NetworkManager.singleton.StartServer();
	}
	
public void RunClient()
	{
	SetIpAddress ();
	SetPort ();
	NetworkManager.singleton.StartClient();
	}

void SetIpAddress()
{
		string ipIn = GameObject.Find ("InputField").transform.FindChild ("Text").GetComponent<Text>().text;
		PlayerPrefs.SetString ("data", ipIn);
		NetworkManager.singleton.networkAddress = ipIn;
		Debug.Log ("IP = " +ipIn);
}

void SetPort()
{
	NetworkManager.singleton.networkPort = 7777;
}


void Start()
	{	

		if(hidecursor == true)
		{
			Cursor.visible = false;	
		}
		if(hidecursor == false)
		{
			Cursor.visible = true;
		}
		if (Handheld == true)
		{
			return;
			//VRSettings.enabled = false;
		}
		if(Handheld == false)
		{
			//VRSettings.enabled = true;
			RunServer();
		}
	}

	public override void OnServerDisconnect(NetworkConnection conn)
	{
		Debug.Log ("Disconnected!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
		NetworkServer.DestroyPlayersForConnection(conn);
		//NetworkManager.singleton.ServerChangeScene ("Start");
	}

void OnLevelWasLoaded(int level)

{
	if(level==0)
	{
		StartCoroutine(setupmenuscenebuttons());
	}
	if(level==1)
	{
		setupotherscenebuttons();
	}
}

IEnumerator  setupmenuscenebuttons()
{
yield return new WaitForSeconds (0.3f);

//GameObject.Find ("Btn_Server").GetComponent<Button>().onClick.RemoveAllListeners ();
//GameObject.Find ("Btn_Server").GetComponent<Button>().onClick.AddListener (RunServer);

GameObject.Find ("Btn_Client").GetComponent<Button>().onClick.RemoveAllListeners ();
GameObject.Find ("Btn_Client").GetComponent<Button>().onClick.AddListener (RunClient);
GameObject.Find ("Connect").GetComponent<Button>().onClick.RemoveListener(RunClient);
GameObject.Find ("Connect").GetComponent<Button>().onClick.AddListener (RunClient);

}

void setupotherscenebuttons()
{
//GameObject.Find ("Btn_Disconnect").GetComponent<Button>().onClick.RemoveAllListeners ();
//GameObject.Find ("Btn_Disconnect").GetComponent<Button>().onClick.AddListener (NetworkManager.singleton.StopHost);

}
}