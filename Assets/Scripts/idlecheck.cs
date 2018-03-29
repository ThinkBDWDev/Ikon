using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class idlecheck : MonoBehaviour {

	public GameObject cam;
	//public Image bg; 
	public GameObject bglogo;
	//public Text timetext;
	//public Text rotatemag;
	public int delay = 5;

	private Vector3 currectrotvect;
	private Vector3 lastrectvect;


	private float timer;
	private bool idle;
	private bool fade;
	private int nextUpdate = 1;

	private Color v = new Color(1.0f,1.0f,1.0f,1.0f);
	private Color i = new Color(1.0f,1.0f,1.0f,0.0f);

	void Awake()
	{
		idle = false;
		bglogo.SetActive(false);
		Invoke("time", 10f);
		timer = delay;
	}
	void Update () 
	{
		timer -= Time.deltaTime;
		//timetext.text = "Timer = " +timer.ToString();
		if(Time.time>=nextUpdate)
		{

			nextUpdate = Mathf.RoundToInt(Time.time)+1;
			currectrotvect = cam.transform.localRotation.eulerAngles;
			//rotatemag.text = "Mag = " +currectrotvect.magnitude.ToString("F0");
			bglogo.SetActive(false);

		if(currectrotvect.magnitude.ToString("F0") == lastrectvect.magnitude.ToString("F0"))
		{
				Debug.Log("Idle");
				idle = true;
				fade = true;
					time();
		}

		if(currectrotvect.magnitude.ToString("F0") != lastrectvect.magnitude.ToString("F0"))
		{
			idle = false;
				fade = false;
				timer=delay;
				if(idle == false)
				{
					bglogo.SetActive(false);
				}
			Debug.Log("not idle");
				}
	lastrectvect = currectrotvect;
		}
	}

	private void time()
	{

		if(idle == true && fade == true)
		{
			if(timer <=0)
			{
			bglogo.SetActive(true);
			fade = false;
			Debug.Log("Fade");
			}
			//bg.CrossFadeColor(i,1.0f,true,true);

		}
	}

}




