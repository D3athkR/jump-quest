using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class health : MonoBehaviour {
public const int maxHealth = 100;
public int currentHealth= maxHealth;
public GameObject theplayer;
public RectTransform healthBar;

	//		GameObject theplayer= GameObject.Find("Player");
		//testing playform= theplayer.GetComponent<testing>();
		//playform.maxSpeed=5f; 

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


  }

		healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);

}
}

