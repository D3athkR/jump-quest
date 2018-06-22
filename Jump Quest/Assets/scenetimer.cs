using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scenetimer : MonoBehaviour {
public float startTime= 60.0f;
public Text timeText; 

	// Update is called once per frame
	void Update () {

		float t= startTime -= Time.deltaTime;
		
		string minutes = ((int) t / 60).ToString(); 
		string seconds = (t % 60).ToString("f2"); 
		
	timeText.text = minutes + ":" + seconds; 


	if(startTime <=0)
		{
		SceneManager.LoadScene("scoreboard");
		}
	}
}
