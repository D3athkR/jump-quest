using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

public Transform[] SpawnLocation; 
public GameObject[] PrefabstoSpawn; 
public GameObject[] PrefabstoClone;
public float delayTime;
private bool isempty=false;


void Start(){
			StartCoroutine(ExecuteAfterTime());
		}


void Spawn(){
		PrefabstoClone[0] = Instantiate(PrefabstoSpawn[0], SpawnLocation[0].transform.position,Quaternion.Euler(0,0,0)) as GameObject;
		}


void Update () {
		if(PrefabstoClone[0]==null){
			Start();
			}
		}


	IEnumerator ExecuteAfterTime(){
	if (isempty)
		yield break;

	isempty=true;
	yield return new WaitForSeconds(delayTime);

		Invoke("Spawn",delayTime);

	//isempty=false;
		}


}

