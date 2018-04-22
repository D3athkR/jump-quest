using UnityEngine;
using System.Collections;

public class Bgm : MonoBehaviour {
	
	
	AudioSource source;
	// Use this for initialization
	void Start () {
		source = GameObject.FindWithTag("Player").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
