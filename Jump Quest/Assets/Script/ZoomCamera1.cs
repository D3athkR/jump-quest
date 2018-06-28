using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ZoomCamera1 : MonoBehaviour {

	public float zoom = 120f;
	public float smooth =5;
	//public float normal = 60f; replace 'Camera.current.fieldOfView' with 'normal' to preset normal camera view 
	//reference tutorial - https://www.youtube.com/watch?v=-nKn7l1iu2g 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(CrossPlatformInputManager.GetButton("Zoom")) {
			GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth); 
		}
		else {
			GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, Camera.current.fieldOfView, Time.deltaTime * smooth); 
			}
	}
}
   