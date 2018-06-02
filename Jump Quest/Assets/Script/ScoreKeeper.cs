using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
public static int Score = 0; 
private Text myText;

	void Start(){
		myText= GetComponent<Text>();		
	}




	public void score(int points){ 
		Debug.Log("scorecard");
		Score += points;
		myText.text = Score.ToString();
		
	}
	
	
	
		
	}
	
	

	
	
