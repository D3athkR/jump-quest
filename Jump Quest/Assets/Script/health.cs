using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnitySampleAssets._2D; //uses scripts from Unity Asset 2D Folder

public class health : MonoBehaviour {
public const int maxHealth = 100;
public int currentHealth= maxHealth;
public GameObject theplayer;
public RectTransform healthBar;

	//		GameObject theplayer= GameObject.Find("Player");
		//testing playform= theplayer.GetComponent<testing>();
		//playform.maxSpeed=5f; 

void start(){
}


public void TakeDamage (int amount)
{

	currentHealth -= amount;
	if (currentHealth <=0)
	{
	currentHealth = 0;
	Debug.Log ("Dead!"); 
	Destroy(gameObject);
		}

   if (currentHealth <= 50)
   {
   Debug.Log ("half reduced");
<<<<<<< HEAD:Jump Quest/Assets/health.cs


=======
	GameObject thePlayer = GameObject.Find("Player1");
	PlatformerCharacter2D platform = thePlayer.GetComponent<PlatformerCharacter2D>();
	platform.maxSpeed = 1f;
	platform.jumpForce = 200f;
>>>>>>> 2fbea439a7e69f25f9fae2d17cb3cd61f23b8202:Jump Quest/Assets/Script/health.cs
  }

		healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);

}
}

