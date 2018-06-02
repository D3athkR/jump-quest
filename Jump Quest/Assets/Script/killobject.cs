
using UnityEngine;
using System.Collections;

public class killobject : MonoBehaviour {
public Transform spawnPoint;


void OnTriggerEnter2D(Collision2D col){
	if(col.transform.CompareTag("item"))
	col.transform.position=spawnPoint.position; 


}
}
