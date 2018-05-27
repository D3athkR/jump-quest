using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {



	public float autoLoadNextLevelAfter; 
	public int coins; 
	public Text Scoretext;
	
	public void Start(){
		if(autoLoadNextLevelAfter ==0){
		Debug.Log("Level auto be disabled"); 
		}
		else
		
		Invoke ("LoadNextLevel", autoLoadNextLevelAfter); 
		Scoretext.text="Score: " + coins;
	
	}

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}



	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel +1);	
	}

	public void AddCoins(int numberofcoins){
		coins+=numberofcoins;
		Scoretext.text="Score: " + coins;
	}

}
