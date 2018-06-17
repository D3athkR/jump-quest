using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour {

public Transform[] spawnLocation; 
public GameObject[] whatToSpawnPrefab; 
public GameObject[] whatToSpawnClone;
public float delayTime;
private bool isempty=false;


void Start(){
			StartCoroutine(ExecuteAfterTime());
		}


void spawnningPoint (){
		whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocation[0].transform.position,Quaternion.Euler(0,0,0)) as GameObject;
		}


void Update () {
		if(whatToSpawnClone[0]==null){
			Start();
			}
		}


	IEnumerator ExecuteAfterTime(){
	if (isempty)
		yield break;

	isempty=true;
	yield return new WaitForSeconds(delayTime);

		Invoke("spawnningPoint",delayTime);

	isempty=false;
		}


}

