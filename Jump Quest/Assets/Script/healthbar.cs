using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class healthbar : MonoBehaviour {

public Scrollbar Healthbar;
public float Health = 100;


	public void Damage (float value){
	
		Health -= value;
		Healthbar.size = Health/100f;
	
	
	}
	
	
	
	}
