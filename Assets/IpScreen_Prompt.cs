using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;
using System.Collections.Generic;

public class IpScreen_Prompt : MonoBehaviour {

	public GameObject headset;
	public GameObject ipscrn;

	private NetworkClient client;

	void Start () 
	{
		//client = new NetworkClient();
		//client.Connect("127.0.0.1", 888);
		//client.RegisterHandler(MsgType.Error, OnError);
		//client.RegisterHandler(MsgType.Error, OnError);
		//ipscrn.gameObject.transform.localPosition = Vector2.right*500;
	}

	void update()
	{
	//	if(NetworkManager.singleton.OnClientError)
	}

public void OnFailedToConnect(NetworkConnectionError error)
	{
		Debug.Log ("Error occured");
	}

public void OnClientError(NetworkConnectionError error)
	{
		Debug.Log ("Error occured");
	}

	/*public void OnError(NetworkMessage netMsg)
	{
		netMsg.ReadMessage<ErrorMessage>();
		Debug.Log ("Error occured");

		//IpScreen ();
	}
	*/

}


