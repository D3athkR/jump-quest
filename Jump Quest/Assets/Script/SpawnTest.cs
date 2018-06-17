using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour {

	public Transform[] spawnerLocations;
	public GameObject[] prefabsToSpawn;
	private GameObject[] prefabsToClone;
	public float delayTime;
	private bool isempty=false;


	// Use this for initialization
	void Start () {
		prefabsToClone = new GameObject[prefabsToSpawn.Length];
		StartCoroutine(ExecuteAfterTime());
	}
	

    void Spawn() {
        for (int i=0; i<prefabsToSpawn.Length; i++) {
            prefabsToClone[i] = Instantiate(prefabsToSpawn[i], spawnerLocations[i].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        }
    }


    void DestroyClonedGameObjects() {
        for ( int i = 0; i < prefabsToClone.Length; i++) {
            Destroy(prefabsToClone[i]);
        }
    }


    public void Respawn() {
        DestroyClonedGameObjects();
        Spawn();
    }



	// Update is called once per frame
	void Update () {
		for (int i=0; i<prefabsToClone.Length; i++){
			if(prefabsToClone[i]==null){
			Start();
			}
		}
	}


	IEnumerator ExecuteAfterTime(){
	if (isempty)
		yield break;

	isempty=true;
	yield return new WaitForSeconds(delayTime);

		Invoke("Spawn",delayTime);

	isempty=false;
		}

}






