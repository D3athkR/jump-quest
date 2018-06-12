using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour {

public Transform[] spawnLocation; 
public GameObject[] whatToSpawnPrefab; 
public GameObject[] whatToSpawnClone;

void Start(){
		spawnningPoint();
		}


void spawnningPoint (){
		whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocation[0].transform.position,Quaternion.Euler(0,0,0)) as GameObject;






		}
}